namespace CouchComputerControl.UI
{
    partial class TriggerControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Enabled = false;
            this.metroTrackBar1.Location = new System.Drawing.Point(3, 3);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(101, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTrackBar1.TabIndex = 1;
            this.metroTrackBar1.Text = "0";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.Value = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.Location = new System.Drawing.Point(3, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 64);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Trigger\r\nValue: -%\r\nState: -";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TriggerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTrackBar1);
            this.MinimumSize = new System.Drawing.Size(107, 97);
            this.Name = "TriggerControl";
            this.Size = new System.Drawing.Size(107, 97);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
