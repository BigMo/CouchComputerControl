using CouchComputerControl.Simulation.Macro;
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
    public partial class frmMacroManager : MetroForm
    {
        private bool RecordingMacro
        {
            get { return recordingMacro; }
            set
            {
                if (recordingMacro != value)
                {
                    recordingMacro = value;
                    btnRecStop.Enabled = cfgSingleKey.Enabled = recordingMacro;
                    btnRecStart.Enabled = !recordingMacro;
                    RecordingDone = !recordingMacro;
                    if (recordingMacro)
                    {
                        lstMacroKeys.Items.Clear();
                        recordLast = Environment.TickCount;
                        cfgSingleKey.Focus();
                    }
                }
            }
        }
        private bool RecordingDone
        {
            get { return recordingDone; }
            set
            {
                if (recordingDone != value)
                {
                    recordingDone = value;
                    btnRecDiscard.Enabled = btnRecAdd.Enabled = recordingDone;
                    if (recordingDone)
                        RecordingMacro = false;
                    else
                        lstMacroKeys.Items.Clear();
                }
            }
        }
        bool recordingMacro, recordingDone;
        private long recordLast;

        public frmMacroManager()
        {
            InitializeComponent();
            this.Icon = CouchComputerControl.Properties.Resources.Logo02;
            foreach (var macro in Program.Macros)
                AddMacro(macro);
        }

        private void CreateMacroKey(Keys key, bool down)
        {
            var rec = new KeyMacroRecord((int)(Environment.TickCount - recordLast), key, down);
            recordLast = Environment.TickCount;
            var item = new ListViewItem();
            item.Text = rec.Wait.ToString();
            item.SubItems.Add(rec.ToString());
            item.Tag = rec;
            lstMacroKeys.Items.Insert(0, item);
        }

        private void AddMacro(KeyMacro macro)
        {
            ListViewItem item = new ListViewItem();
            item.Text = macro.Name;
            item.SubItems.Add(macro.GetRecordString());
            item.Tag = macro;
            lstMacros.Items.Add(item);
        }

        private void lstMacros_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lstMacros.SelectedItems.Count > 0;
        }

        private void btnRecStart_Click(object sender, EventArgs e)
        {
            RecordingMacro = true;
        }

        private void cfgSingleKey_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            CreateMacroKey(e.KeyCode, true);
        }

        private void cfgSingleKey_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            CreateMacroKey(e.KeyCode, false);
        }

        private void btnRecDiscard_Click(object sender, EventArgs e)
        {
            RecordingDone = false;
        }

        private void btnRecAdd_Click(object sender, EventArgs e)
        {
            var records = lstMacroKeys.Items.Cast<ListViewItem>().Reverse().Select(x => (KeyMacroRecord)x.Tag).ToArray();
            var macro = new KeyMacro(cfgMacroName.Text, records);
            Program.Macros.Add(macro);
            AddMacro(macro);

            RecordingDone = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var items = lstMacros.SelectedItems.Cast<ListViewItem>();
            foreach (var item in items)
            {
                lstMacros.Items.Remove(item);
                Program.Macros.Remove((KeyMacro)item.Tag);
            }
        }

        private void frmMacroManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SaveMacros();
        }

        private void btnRecStop_Click(object sender, EventArgs e)
        {
            RecordingMacro = false;
        }
    }
}
