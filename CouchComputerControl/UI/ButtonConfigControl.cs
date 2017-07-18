using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using CouchComputerControl.Simulation.Configuration;

namespace CouchComputerControl.UI
{
    public partial class ButtonConfigControl : MetroUserControl
    {
        public ButtonConfiguration Config
        {
            get { return config; }
            set
            {
                if (config != value)
                {
                    config = value;
                    UpdateUI();
                }
            }
        }
        private ButtonConfiguration config;

        public ButtonConfigControl()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            metroLabel1.Text = config != null ? config.ToString() : "<no profile selected>";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (frmButtonConfig frm = new frmButtonConfig())
            {
                frm.Config = Config;
                frm.ShowDialog();
                UpdateUI();
            }
        }
    }
}
