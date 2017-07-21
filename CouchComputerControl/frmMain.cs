using CouchComputerControl.Simulation.Configuration;
using CouchComputerControl.UI;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CouchComputerControl
{
    public partial class frmMain : MetroForm
    {
        //TODO: Add third parties! (incl https://freesound.org/people/acclivity/)
        private void PlaySound(Stream str)
        {
            using (var snd = new System.Media.SoundPlayer(str))
                snd.Play();
        }
        public frmMain()
        {
            InitializeComponent();
            this.Icon = CouchComputerControl.Properties.Resources.Logo02;
            cfgProfile.DropDownStyle = ComboBoxStyle.DropDownList;
            
            SmartController c = new SmartController();
            controllerControl1.Controller = c;
            Program.Simulator.Controller = c;
            BindProfile(Program.Simulator.ActiveProfile);
            Program.Simulator.ProfileChanged += (o, e) =>
            {
                UnbindProfile(e.Item1);
                BindProfile(e.Item2);
            };
            Program.Simulator.AddDefaultProfile();
            Program.Simulator.ArmedChanged += (o, e) => {
                this.InvokeSafe(() => UpdateArmedState());
                if (Program.Simulator.Armed)
                    PlaySound(Properties.Resources.beep_on);
                else
                    PlaySound(Properties.Resources.beep_off);
            };
            UpdateArmedState();
            cfgProfile.Items.AddRange(Program.Simulator.Profiles.ToArray());
            cfgProfile.SelectedItem = Program.Simulator.ActiveProfile;
        }

        private void UnbindProfile(ProfileConfiguration cfg)
        {
            cfg.RightTrigger.Unbind();
            cfg.LeftTrigger.Unbind();
            cfg.RightThumb.Unbind();
            cfg.LeftThumb.Unbind();
            cfg.UnbindCursorSpeed();
            cfgBtnA.Config = null;
            cfgBtnB.Config = null;
            cfgBtnX.Config = null;
            cfgBtnY.Config = null;
            cfgBtnBack.Config = null;
            cfgBtnStart.Config = null;
            cfgBtnRT.Config = null;
            cfgBtnLT.Config = null;
            cfgBtnRS.Config = null;
            cfgBtnLS.Config = null;
            cfgBtnDPUp.Config = null;
            cfgBtnDPDown.Config = null;
            cfgBtnDPLeft.Config = null;
            cfgBtnDPRight.Config = null;
        }
        private void BindProfile(ProfileConfiguration cfg)
        {
            if (cfg == null)
                return;

            cfg.RightTrigger.Trigger = Program.Simulator.Controller.RightTrigger;
            cfg.LeftTrigger.Trigger = Program.Simulator.Controller.LeftTrigger;
            cfg.RightThumb.Thumb = Program.Simulator.Controller.RightThumb;
            cfg.LeftThumb.Thumb = Program.Simulator.Controller.LeftThumb;

            cfg.RightTrigger.Bind(
                () => cfgTrgRightEnabled.Checked, (a) => cfgTrgRightEnabled.Checked = a,
                () => cfgTrgRightVal.Value, (a) => cfgTrgRightVal.Value = a
                );
            cfg.LeftTrigger.Bind(
                () => cfgTrgLeftEnabled.Checked, (a) => cfgTrgLeftEnabled.Checked = a,
                () => cfgTrgLeftVal.Value, (a) => cfgTrgLeftVal.Value = a
                );
            cfg.RightThumb.Bind(
                () => cfgDZRightX.Value, (a) => cfgDZRightX.Value = a,
                () => cfgDZRightY.Value, (a) => cfgDZRightY.Value = a
                );
            cfg.LeftThumb.Bind(
                () => cfgDZLeftX.Value, (a) => cfgDZLeftX.Value = a,
                () => cfgDZLeftY.Value, (a) => cfgDZLeftY.Value = a
                );
            cfg.BindCursorSpeed(
                () => cfgCursorSpeed.Value, (a) => cfgCursorSpeed.Value = a
                );
            cfgBtnA.Config = cfg.Buttons[(int)SmartController.GamepadButtons.A];
            cfgBtnB.Config = cfg.Buttons[(int)SmartController.GamepadButtons.B];
            cfgBtnX.Config = cfg.Buttons[(int)SmartController.GamepadButtons.X];
            cfgBtnY.Config = cfg.Buttons[(int)SmartController.GamepadButtons.Y];
            cfgBtnBack.Config = cfg.Buttons[(int)SmartController.GamepadButtons.Back];
            cfgBtnStart.Config = cfg.Buttons[(int)SmartController.GamepadButtons.Start];
            cfgBtnRT.Config = cfg.Buttons[(int)SmartController.GamepadButtons.RightThumb];
            cfgBtnLT.Config = cfg.Buttons[(int)SmartController.GamepadButtons.LeftThumb];
            cfgBtnRS.Config = cfg.Buttons[(int)SmartController.GamepadButtons.RightShoulder];
            cfgBtnLS.Config = cfg.Buttons[(int)SmartController.GamepadButtons.LeftShoulder];
            cfgBtnDPUp.Config = cfg.Buttons[(int)SmartController.GamepadButtons.DPadUp];
            cfgBtnDPDown.Config = cfg.Buttons[(int)SmartController.GamepadButtons.DPadDown];
            cfgBtnDPLeft.Config = cfg.Buttons[(int)SmartController.GamepadButtons.DPadLeft];
            cfgBtnDPRight.Config = cfg.Buttons[(int)SmartController.GamepadButtons.DPadRight];
        }

        private void UpdateArmedState()
        {
            if (Program.Simulator.Armed)
            {
                lblArmed.ForeColor = Color.Green;
                lblArmed.Text = "Armed";
            }
            else
            {
                lblArmed.ForeColor = Color.Red;
                lblArmed.Text = "Unarmed";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var frm = new UI.frmButtonConfig())
                frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SaveConfig();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            using (var frm = new UI.frmProfileConfig())
                frm.ShowDialog();
            Program.Simulator.AddDefaultProfile();
            cfgProfile.Items.Clear();
            cfgProfile.Items.AddRange(Program.Simulator.Profiles.ToArray());
            cfgProfile.SelectedItem = Program.Simulator.ActiveProfile;
        }

        private void cfgProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Simulator.ActiveProfile = (ProfileConfiguration)cfgProfile.SelectedItem;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            var asm = Assembly.GetExecutingAssembly().GetName();
            lblAsmName.Text = asm.Name;
            lblAsmVersion.Text = asm.Version.ToString();
        }
    }
}
