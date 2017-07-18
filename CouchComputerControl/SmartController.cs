using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace CouchComputerControl
{
    public class SmartController : IDisposable
    {
        public Controller Controller { get; private set; }
        public GamepadThumb LeftThumb { get; private set; }
        public GamepadThumb RightThumb { get; private set; }
        public GamepadTrigger LeftTrigger { get; private set; }
        public GamepadTrigger RightTrigger { get; private set; }
        public GamepadButton ButtonA { get { return Buttons[(int)GamepadButtons.A]; } }
        public GamepadButton ButtonB { get { return Buttons[(int)GamepadButtons.B]; } }
        public GamepadButton ButtonX { get { return Buttons[(int)GamepadButtons.X]; } }
        public GamepadButton ButtonY { get { return Buttons[(int)GamepadButtons.Y]; } }
        public GamepadButton ButtonStart { get { return Buttons[(int)GamepadButtons.Start]; } }
        public GamepadButton ButtonBack { get { return Buttons[(int)GamepadButtons.Back]; } }
        public GamepadButton ButtonDPadUp { get { return Buttons[(int)GamepadButtons.DPadUp]; } }
        public GamepadButton ButtonDPadDown { get { return Buttons[(int)GamepadButtons.DPadDown]; } }
        public GamepadButton ButtonDPadRight { get { return Buttons[(int)GamepadButtons.DPadRight]; } }
        public GamepadButton ButtonDPadLeft { get { return Buttons[(int)GamepadButtons.DPadLeft]; } }
        public GamepadButton ButtonLeftShoulder { get { return Buttons[(int)GamepadButtons.LeftShoulder]; } }
        public GamepadButton ButtonRightShoulder { get { return Buttons[(int)GamepadButtons.RightShoulder]; } }
        public GamepadButton ButtonLeftThumb { get { return Buttons[(int)GamepadButtons.LeftThumb]; } }
        public GamepadButton ButtonRightThumb { get { return Buttons[(int)GamepadButtons.RightThumb]; } }
        public GamepadButton[] Buttons { get; private set; }
        public EventHandler<TickEventArgs> OnUpdateDone { get; set; }

        public enum GamepadButtons {
            A = 0,
            B,
            X,
            Y,
            Start,
            Back,
            DPadUp,
            DPadDown,
            DPadRight,
            DPadLeft,
            LeftShoulder,
            RightShoulder,
            LeftThumb,
            RightThumb
        };

        private GamepadButtonFlags[] toSharpDx = new GamepadButtonFlags[] {
            GamepadButtonFlags.A,
            GamepadButtonFlags.B,
            GamepadButtonFlags.X,
            GamepadButtonFlags.Y,
            GamepadButtonFlags.Start,
            GamepadButtonFlags.Back,
            GamepadButtonFlags.DPadUp,
            GamepadButtonFlags.DPadDown,
            GamepadButtonFlags.DPadRight,
            GamepadButtonFlags.DPadLeft,
            GamepadButtonFlags.LeftShoulder,
            GamepadButtonFlags.RightShoulder,
            GamepadButtonFlags.LeftThumb,
            GamepadButtonFlags.RightThumb
        };
        private Thread thread;
        private bool active;
        private int updateRate;

        public SmartController()
        {
            Controller = new Controller(UserIndex.One);
            LeftThumb = new GamepadThumb();
            RightThumb = new GamepadThumb();
            LeftTrigger = new GamepadTrigger();
            RightTrigger = new GamepadTrigger();
            var vls = (GamepadButtons[])Enum.GetValues(typeof(GamepadButtons));
            Buttons = vls.Select(x=>new GamepadButton(toSharpDx[(int)x], x)).ToArray();

            active = true;
            updateRate = (int)(1000f / 60f);
            thread = new Thread(BackgroundThread);
            thread.IsBackground = true;
            thread.Start();
        }

        private void BackgroundThread()
        {
            Stopwatch w = new Stopwatch(), w2 = new Stopwatch();
            while (active)
            {
                w.Start();
                w2.Start();
                Update();
                w.Stop();

                if (w.ElapsedMilliseconds < updateRate)
                    Thread.Sleep((int)(updateRate - w.ElapsedMilliseconds));

                w2.Stop();
                OnUpdateDone?.Invoke(this, new TickEventArgs(w2.Elapsed));
                w.Reset();
                w2.Reset();
            }
        }

        private void Update()
        {
            var state = new State();
            if (!Controller.GetState(out state))
                return;

            LeftThumb.Update(state.Gamepad.LeftThumbX, state.Gamepad.LeftThumbY);
            RightThumb.Update(state.Gamepad.RightThumbX, state.Gamepad.RightThumbY);
            LeftTrigger.Update(state.Gamepad.LeftTrigger);
            RightTrigger.Update(state.Gamepad.RightTrigger);

            foreach (var button in Buttons)
                button.Update(state.Gamepad.Buttons);
        }

        public void Dispose()
        {
            if (active)
            {
                active = false;
            }
        }

        public class GamepadThumb
        {
            public float X
            {
                get { return x; }
                set
                {
                    if (Math.Abs(x - value) > float.Epsilon)
                    {
                        x = value;
                        XChanged?.Invoke(this, new EventArgs());
                    }
                }
            }
            public float Y
            {
                get { return y; }
                set
                {
                    if (Math.Abs(y - value) > float.Epsilon)
                    {
                        y = value;
                        YChanged?.Invoke(this, new EventArgs());
                    }
                }
            }
            public Vector2 Vector { get { return new Vector2(X, Y); } }
            public Vector2 Direction { get { return Vector.Normalized(); } }
            public float Length { get { return Vector.Length; } }
            public EventHandler XChanged { get; set; }
            public EventHandler YChanged { get; set; }

            private float x, y;

            public GamepadThumb()
            {
                x = 0f;
                y = 0f;
            }

            public void Update(short sx, short sy)
            {
                X = ((float)sx / (float)short.MaxValue);
                Y = ((float)sy / (float)short.MaxValue);
            }
        }
        public class GamepadButton
        {
            public bool IsDown
            {
                get { return isDown; }
                private set
                {
                    if (value != isDown)
                    {
                        isDown = value;
                        if (value)
                        {
                            tickDown = Environment.TickCount;
                            WentDown?.Invoke(this, new EventArgs());
                        }
                        else
                            WentUp?.Invoke(this, new EventArgs());
                    } else if (isDown == value && isDown == true)
                    {
                        ContinuedDown?.Invoke(this, new EventArgs());
                    }
                }
            }
            public TimeSpan PressDuration { get { return IsDown ? TimeSpan.FromMilliseconds(Environment.TickCount - tickDown) : TimeSpan.Zero; } }

            public GamepadButtonFlags SharpDXButton { get; private set; }
            public GamepadButtons Button { get; private set; }
            public EventHandler WentUp { get; set; }
            public EventHandler WentDown { get; set; }
            public EventHandler ContinuedDown { get; set; }

            private long tickDown;
            private bool isDown;

            public GamepadButton(GamepadButtonFlags sharpDxButton, GamepadButtons button)
            {
                SharpDXButton = sharpDxButton;
                Button = button;
            }

            public void Update(GamepadButtonFlags flags)
            {
                IsDown = flags.HasFlag(SharpDXButton);
            }
        }
        public class GamepadTrigger
        {
            public float Value
            {
                get { return (float)trigger / (float)byte.MaxValue; }
            }

            public float PreviousValue
            {
                get { return (float)previous / (float)byte.MaxValue; }
            }
            public TriggerState State
            {
                get { return state; }
                set
                {
                    if (value != state)
                    {
                        state = value;
                        StateChanged?.Invoke(this, new EventArgs());
                        switch (state)
                        {
                            case TriggerState.Falling:
                                Falling?.Invoke(this, new EventArgs());
                                break;
                            case TriggerState.Rising:
                                Rising?.Invoke(this, new EventArgs());
                                break;
                            case TriggerState.Maximum:
                                ReachedMaximum?.Invoke(this, new EventArgs());
                                break;
                            case TriggerState.Minimum:
                                ReachedMinimum?.Invoke(this, new EventArgs());
                                break;
                        }
                    }
                }
            }
            public EventHandler ReachedMinimum { get; set; }
            public EventHandler ReachedMaximum { get; set; }
            public EventHandler Rising { get; set; }
            public EventHandler Falling { get; set; }
            public EventHandler Changed { get; set; }
            public EventHandler StateChanged { get; set; }

            public enum TriggerState { Rising, Falling, Maximum, Minimum };

            private byte trigger, previous;
            private TriggerState state;

            public GamepadTrigger()
            {
                trigger = previous = 0;
                state = TriggerState.Minimum;
            }

            public void Update(byte trg)
            {
                if (trg != trigger)
                {
                    previous = trigger;
                    trigger = trg;

                    Changed?.Invoke(this, new EventArgs());

                    //comparisions
                    if (trigger < previous)
                        State = TriggerState.Falling;
                    else if (trigger > previous)
                        State = TriggerState.Rising;

                    //min/max
                    if (trigger == byte.MinValue)
                        State = TriggerState.Minimum;
                    else if (trigger == byte.MaxValue)
                        State = TriggerState.Maximum;
                }
            }
        }
        public class TickEventArgs : EventArgs
        {
            public TimeSpan ElapsedTime { get; private set; }
            public TickEventArgs(TimeSpan time)
            {
                ElapsedTime = time;
            }
        }
    }
}
