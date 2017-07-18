using CouchComputerControl.Simulation.Macro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CouchComputerControl.Simulation
{
    public class OutputProcessor
    {
        public bool IsBusy { get { return thread != null && thread.ThreadState == ThreadState.Running; } }
        public TimeSpan LastPlayed { get { return TimeSpan.FromMilliseconds(Environment.TickCount - lastPlayed); } }

        private Thread thread;
        private WindowsInput.InputSimulator sim;
        private long lastPlayed;

        public OutputProcessor()
        {
            sim = new WindowsInput.InputSimulator();
            lastPlayed = Environment.TickCount;
        }

        private void play(KeyMacro macro)
        {
            foreach (var rec in macro.Records)
            {
                if (rec.Wait > 0)
                    Thread.Sleep(rec.Wait);
                switch (rec.Key)
                {
                    case Keys.LButton:
                        if (rec.Down)
                            sim.Mouse.LeftButtonDown();
                        else
                            sim.Mouse.LeftButtonUp();
                        break;
                    case Keys.RButton:
                        if (rec.Down)
                            sim.Mouse.RightButtonDown();
                        else
                            sim.Mouse.RightButtonUp();
                        break;
                    case Keys.MButton:
                        break;
                    case Keys.XButton1:
                        if (rec.Down)
                            sim.Mouse.XButtonDown(1);
                        else
                            sim.Mouse.XButtonUp(1);
                        break;
                    case Keys.XButton2:
                        if (rec.Down)
                            sim.Mouse.XButtonDown(2);
                        else
                            sim.Mouse.XButtonUp(2);
                        break;
                    default:
                        if (rec.Down)
                            sim.Keyboard.KeyDown((WindowsInput.Native.VirtualKeyCode)rec.Key);
                        else
                            sim.Keyboard.KeyUp((WindowsInput.Native.VirtualKeyCode)rec.Key);
                        break;
                }
            }
            lastPlayed = Environment.TickCount;
        }

        public void PlayMacro(KeyMacro macro)
        {
            thread = new Thread(() => play(macro));
            thread.Start();
        }

        public void PlayKey(Keys key, int duration, bool down)
        {
            PlayMacro(new KeyMacro("Anonymous macro",
                new KeyMacroRecord[]
                {
                    new KeyMacroRecord(0, key, down)
                }));
        }
    }
}
