using CouchComputerControl.Simulation.Macro;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CouchComputerControl.Simulation.Configuration
{
    public class ButtonConfiguration
    {
        public enum eMode { Disabled, SingleKey, Macro };

        [JsonConverter(typeof(StringEnumConverter))]
        public SmartController.GamepadButtons GamepadButton { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public eMode Mode
        {
            get { return mode; }
            set { mode.Value = value; }
        }
        [JsonConverter(typeof(StringEnumConverter))]
        public Keys Key
        {
            get { return key; }
            set { key.Value = value; }
        }
        public KeyMacro Macro
        {
            get { return macro; }
            set { macro.Value = value; }
        }
        public bool RepeatEnabled
        {
            get { return repeatEnabled; }
            set { repeatEnabled.Value = value; }
        }
        public float RepeatDelay
        {
            get { return repeatDelay; }
            set { repeatDelay.Value = value; }
        }

        private BindableProperty<eMode> mode;
        private BindableProperty<Keys> key;
        private BindableProperty<KeyMacro> macro;
        private BindableProperty<float> repeatDelay;
        private BindableProperty<bool> repeatEnabled;

        //public ButtonConfiguration(SmartController.GamepadButtons button) : this()
        //{
        //    GamepadButton = button;
        //}
        public ButtonConfiguration()
        {
            GamepadButton = SmartController.GamepadButtons.A;
            mode = new BindableProperty<eMode>();
            key = new BindableProperty<Keys>();
            macro = new BindableProperty<KeyMacro>();
            repeatEnabled = new BindableProperty<bool>();
            repeatDelay = new BindableProperty<float>();

            repeatDelay.Value = 0.1f;
        }

        public void Bind(Func<eMode> fMode, Action<eMode> sMode, Func<Keys> fKey, Action<Keys> sKey, Func<KeyMacro> fMacro, Action<KeyMacro> sMacro)
        {
            mode.Bind(fMode, sMode);
            key.Bind(fKey, sKey);
            macro.Bind(fMacro, sMacro);
        }
        public void Unbind()
        {
            mode.Unbind();
            key.Unbind();
            macro.Unbind();
        }

        public override string ToString()
        {
            if (Mode != eMode.Disabled)
                if (RepeatEnabled)
                    return string.Format("{0} (repeating {1}s)", Mode == eMode.SingleKey ? Key.ToString() : Macro.ToString(), Math.Round(RepeatDelay, 2));
                else
                    return string.Format("{0}", Mode == eMode.SingleKey ? Key.ToString() : Macro.ToString());
            else
                return "<disabled>";
        }
    }
}
