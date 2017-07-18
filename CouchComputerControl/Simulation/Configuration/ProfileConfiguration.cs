using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CouchComputerControl.SmartController;

namespace CouchComputerControl.Simulation.Configuration
{
    public class ProfileConfiguration
    {
        public string Name { get; set; }

        public TriggerConfiguration LeftTrigger { get; private set; }
        public TriggerConfiguration RightTrigger { get; private set; }
        public ThumbConfiguration LeftThumb { get; private set; }
        public ThumbConfiguration RightThumb { get; private set; }
        public List<ButtonConfiguration> Buttons { get; private set; }
        public float BaseCursorSpeed
        {
            get { return baseCursorSpeed; }
            set { baseCursorSpeed.Value = value; }
        }

        private BindableProperty<float> baseCursorSpeed;

        private ProfileConfiguration()
        {
            baseCursorSpeed = new BindableProperty<float>();
            BaseCursorSpeed = 10;

            RightTrigger = new TriggerConfiguration();
            LeftTrigger = new TriggerConfiguration();
            RightThumb = new ThumbConfiguration();
            LeftThumb = new ThumbConfiguration();
            Buttons = new List<ButtonConfiguration>(); //vls.Select(x => new ButtonConfiguration() { GamepadButton = x }).ToList();
        }

        public static ProfileConfiguration CreateProfile(string name)
        {
            var cfg = new ProfileConfiguration();
            cfg.Name = name;
            var vls = (GamepadButtons[])Enum.GetValues(typeof(GamepadButtons));
            cfg.Buttons.AddRange(vls.Select(x=>new ButtonConfiguration() { GamepadButton = x }));
            return cfg;
        }

        public static ProfileConfiguration CreateDefaultProfile()
        {
            return CreateProfile("Default");
        }

        public void BindCursorSpeed(Func<float> fGet, Action<float> fSet)
        {
            baseCursorSpeed.Bind(fGet, fSet);
        }
        public void UnbindCursorSpeed()
        {
            baseCursorSpeed.Unbind();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
