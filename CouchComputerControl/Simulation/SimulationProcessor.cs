using CouchComputerControl.Simulation;
using CouchComputerControl.Simulation.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CouchComputerControl.SmartController;

namespace CouchComputerControl.Simulation
{
    public class SimulationProcessor
    {
        [JsonIgnore]
        public SmartController Controller
        {
            get { return controller; }
            set
            {
                if (controller != null)
                {
                    controller.OnUpdateDone -= AfterUpdate;
                    ActiveProfile.RightTrigger.Trigger = null;
                    ActiveProfile.LeftTrigger.Trigger = null;
                    ActiveProfile.RightThumb.Thumb = null;
                    ActiveProfile.LeftThumb.Thumb = null;
                    foreach (var btn in controller.Buttons)
                    {
                        btn.WentDown -= ButtonEvent;
                        btn.WentUp += ButtonEvent;
                        btn.ContinuedDown -= ButtonDownRepeat;
                    }
                }
                controller = value;
                if (controller != null)
                {
                    AddDefaultProfile();
                    CursorPositon = (Vector2)(Cursor.Position);
                    controller.OnUpdateDone += AfterUpdate;
                    ActiveProfile.RightTrigger.Trigger = controller.RightTrigger;
                    ActiveProfile.LeftTrigger.Trigger = controller.LeftTrigger;
                    ActiveProfile.RightThumb.Thumb = controller.RightThumb;
                    ActiveProfile.LeftThumb.Thumb = controller.LeftThumb;
                    foreach (var btn in controller.Buttons)
                    {
                        btn.WentDown += ButtonEvent;
                        btn.WentUp += ButtonEvent;
                        btn.ContinuedDown += ButtonDownRepeat;
                    }
                }
            }
        }
        public List<ProfileConfiguration> Profiles { get; set; }
        [JsonIgnore]
        public ProfileConfiguration ActiveProfile
        {
            get { return activeProfile; }
            set
            {
                if (activeProfile != value)
                {
                    var old = activeProfile;
                    activeProfile = value;
                    if (activeProfile == null)
                    {
                        if (Profiles.Count > 0)
                        {
                            activeProfile = Profiles[0];
                        } else
                        {
                            activeProfile = ProfileConfiguration.CreateDefaultProfile();
                            Profiles.Add(activeProfile);
                        }
                    }
                    ProfileChanged?.Invoke(this, new BiGenericEventArgs<ProfileConfiguration>(old, activeProfile));
                }
            }
        }
        public string ActiveProfileName
        {
            get { return ActiveProfile.Name; }
            set
            {
                if (Profiles.Any(x=>x.Name == value))
                    ActiveProfile = Profiles.First(x => x.Name == value);
            }
        }
        [JsonIgnore]
        public EventHandler<BiGenericEventArgs<ProfileConfiguration>> ProfileChanged { get; set; }
        [JsonIgnore]
        public Vector2 CursorPositon { get; private set; }
        public bool Armed {
            get { return armed; }
            set
            {
                if(armed != value)
                {
                    armed = value;
                    ArmedChanged?.Invoke(this, new EventArgs());
                }
            }
        }
        [JsonIgnore]
        public EventHandler ArmedChanged { get; set; }
        private OutputProcessor[] outputProcessors;
        private ProfileConfiguration activeProfile;
        private bool wasArmed, armed;

        public SimulationProcessor()
        {
            outputProcessors = new OutputProcessor[((GamepadButtons[])Enum.GetValues(typeof(GamepadButtons))).Length];
            for (int i = 0; i < outputProcessors.Length; i++)
                outputProcessors[i] = new OutputProcessor();

            Profiles = new List<ProfileConfiguration>();
            Armed = true;
        }

        private SmartController controller;

        private void ButtonEvent(object sender, EventArgs e)
        {
            var btn = (SmartController.GamepadButton)sender;
            var cfg = ActiveProfile.Buttons[(int)btn.Button];
            var pro = outputProcessors[(int)btn.Button];

            if (!Armed || cfg.Mode == ButtonConfiguration.eMode.Disabled || pro.IsBusy)
                return;

            PlayButtonConfig(cfg, pro, btn.IsDown);
        }

        private void ButtonDownRepeat(object sender, EventArgs e)
        {
            var btn = (SmartController.GamepadButton)sender;
            var cfg = ActiveProfile.Buttons[(int)btn.Button];
            var pro = outputProcessors[(int)btn.Button];

            if (!wasArmed)
            {
                if (Controller.ButtonBack.PressDuration.TotalSeconds >= 3.0 && Controller.ButtonStart.PressDuration.TotalSeconds >= 3.0)
                {
                    Armed = !Armed;
                    wasArmed = true;
                }
            }

            if (!Armed || cfg.Mode == ButtonConfiguration.eMode.Disabled || !cfg.RepeatEnabled || pro.IsBusy || pro.LastPlayed.TotalSeconds < cfg.RepeatDelay)
                return;
            
            PlayButtonConfig(cfg, pro, btn.IsDown);
        }

        private void PlayButtonConfig(ButtonConfiguration cfg, OutputProcessor pro, bool down)
        {
            if (cfg.Mode == ButtonConfiguration.eMode.SingleKey)
                pro.PlayKey(cfg.Key, 10, down);
            else if (down)
                pro.PlayMacro(cfg.Macro);
        }

        private void AfterUpdate(object sender, SmartController.TickEventArgs e)
        {
            if (wasArmed)
            {

                if (!Controller.ButtonStart.IsDown && !Controller.ButtonBack.IsDown)
                    wasArmed = false;
            }
            if (!Armed)
                return;
            var vec = Controller.RightThumb.Vector;
            if (vec.Length > 0.1)
            {
                vec *= ActiveProfile.BaseCursorSpeed;
                if (ActiveProfile.RightTrigger.Enabled || ActiveProfile.LeftTrigger.Enabled)
                {
                    var multi = 0.0f;
                    if (ActiveProfile.RightTrigger.Enabled)
                        multi += ActiveProfile.RightTrigger.Multiplier;
                    if (ActiveProfile.LeftTrigger.Enabled)
                        multi += ActiveProfile.LeftTrigger.Multiplier;
                    vec *= multi;
                }

                vec = (vec * new Vector2(1, -1)) * (float)e.ElapsedTime.TotalSeconds;
                CursorPositon += vec;
                Cursor.Position = (System.Drawing.Point)CursorPositon;
                if (((Vector2)Cursor.Position - CursorPositon).Length > 10f)
                    CursorPositon = (Vector2)Cursor.Position;
            }
        }

        public void AddDefaultProfile()
        {
            if (Profiles.Count > 0)
                return;
            if (activeProfile != null)
                Profiles.Add(activeProfile);
            else
            {
                ActiveProfile = ProfileConfiguration.CreateDefaultProfile();
                Profiles.Add(ActiveProfile);
            }
        }

        public void BindCursorSpeed(Func<float> fGet, Action<float> fSet)
        {
            ActiveProfile.BindCursorSpeed(fGet, fSet);
        }
        public void UnbindCursorSpeed()
        {
            ActiveProfile.UnbindCursorSpeed();
        }
    }
}
