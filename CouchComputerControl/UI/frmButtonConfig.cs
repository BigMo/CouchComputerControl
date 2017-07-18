using CouchComputerControl.Simulation.Configuration;
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
    public partial class frmButtonConfig : MetroForm
    {
        internal struct SpecialKey_t
        {
            public string Name;
            public Keys Key;
            public SpecialKey_t(string name, Keys key)
            {
                Name = name;
                Key = key;
            }
            public override string ToString()
            {
                return string.Format("{0} ({1})", Name, Key);
            }
        }
        private static SpecialKey_t[] SPECIAL_KEYS = new SpecialKey_t[]
        {
            new SpecialKey_t("Left mousebutton", Keys.LButton),
            new SpecialKey_t("Right mousebutton", Keys.RButton),
            new SpecialKey_t("Middle mousebutton", Keys.MButton),
            new SpecialKey_t("Fourth mousebutton", Keys.XButton1),
            new SpecialKey_t("Fifth mousebutton", Keys.XButton2),
            new SpecialKey_t("Tab", Keys.Tab),
            new SpecialKey_t("Play/Pause", Keys.MediaPlayPause),
            new SpecialKey_t("Stop", Keys.MediaStop),
            new SpecialKey_t("Next", Keys.MediaNextTrack),
            new SpecialKey_t("Previous", Keys.MediaPreviousTrack),
            new SpecialKey_t("Volume up", Keys.VolumeUp),
            new SpecialKey_t("Volume down", Keys.VolumeDown),
            new SpecialKey_t("Volume mute", Keys.VolumeMute)
        };

        public ButtonConfiguration Config
        {
            get { return config; }
            set
            {
                if (config != value)
                {
                    config = value;
                    cfgRepeatEnabled.Checked = config.RepeatEnabled;
                    cfgRepeatDelay.Value = config.RepeatDelay;
                    if (config.Macro != null)
                    {
                        cfgMacroEnabled.Checked = true;
                        cfgMacro.SelectedItem = config.Macro;
                    } else
                    {
                        if (SPECIAL_KEYS.Any(x => x.Key == config.Key)) {
                            cfgSpecialKeyEnabled.Checked = true;
                            cfgSpecialKey.SelectedItem = SPECIAL_KEYS.First(x => x.Key == config.Key);
                        } else
                        {
                            cfgSingleKeyEnabled.Checked = true;
                            cfgSingleKey.Text = config.Key.ToString();
                        }
                    }
                }
            }
        }
        private ButtonConfiguration config;

        public frmButtonConfig()
        {
            InitializeComponent();
            this.Icon = CouchComputerControl.Properties.Resources.Logo02;

            cfgSpecialKey.DataSource = SPECIAL_KEYS;
            cfgSpecialKey.DropDownStyle = ComboBoxStyle.DropDownList;
            cfgSpecialKey.SelectedIndexChanged += (o, e) =>
            {
                config.Mode = ButtonConfiguration.eMode.SingleKey;
                config.Key = ((SpecialKey_t)cfgSpecialKey.SelectedItem).Key;
            };
            cfgSpecialKey.SelectedIndex = 0;
            cfgSingleKey.GotFocus += (o, e) => cfgSingleKey.Text = "";

            cfgMacro.DataSource = Program.Macros.ToArray();
            cfgMacro.DropDownStyle = ComboBoxStyle.DropDownList;
            cfgMacro.SelectedIndexChanged += (o, e) =>
            {
                config.Mode = ButtonConfiguration.eMode.Macro;
                config.Macro = (KeyMacro)cfgMacro.SelectedItem;
            };
            if (cfgMacro.Items.Count > 0)
                cfgMacro.SelectedIndex = 0;

            cfgRepeatEnabled.CheckedChanged += (o, e) => config.RepeatEnabled = cfgRepeatEnabled.Checked;
            cfgRepeatDelay.OnValueChanged += (o, e) => config.RepeatDelay= cfgRepeatDelay.Value;
        }

        private void cfgSingleKey_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            cfgSingleKey.Text = e.KeyCode.ToString();
            config.Key = e.KeyCode;
            config.Mode = ButtonConfiguration.eMode.SingleKey;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            using (frmMacroManager m = new frmMacroManager())
                m.ShowDialog();
            cfgMacro.DataSource = Program.Macros.ToArray();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            config.Mode = ButtonConfiguration.eMode.Disabled;
        }
    }
}
