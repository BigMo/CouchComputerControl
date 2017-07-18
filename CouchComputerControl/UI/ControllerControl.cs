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
    public partial class ControllerControl : MetroUserControl
    {
        public SmartController Controller
        {
            get { return controller; }
            set
            {
                if (value != controller)
                {
                    controller = value;
                    thumbControl1.Thumb = controller != null ? controller.LeftThumb : null;
                    thumbControl2.Thumb = controller != null ? controller.RightThumb : null;
                    triggerControl1.Trigger = controller != null ? controller.LeftTrigger : null;
                    triggerControl2.Trigger = controller != null ? controller.RightTrigger : null;
                    btnD1.Button = controller != null ? controller.ButtonDPadUp : null;
                    btnD2.Button = controller != null ? controller.ButtonDPadLeft : null;
                    btnD3.Button = controller != null ? controller.ButtonDPadRight : null;
                    btnD4.Button = controller != null ? controller.ButtonDPadDown : null;
                    btnR1.Button = controller != null ? controller.ButtonY : null;
                    btnR2.Button = controller != null ? controller.ButtonX : null;
                    btnR3.Button = controller != null ? controller.ButtonB : null;
                    btnR4.Button = controller != null ? controller.ButtonA : null;
                    btnR.Button = controller != null ? controller.ButtonRightThumb : null;
                    btnL.Button = controller != null ? controller.ButtonLeftThumb : null;
                    btnRB.Button = controller != null ? controller.ButtonRightShoulder : null;
                    btnLB.Button = controller != null ? controller.ButtonLeftShoulder : null;
                    btnStart.Button = controller != null ? controller.ButtonStart : null;
                    btnBack.Button = controller != null ? controller.ButtonBack : null;
                }
            }
        }
        private SmartController controller;

        public ControllerControl()
        {
            InitializeComponent();
        }
    }
}
