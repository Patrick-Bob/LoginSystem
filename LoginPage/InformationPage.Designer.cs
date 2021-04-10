namespace LoginPage
{
    partial class InformationPage
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
            this.tbx_info = new System.Windows.Forms.TextBox();
            this.top_panel = new System.Windows.Forms.Panel();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbx_info
            // 
            this.tbx_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_info.BackColor = System.Drawing.Color.MistyRose;
            this.tbx_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_info.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_info.ForeColor = System.Drawing.Color.Black;
            this.tbx_info.Location = new System.Drawing.Point(1, 56);
            this.tbx_info.Multiline = true;
            this.tbx_info.Name = "tbx_info";
            this.tbx_info.ReadOnly = true;
            this.tbx_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_info.Size = new System.Drawing.Size(1138, 502);
            this.tbx_info.TabIndex = 0;
            this.tbx_info.TextChanged += new System.EventHandler(this.tbx_info_TextChanged);
            // 
            // top_panel
            // 
            this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top_panel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.top_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.top_panel.Location = new System.Drawing.Point(1, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1138, 50);
            this.top_panel.TabIndex = 1;
            // 
            // bottom_panel
            // 
            this.bottom_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottom_panel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bottom_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottom_panel.ForeColor = System.Drawing.Color.SandyBrown;
            this.bottom_panel.Location = new System.Drawing.Point(1, 564);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1138, 47);
            this.bottom_panel.TabIndex = 2;
            // 
            // InformationPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1141, 610);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.tbx_info);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InformationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InformationPage_FormClosed);
            this.Load += new System.EventHandler(this.InformationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_info;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel bottom_panel;
    }
}