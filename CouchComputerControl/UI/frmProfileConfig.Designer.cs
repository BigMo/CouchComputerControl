namespace CouchComputerControl.UI
{
    partial class frmProfileConfig
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxProfileName = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.lstProfiles = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxProfileName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 320);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "New profile name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbxProfileName
            // 
            this.tbxProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbxProfileName.CustomButton.Image = null;
            this.tbxProfileName.CustomButton.Location = new System.Drawing.Point(283, 1);
            this.tbxProfileName.CustomButton.Name = "";
            this.tbxProfileName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxProfileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxProfileName.CustomButton.TabIndex = 1;
            this.tbxProfileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxProfileName.CustomButton.UseSelectable = true;
            this.tbxProfileName.CustomButton.Visible = false;
            this.tbxProfileName.Lines = new string[0];
            this.tbxProfileName.Location = new System.Drawing.Point(123, 3);
            this.tbxProfileName.MaxLength = 32767;
            this.tbxProfileName.Name = "tbxProfileName";
            this.tbxProfileName.PasswordChar = '\0';
            this.tbxProfileName.PromptText = "Enter a name for your new profile";
            this.tbxProfileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxProfileName.SelectedText = "";
            this.tbxProfileName.SelectionLength = 0;
            this.tbxProfileName.SelectionStart = 0;
            this.tbxProfileName.ShortcutsEnabled = true;
            this.tbxProfileName.Size = new System.Drawing.Size(305, 23);
            this.tbxProfileName.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbxProfileName.TabIndex = 1;
            this.tbxProfileName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxProfileName.UseSelectable = true;
            this.tbxProfileName.WaterMark = "Enter a name for your new profile";
            this.tbxProfileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxProfileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbxProfileName.TextChanged += new System.EventHandler(this.tbxProfileName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(434, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Create";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(123, 29);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(13, 19);
            this.lblError.Style = MetroFramework.MetroColorStyle.Red;
            this.lblError.TabIndex = 0;
            this.lblError.Text = " ";
            this.lblError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblError.UseCustomForeColor = true;
            // 
            // lstProfiles
            // 
            this.lstProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstProfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstProfiles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstProfiles.FullRowSelect = true;
            this.lstProfiles.Location = new System.Drawing.Point(20, 60);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.OwnerDraw = true;
            this.lstProfiles.Size = new System.Drawing.Size(512, 206);
            this.lstProfiles.Style = MetroFramework.MetroColorStyle.Orange;
            this.lstProfiles.TabIndex = 1;
            this.lstProfiles.UseCompatibleStateImageBehavior = false;
            this.lstProfiles.UseSelectable = true;
            this.lstProfiles.View = System.Windows.Forms.View.Details;
            this.lstProfiles.SelectedIndexChanged += new System.EventHandler(this.lstProfiles_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 381;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(20, 295);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(155, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Create new profile";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 266);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 29);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(397, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 23);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove selected";
            this.btnRemove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 367);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(512, 29);
            this.tableLayoutPanel3.TabIndex = 6;
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
            // frmProfileConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 416);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lstProfiles);
            this.MinimumSize = new System.Drawing.Size(552, 416);
            this.Name = "frmProfileConfig";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Profiles";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxProfileName;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel lblError;
        private MetroFramework.Controls.MetroListView lstProfiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}