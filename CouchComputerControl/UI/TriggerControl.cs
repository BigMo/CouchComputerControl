using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace CouchComputerControl.UI
{
    public partial class TriggerControl : MetroUserControl
    {
        public SmartController.GamepadTrigger Trigger
        {
            get { return trigger; }
            set
            {
                if (value != trigger)
                {
                    if (trigger != null)
                    {
                        trigger.Changed -= OnTriggerChanged;
                        trigger.StateChanged -= OnTriggerChanged;
                    }
                    trigger = value;
                    if (trigger != null)
                    {
                        trigger.Changed += OnTriggerChanged;
                        trigger.StateChanged += OnTriggerChanged;
                        OnTriggerChanged(trigger, new EventArgs());
                    }
                }
            }
        }

        private SmartController.GamepadTrigger trigger;

        public TriggerControl()
        {
            InitializeComponent();
        }

        private void OnTriggerChanged(object sender, EventArgs e)
        {
            this.InvokeSafe(() => UpdateUI());
        }

        private void UpdateUI()
        {
            metroLabel1.Text = string.Format("Trigger:\nValue: {0}%\nState: {1}", Trigger != null ? ((int)(Trigger.Value * 100)).ToString() : "-", Trigger != null ? Trigger.State.ToString() : "-");
            metroTrackBar1.Value = Trigger != null ? (int)(metroTrackBar1.Maximum * Trigger.Value) : 0;
        }
    }
}
