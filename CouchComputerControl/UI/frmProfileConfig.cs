using CouchComputerControl.Simulation.Configuration;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CouchComputerControl.UI
{
    public partial class frmProfileConfig : MetroForm
    {
        public frmProfileConfig()
        {
            InitializeComponent();
            this.Icon = CouchComputerControl.Properties.Resources.Logo02;
            ReloadProfiles();
            ValidateName();
        }

        private void ReloadProfiles()
        {
            lstProfiles.SuspendLayout();
            var items = lstProfiles.Items.Cast<ListViewItem>();
            foreach (var p in Program.Simulator.Profiles)
            {
                if (items.Count() == 0 || !items.Any(x=>x.Tag == p))
                {
                    var item = new ListViewItem(p.Name);
                    item.Tag = p;
                    lstProfiles.Items.Add(item);
                }
            }
            foreach (var i in items)
            {
                if (!Program.Simulator.Profiles.Any(x => i.Tag == x))
                    lstProfiles.Items.Remove(i);
            }
            lstProfiles.ResumeLayout();
        }

        private void ValidateName()
        {
            btnAdd.Enabled = false;
            if (tbxProfileName.Text.Length == 0)
                lblError.Text = "The profile name can not be empty";
            else if (Program.Simulator.Profiles.Any(x => x.Name == tbxProfileName.Text))
                lblError.Text = "This profile name is taken";
            else
            {
                lblError.Text = " ";
                btnAdd.Enabled = true;
            }
        }

        private void lstProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lstProfiles.SelectedItems.Count > 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var items = lstProfiles.SelectedItems.Cast<ListViewItem>();
            foreach (var item in items)
            {
                lstProfiles.Items.Remove(item);
                var cfg = (ProfileConfiguration)item.Tag;
                Program.Simulator.Profiles.Remove(cfg);
                if (Program.Simulator.ActiveProfile == cfg)
                    Program.Simulator.ActiveProfile = null;
            }
            ReloadProfiles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Program.Simulator.Profiles.Add(Simulation.Configuration.ProfileConfiguration.CreateProfile(tbxProfileName.Text));
            tbxProfileName.Text = "";
            ReloadProfiles();
        }

        private void tbxProfileName_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }
    }
}
