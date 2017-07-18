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
    public partial class ButtonControl : MetroUserControl
    {
        public SmartController.GamepadButton Button
        {
            get { return button; }
            set
            {
                if (value != button)
                {
                    if (button != null)
                    {
                        button.WentDown -= OnButtonEvent;
                        button.ContinuedDown -= OnButtonEvent;
                        button.WentUp -= OnButtonEvent;
                    }
                    button = value;
                    if (button != null)
                    {
                        button.WentDown += OnButtonEvent;
                        button.ContinuedDown += OnButtonEvent;
                        button.WentUp += OnButtonEvent;
                        UpdateUI();
                    }
                }
            }
        }

        private SmartController.GamepadButton button;

        public ButtonControl()
        {
            InitializeComponent();
        }

        private void OnButtonEvent(object o, EventArgs e)
        {
            this.InvokeSafe(()=>UpdateUI());
        }

        private void UpdateUI()
        {
            this.metroCheckBox1.Checked = button != null ? button.IsDown : false;
            if (this.metroCheckBox1.Checked)
                this.metroCheckBox1.Text = string.Format("{0} ({1}s)",
                    button.Button.ToString(), Math.Round(button.PressDuration.TotalSeconds,1).ToString());
            else
                this.metroCheckBox1.Text = button != null ? button.Button.ToString() : "-";


        }
    }
}
