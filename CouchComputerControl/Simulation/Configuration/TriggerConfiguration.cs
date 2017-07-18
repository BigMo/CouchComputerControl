using CouchComputerControl.UI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CouchComputerControl.Simulation.Configuration
{
    public class TriggerConfiguration
    {
        [JsonIgnore]
        public float Multiplier
        {
            get
            {
                if (Enabled && Trigger != null && Math.Abs(Trigger.Value) > float.Epsilon)
                    return Value * Trigger.Value;
                else
                    return 1.0f;
            }
        }

        [JsonIgnore]
        public SmartController.GamepadTrigger Trigger { get; set; }

        public float Value
        {
            get { return value; }
            set { this.value.Value = value; }
        }
        public bool Enabled
        {
            get { return enabled; }
            set { enabled.Value = value; }
        }

        private BindableProperty<bool> enabled;
        private BindableProperty<float> value;

        public TriggerConfiguration()
        {
            enabled = new BindableProperty<bool>();
            value = new BindableProperty<float>();

            enabled.Value = true;
            value.Value = 15.0f;
        }

        public void Bind(Func<bool> fEnabled, Action<bool> sEnabled, Func<float> fValue, Action<float> sValue)
        {
            enabled.Bind(fEnabled, sEnabled);
            value.Bind(fValue, sValue);
        }
        public void Unbind()
        {
            enabled.Unbind();
            value.Unbind();
        }
    }
}
