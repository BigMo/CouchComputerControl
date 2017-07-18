namespace CouchComputerControl.UI
{
    partial class ThumbControl
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
            this.thumbX = new MetroFramework.Controls.MetroScrollBar();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.thumbY = new MetroFramework.Controls.MetroScrollBar();
            this.thumbY2 = new MetroFramework.Controls.MetroScrollBar();
            this.thumbX2 = new MetroFramework.Controls.MetroScrollBar();
            this.SuspendLayout();
            // 
            // thumbX
            // 
            this.thumbX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbX.Enabled = false;
            this.thumbX.LargeChange = 10;
            this.thumbX.Location = new System.Drawing.Point(19, 115);
            this.thumbX.Maximum = 100;
            this.thumbX.Minimum = 0;
            this.thumbX.MouseWheelBarPartitions = 10;
            this.thumbX.Name = "thumbX";
            this.thumbX.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.thumbX.ScrollbarSize = 10;
            this.thumbX.Size = new System.Drawing.Size(90, 10);
            this.thumbX.Style = MetroFramework.MetroColorStyle.Orange;
            this.thumbX.TabIndex = 9;
            this.thumbX.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.thumbX.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(19, 20);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(90, 89);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Thumb\r\nX: 0\r\nY: 0";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // thumbY
            // 
            this.thumbY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.thumbY.Enabled = false;
            this.thumbY.LargeChange = 10;
            this.thumbY.Location = new System.Drawing.Point(3, 20);
            this.thumbY.Maximum = 100;
            this.thumbY.Minimum = 0;
            this.thumbY.MouseWheelBarPartitions = 10;
            this.thumbY.Name = "thumbY";
            this.thumbY.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.thumbY.ScrollbarSize = 10;
            this.thumbY.Size = new System.Drawing.Size(10, 90);
            this.thumbY.Style = MetroFramework.MetroColorStyle.Orange;
            this.thumbY.TabIndex = 7;
            this.thumbY.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.thumbY.UseSelectable = true;
            // 
            // thumbY2
            // 
            this.thumbY2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbY2.Enabled = false;
            this.thumbY2.LargeChange = 10;
            this.thumbY2.Location = new System.Drawing.Point(115, 19);
            this.thumbY2.Maximum = 100;
            this.thumbY2.Minimum = 0;
            this.thumbY2.MouseWheelBarPartitions = 10;
            this.thumbY2.Name = "thumbY2";
            this.thumbY2.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.thumbY2.ScrollbarSize = 10;
            this.thumbY2.Size = new System.Drawing.Size(10, 90);
            this.thumbY2.Style = MetroFramework.MetroColorStyle.Orange;
            this.thumbY2.TabIndex = 7;
            this.thumbY2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.thumbY2.UseSelectable = true;
            // 
            // thumbX2
            // 
            this.thumbX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbX2.Enabled = false;
            this.thumbX2.LargeChange = 10;
            this.thumbX2.Location = new System.Drawing.Point(19, 4);
            this.thumbX2.Maximum = 100;
            this.thumbX2.Minimum = 0;
            this.thumbX2.MouseWheelBarPartitions = 10;
            this.thumbX2.Name = "thumbX2";
            this.thumbX2.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.thumbX2.ScrollbarSize = 10;
            this.thumbX2.Size = new System.Drawing.Size(90, 10);
            this.thumbX2.Style = MetroFramework.MetroColorStyle.Orange;
            this.thumbX2.TabIndex = 9;
            this.thumbX2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.thumbX2.UseSelectable = true;
            // 
            // ThumbControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.thumbX2);
            this.Controls.Add(this.thumbX);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.thumbY2);
            this.Controls.Add(this.thumbY);
            this.Name = "ThumbControl";
            this.Size = new System.Drawing.Size(128, 128);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroScrollBar thumbX;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroScrollBar thumbY;
        private MetroFramework.Controls.MetroScrollBar thumbY2;
        private MetroFramework.Controls.MetroScrollBar thumbX2;
    }
}
