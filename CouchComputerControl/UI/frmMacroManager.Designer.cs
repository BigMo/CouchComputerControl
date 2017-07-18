namespace CouchComputerControl.UI
{
    partial class frmMacroManager
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lstMacros = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecStop = new MetroFramework.Controls.MetroButton();
            this.btnRecStart = new MetroFramework.Controls.MetroButton();
            this.cfgSingleKey = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecAdd = new MetroFramework.Controls.MetroButton();
            this.btnRecDiscard = new MetroFramework.Controls.MetroButton();
            this.cfgMacroName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lstMacroKeys = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(574, 463);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lstMacros);
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(566, 421);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Manage";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lstMacros
            // 
            this.lstMacros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMacros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMacros.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstMacros.FullRowSelect = true;
            this.lstMacros.Location = new System.Drawing.Point(0, 0);
            this.lstMacros.Name = "lstMacros";
            this.lstMacros.OwnerDraw = true;
            this.lstMacros.Size = new System.Drawing.Size(566, 392);
            this.lstMacros.Style = MetroFramework.MetroColorStyle.Orange;
            this.lstMacros.TabIndex = 3;
            this.lstMacros.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lstMacros.UseCompatibleStateImageBehavior = false;
            this.lstMacros.UseSelectable = true;
            this.lstMacros.View = System.Windows.Forms.View.Details;
            this.lstMacros.SelectedIndexChanged += new System.EventHandler(this.lstMacros_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Keys";
            this.columnHeader2.Width = 401;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 392);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(566, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(451, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 23);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove selected";
            this.btnRemove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tableLayoutPanel3);
            this.metroTabPage2.Controls.Add(this.lstMacroKeys);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(566, 421);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Create";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cfgSingleKey, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cfgMacroName, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 301);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(566, 120);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnRecStop, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRecStart, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(401, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(162, 26);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // btnRecStop
            // 
            this.btnRecStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecStop.Enabled = false;
            this.btnRecStop.Location = new System.Drawing.Point(84, 3);
            this.btnRecStop.Name = "btnRecStop";
            this.btnRecStop.Size = new System.Drawing.Size(75, 20);
            this.btnRecStop.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRecStop.TabIndex = 0;
            this.btnRecStop.Text = "Stop";
            this.btnRecStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRecStop.UseSelectable = true;
            this.btnRecStop.Click += new System.EventHandler(this.btnRecStop_Click);
            // 
            // btnRecStart
            // 
            this.btnRecStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecStart.Location = new System.Drawing.Point(3, 3);
            this.btnRecStart.Name = "btnRecStart";
            this.btnRecStart.Size = new System.Drawing.Size(75, 20);
            this.btnRecStart.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRecStart.TabIndex = 0;
            this.btnRecStart.Text = "Start";
            this.btnRecStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRecStart.UseSelectable = true;
            this.btnRecStart.Click += new System.EventHandler(this.btnRecStart_Click);
            // 
            // cfgSingleKey
            // 
            this.cfgSingleKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.cfgSingleKey, 2);
            // 
            // 
            // 
            this.cfgSingleKey.CustomButton.Image = null;
            this.cfgSingleKey.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.cfgSingleKey.CustomButton.Name = "";
            this.cfgSingleKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cfgSingleKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cfgSingleKey.CustomButton.TabIndex = 1;
            this.cfgSingleKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cfgSingleKey.CustomButton.UseSelectable = true;
            this.cfgSingleKey.CustomButton.Visible = false;
            this.cfgSingleKey.Enabled = false;
            this.cfgSingleKey.Lines = new string[0];
            this.cfgSingleKey.Location = new System.Drawing.Point(3, 35);
            this.cfgSingleKey.MaxLength = 32767;
            this.cfgSingleKey.Name = "cfgSingleKey";
            this.cfgSingleKey.PasswordChar = '\0';
            this.cfgSingleKey.PromptText = "Focus and press a button";
            this.cfgSingleKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cfgSingleKey.SelectedText = "";
            this.cfgSingleKey.SelectionLength = 0;
            this.cfgSingleKey.SelectionStart = 0;
            this.cfgSingleKey.ShortcutsEnabled = true;
            this.cfgSingleKey.Size = new System.Drawing.Size(560, 23);
            this.cfgSingleKey.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgSingleKey.TabIndex = 9;
            this.cfgSingleKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgSingleKey.UseSelectable = true;
            this.cfgSingleKey.WaterMark = "Focus and press a button";
            this.cfgSingleKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cfgSingleKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cfgSingleKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cfgSingleKey_KeyDown);
            this.cfgSingleKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cfgSingleKey_KeyUp);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnRecAdd, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnRecDiscard, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(401, 93);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(162, 26);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // btnRecAdd
            // 
            this.btnRecAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecAdd.Enabled = false;
            this.btnRecAdd.Location = new System.Drawing.Point(84, 3);
            this.btnRecAdd.Name = "btnRecAdd";
            this.btnRecAdd.Size = new System.Drawing.Size(75, 20);
            this.btnRecAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRecAdd.TabIndex = 0;
            this.btnRecAdd.Text = "Add macro";
            this.btnRecAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRecAdd.UseSelectable = true;
            this.btnRecAdd.Click += new System.EventHandler(this.btnRecAdd_Click);
            // 
            // btnRecDiscard
            // 
            this.btnRecDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecDiscard.Enabled = false;
            this.btnRecDiscard.Location = new System.Drawing.Point(3, 3);
            this.btnRecDiscard.Name = "btnRecDiscard";
            this.btnRecDiscard.Size = new System.Drawing.Size(75, 20);
            this.btnRecDiscard.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRecDiscard.TabIndex = 0;
            this.btnRecDiscard.Text = "Discard";
            this.btnRecDiscard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRecDiscard.UseSelectable = true;
            this.btnRecDiscard.Click += new System.EventHandler(this.btnRecDiscard_Click);
            // 
            // cfgMacroName
            // 
            this.cfgMacroName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cfgMacroName.CustomButton.Image = null;
            this.cfgMacroName.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.cfgMacroName.CustomButton.Name = "";
            this.cfgMacroName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cfgMacroName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cfgMacroName.CustomButton.TabIndex = 1;
            this.cfgMacroName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cfgMacroName.CustomButton.UseSelectable = true;
            this.cfgMacroName.CustomButton.Visible = false;
            this.cfgMacroName.Lines = new string[] {
        "SampleMacro1"};
            this.cfgMacroName.Location = new System.Drawing.Point(286, 64);
            this.cfgMacroName.MaxLength = 32767;
            this.cfgMacroName.Name = "cfgMacroName";
            this.cfgMacroName.PasswordChar = '\0';
            this.cfgMacroName.PromptText = "Enter a name for your macro";
            this.cfgMacroName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cfgMacroName.SelectedText = "";
            this.cfgMacroName.SelectionLength = 0;
            this.cfgMacroName.SelectionStart = 0;
            this.cfgMacroName.ShortcutsEnabled = true;
            this.cfgMacroName.Size = new System.Drawing.Size(277, 23);
            this.cfgMacroName.Style = MetroFramework.MetroColorStyle.Orange;
            this.cfgMacroName.TabIndex = 12;
            this.cfgMacroName.Text = "SampleMacro1";
            this.cfgMacroName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cfgMacroName.UseSelectable = true;
            this.cfgMacroName.WaterMark = "Enter a name for your macro";
            this.cfgMacroName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cfgMacroName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lstMacroKeys
            // 
            this.lstMacroKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstMacroKeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstMacroKeys.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstMacroKeys.FullRowSelect = true;
            this.lstMacroKeys.Location = new System.Drawing.Point(0, 0);
            this.lstMacroKeys.Name = "lstMacroKeys";
            this.lstMacroKeys.OwnerDraw = true;
            this.lstMacroKeys.Size = new System.Drawing.Size(566, 276);
            this.lstMacroKeys.Style = MetroFramework.MetroColorStyle.Orange;
            this.lstMacroKeys.TabIndex = 4;
            this.lstMacroKeys.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lstMacroKeys.UseCompatibleStateImageBehavior = false;
            this.lstMacroKeys.UseSelectable = true;
            this.lstMacroKeys.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time (ms)";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Key";
            this.columnHeader4.Width = 401;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 523);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 29);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseSelectable = true;
            // 
            // frmMacroManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 572);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMacroManager";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Macro-Management";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMacroManager_FormClosing);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroListView lstMacros;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroListView lstMacroKeys;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroButton btnRecStop;
        private MetroFramework.Controls.MetroButton btnRecStart;
        private MetroFramework.Controls.MetroTextBox cfgSingleKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MetroFramework.Controls.MetroButton btnRecAdd;
        private MetroFramework.Controls.MetroButton btnRecDiscard;
        private MetroFramework.Controls.MetroTextBox cfgMacroName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}