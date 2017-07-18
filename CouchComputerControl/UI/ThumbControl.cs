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
    public partial class ThumbControl : MetroUserControl
    {
        public string ThumbName
        {
            get { return thumbName; }
            set
            {
                if (value != thumbName)
                {
                    thumbName = value;
                    ChangeText();
                }
            }
        }
        public SmartController.GamepadThumb Thumb
        {
            get { return thumb; }
            set
            {
                if (value != thumb)
                {
                    if (thumb != null)
                    {
                        thumb.XChanged -= OnThumbValuesChanged;
                        thumb.YChanged -= OnThumbValuesChanged;
                    }

                    thumb = value;
                    if (thumb != null)
                    {
                        thumb.XChanged += OnThumbValuesChanged;
                        thumb.YChanged += OnThumbValuesChanged;
                        OnThumbValuesChanged(thumb, new EventArgs());
                    }
                }
            }
        }
        public bool InvertMirroredAxis {
            get { return invertMirroredAxis; }
            set
            {
                if(value != invertMirroredAxis)
                {
                    invertMirroredAxis = value;
                    UpdateUI();
                }
            }
        }

        private SmartController.GamepadThumb thumb;
        private string thumbName;
        private bool invertMirroredAxis;

        public ThumbControl()
        {
            InitializeComponent();
            thumbName = "Thumb";
            InvertMirroredAxis = false;
        }

        private void OnThumbValuesChanged(object sender, EventArgs e)
        {
            this.InvokeSafe(() => UpdateUI());
        }

        private void UpdateUI()
        {
            thumbY.Value = thumbY.Maximum - (int)(thumbY.Maximum / 2f + (thumbY.Maximum / 2f) * Thumb.Y);
            thumbY2.Value = invertMirroredAxis ? thumbY.Maximum - thumbY.Value : thumbY.Value;
            thumbX.Value = (int)(thumbX.Maximum / 2f + (thumbX.Maximum / 2f) * Thumb.X);
            thumbX2.Value = invertMirroredAxis ? thumbX.Maximum - thumbX.Value : thumbX.Value;
            ChangeText();
        }
        private void ChangeText()
        {
            metroTile1.Text = string.Format("{0}\nX: {1}%\nY: {2}%", ThumbName, Thumb != null ? ((int)(Thumb.X*100)).ToString() : "-", Thumb != null ? ((int)(Thumb.Y * 100)).ToString() : "-");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            InvertMirroredAxis = !InvertMirroredAxis;
        }
    }
}
