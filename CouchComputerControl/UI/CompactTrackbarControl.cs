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
    public partial class CompactTrackbarControl : MetroUserControl
    {
        public float Minimum { get { return metroTrackBar1.Minimum / 100f; } set { metroTrackBar1.Minimum = (int)(value * 100); } }
        public float Maximum { get { return metroTrackBar1.Maximum / 100f; } set { metroTrackBar1.Maximum = (int)(value * 100); } }
        public float Steps { get { return metroTrackBar1.SmallChange / 100f; } set { metroTrackBar1.SmallChange = (int)(value * 100); } }
        public float Value { get { return metroTrackBar1.Value / 100f; } set { metroTrackBar1.Value = (int)(value * 100); } }
        public int Decimals { get; set; }

        public EventHandler OnValueChanged { get; set; }
        public string Suffix { get; set; }
        public string Prefix { get; set; }
        public float LabelWidth
        {
            get { return tableLayoutPanel1.ColumnStyles[1].Width; }
            set
            {
                tableLayoutPanel1.ColumnStyles[1].Width = value;
            }
        }

        public CompactTrackbarControl()
        {
            Decimals = 2;
            InitializeComponent();
            metroTrackBar1.ValueChanged += (o, e) => OnValueChanged?.Invoke(this, e);
            metroTrackBar1.ValueChanged += (o, e) => metroLabel1.Text = string.Format("{0}{1}{2}", Prefix, Math.Round(Value, Decimals), Suffix);
            metroLabel1.Text = string.Format("{0}{1}{2}", Prefix, Math.Round(Value, Decimals), Suffix);
        }
    }
}
