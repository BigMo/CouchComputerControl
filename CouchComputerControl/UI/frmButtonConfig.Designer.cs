namespace CouchComputerControl.UI
{
    partial class frmButtonConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cfgSingleKeyEnabled = new MetroFramework.Controls.MetroRadioButton();
            this.cfgSingleKey = new MetroFramework.Controls.MetroTextBox();
            this.cfgRepeatDelay = new CouchComputerControl.UI.CompactTrackbarControl();
            this.cfgSpecialKeyEnabled = new MetroFramework.Controls.MetroRadioButton();
            this.cfgSpecialKey = new MetroFramework.Controls.MetroComboBox();
            this.cfgMacroEnabled = new MetroFramework.Controls.MetroRadioButton();
            this.cfgRepeatEnabled = new MetroFramework.Controls.MetroCheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cfgMacro = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroButton2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 29);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton1.Location = new System.Drawing.Point(3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Close";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton2.Location = new System.Drawing.Point(604, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "Disable";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.cfgSingleKeyEnabled, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cfgSingleKey, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cfgRepeatDelay, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cfgSpecialKeyEnabled, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cfgSpecialKey, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cfgMacroEnabled, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cfgRepeatEnabled, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(682, 139);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // cfgSingleKeyEnabled
            // 
            this.cfgSingleKeyEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cfgSingleKeyEnabled.AutoSize = true;
            this.cfgSingleKeyEnabled.Checked = true;
            this.cfgSingleKeyEnabled.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cfgSingleKeyEnabled.Location = new System.Drawing.Point(3, 3);
            this.cfgSingleKeyEnabled.Name = "cfgSingleKeyEnabled";
            this.cfgSingleKeyEnabled.Size = new System.Drawing.Size(108, 25);
            this.cfgSingleKeyEnabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgSingleKeyEnabled.TabIndex = 7;
            this.cfgSingleKeyEnabled.TabStop = true;
            this.cfgSingleKeyEnabled.Text = "Single key";
            this.cfgSingleKeyEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgSingleKeyEnabled.UseSelectable = true;
            this.cfgSingleKeyEnabled.CheckedChanged += new System.EventHandler(this.cfgSingleKeyEnabled_CheckedChanged);
            // 
            // cfgSingleKey
            // 
            this.cfgSingleKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cfgSingleKey.CustomButton.Image = null;
            this.cfgSingleKey.CustomButton.Location = new System.Drawing.Point(533, 1);
            this.cfgSingleKey.CustomButton.Name = "";
            this.cfgSingleKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cfgSingleKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cfgSingleKey.CustomButton.TabIndex = 1;
            this.cfgSingleKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cfgSingleKey.CustomButton.UseSelectable = true;
            this.cfgSingleKey.CustomButton.Visible = false;
            this.cfgSingleKey.Lines = new string[0];
            this.cfgSingleKey.Location = new System.Drawing.Point(124, 4);
            this.cfgSingleKey.MaxLength = 32767;
            this.cfgSingleKey.Name = "cfgSingleKey";
            this.cfgSingleKey.PasswordChar = '\0';
            this.cfgSingleKey.PromptText = "Focus and press a button";
            this.cfgSingleKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cfgSingleKey.SelectedText = "";
            this.cfgSingleKey.SelectionLength = 0;
            this.cfgSingleKey.SelectionStart = 0;
            this.cfgSingleKey.ShortcutsEnabled = true;
            this.cfgSingleKey.Size = new System.Drawing.Size(555, 23);
            this.cfgSingleKey.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgSingleKey.TabIndex = 8;
            this.cfgSingleKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgSingleKey.UseSelectable = true;
            this.cfgSingleKey.WaterMark = "Focus and press a button";
            this.cfgSingleKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cfgSingleKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cfgSingleKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cfgSingleKey_KeyUp);
            // 
            // cfgRepeatDelay
            // 
            this.cfgRepeatDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgRepeatDelay.Decimals = 2;
            this.cfgRepeatDelay.LabelWidth = 51F;
            this.cfgRepeatDelay.Location = new System.Drawing.Point(124, 105);
            this.cfgRepeatDelay.Maximum = 10F;
            this.cfgRepeatDelay.Minimum = 0.1F;
            this.cfgRepeatDelay.Name = "cfgRepeatDelay";
            this.cfgRepeatDelay.OnValueChanged = null;
            this.cfgRepeatDelay.Prefix = null;
            this.cfgRepeatDelay.Size = new System.Drawing.Size(555, 31);
            this.cfgRepeatDelay.Steps = 0F;
            this.cfgRepeatDelay.Suffix = "s";
            this.cfgRepeatDelay.TabIndex = 12;
            this.cfgRepeatDelay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgRepeatDelay.UseSelectable = true;
            this.cfgRepeatDelay.Value = 0.5F;
            // 
            // cfgSpecialKeyEnabled
            // 
            this.cfgSpecialKeyEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cfgSpecialKeyEnabled.AutoSize = true;
            this.cfgSpecialKeyEnabled.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cfgSpecialKeyEnabled.Location = new System.Drawing.Point(3, 36);
            this.cfgSpecialKeyEnabled.Name = "cfgSpecialKeyEnabled";
            this.cfgSpecialKeyEnabled.Size = new System.Drawing.Size(115, 25);
            this.cfgSpecialKeyEnabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgSpecialKeyEnabled.TabIndex = 7;
            this.cfgSpecialKeyEnabled.Text = "Special key";
            this.cfgSpecialKeyEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgSpecialKeyEnabled.UseSelectable = true;
            this.cfgSpecialKeyEnabled.CheckedChanged += new System.EventHandler(this.cfgSpecialKeyEnabled_CheckedChanged);
            // 
            // cfgSpecialKey
            // 
            this.cfgSpecialKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgSpecialKey.FormattingEnabled = true;
            this.cfgSpecialKey.ItemHeight = 23;
            this.cfgSpecialKey.Location = new System.Drawing.Point(124, 34);
            this.cfgSpecialKey.Name = "cfgSpecialKey";
            this.cfgSpecialKey.Size = new System.Drawing.Size(555, 29);
            this.cfgSpecialKey.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgSpecialKey.TabIndex = 9;
            this.cfgSpecialKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgSpecialKey.UseSelectable = true;
            // 
            // cfgMacroEnabled
            // 
            this.cfgMacroEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cfgMacroEnabled.AutoSize = true;
            this.cfgMacroEnabled.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cfgMacroEnabled.Location = new System.Drawing.Point(3, 71);
            this.cfgMacroEnabled.Name = "cfgMacroEnabled";
            this.cfgMacroEnabled.Size = new System.Drawing.Size(78, 25);
            this.cfgMacroEnabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgMacroEnabled.TabIndex = 7;
            this.cfgMacroEnabled.Text = "Macro";
            this.cfgMacroEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgMacroEnabled.UseSelectable = true;
            this.cfgMacroEnabled.CheckedChanged += new System.EventHandler(this.cfgMacroEnabled_CheckedChanged);
            // 
            // cfgRepeatEnabled
            // 
            this.cfgRepeatEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cfgRepeatEnabled.AutoSize = true;
            this.cfgRepeatEnabled.Location = new System.Drawing.Point(59, 113);
            this.cfgRepeatEnabled.Name = "cfgRepeatEnabled";
            this.cfgRepeatEnabled.Size = new System.Drawing.Size(59, 15);
            this.cfgRepeatEnabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgRepeatEnabled.TabIndex = 13;
            this.cfgRepeatEnabled.Text = "Repeat";
            this.cfgRepeatEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgRepeatEnabled.UseSelectable = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.cfgMacro, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroButton3, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(121, 66);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 36);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // cfgMacro
            // 
            this.cfgMacro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgMacro.FormattingEnabled = true;
            this.cfgMacro.ItemHeight = 23;
            this.cfgMacro.Location = new System.Drawing.Point(3, 3);
            this.cfgMacro.Name = "cfgMacro";
            this.cfgMacro.Size = new System.Drawing.Size(474, 29);
            this.cfgMacro.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgMacro.TabIndex = 9;
            this.cfgMacro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgMacro.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(483, 6);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Manage";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // frmButtonConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(722, 251);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmButtonConfig";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Button-Configuration";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroRadioButton cfgSingleKeyEnabled;
        private MetroFramework.Controls.MetroTextBox cfgSingleKey;
        private MetroFramework.Controls.MetroRadioButton cfgSpecialKeyEnabled;
        private MetroFramework.Controls.MetroComboBox cfgSpecialKey;
        private MetroFramework.Controls.MetroRadioButton cfgMacroEnabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroComboBox cfgMacro;
        private MetroFramework.Controls.MetroButton metroButton3;
        private CompactTrackbarControl cfgRepeatDelay;
        private MetroFramework.Controls.MetroCheckBox cfgRepeatEnabled;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}