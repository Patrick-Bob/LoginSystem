namespace LoginPage
{
    partial class SignUpPage
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
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.signup_password_tb = new System.Windows.Forms.TextBox();
            this.signup_username_tb = new System.Windows.Forms.TextBox();
            this.lbl_user_signup = new System.Windows.Forms.Label();
            this.lbl_pwd_signup = new System.Windows.Forms.Label();
            this.signup_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_signup.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FloralWhite;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.Khaki;
            this.btn_signup.Location = new System.Drawing.Point(410, 321);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(193, 71);
            this.btn_signup.TabIndex = 9;
            this.btn_signup.Text = "Create account";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lbl_signup
            // 
            this.lbl_signup.AutoSize = true;
            this.lbl_signup.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.Location = new System.Drawing.Point(112, 46);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(135, 40);
            this.lbl_signup.TabIndex = 8;
            this.lbl_signup.Text = "Sign Up";
            // 
            // signup_password_tb
            // 
            this.signup_password_tb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password_tb.ForeColor = System.Drawing.Color.Black;
            this.signup_password_tb.Location = new System.Drawing.Point(339, 239);
            this.signup_password_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_password_tb.Name = "signup_password_tb";
            this.signup_password_tb.Size = new System.Drawing.Size(264, 33);
            this.signup_password_tb.TabIndex = 7;
            // 
            // signup_username_tb
            // 
            this.signup_username_tb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.signup_username_tb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username_tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_username_tb.Location = new System.Drawing.Point(339, 153);
            this.signup_username_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_username_tb.Name = "signup_username_tb";
            this.signup_username_tb.Size = new System.Drawing.Size(264, 33);
            this.signup_username_tb.TabIndex = 6;
            // 
            // lbl_user_signup
            // 
            this.lbl_user_signup.AutoSize = true;
            this.lbl_user_signup.BackColor = System.Drawing.Color.Black;
            this.lbl_user_signup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_signup.ForeColor = System.Drawing.Color.White;
            this.lbl_user_signup.Location = new System.Drawing.Point(124, 153);
            this.lbl_user_signup.Name = "lbl_user_signup";
            this.lbl_user_signup.Size = new System.Drawing.Size(178, 27);
            this.lbl_user_signup.TabIndex = 10;
            this.lbl_user_signup.Text = "Select username";
            // 
            // lbl_pwd_signup
            // 
            this.lbl_pwd_signup.AutoSize = true;
            this.lbl_pwd_signup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd_signup.ForeColor = System.Drawing.Color.White;
            this.lbl_pwd_signup.Location = new System.Drawing.Point(124, 245);
            this.lbl_pwd_signup.Name = "lbl_pwd_signup";
            this.lbl_pwd_signup.Size = new System.Drawing.Size(174, 27);
            this.lbl_pwd_signup.TabIndex = 11;
            this.lbl_pwd_signup.Text = "Select password";
            // 
            // signup_pnl
            // 
            this.signup_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.signup_pnl.BackColor = System.Drawing.Color.LightGreen;
            this.signup_pnl.Location = new System.Drawing.Point(3, 2);
            this.signup_pnl.Name = "signup_pnl";
            this.signup_pnl.Size = new System.Drawing.Size(115, 550);
            this.signup_pnl.TabIndex = 12;
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(639, 554);
            this.Controls.Add(this.signup_pnl);
            this.Controls.Add(this.lbl_pwd_signup);
            this.Controls.Add(this.lbl_user_signup);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_signup);
            this.Controls.Add(this.signup_password_tb);
            this.Controls.Add(this.signup_username_tb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUpPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btn_signup;
		private System.Windows.Forms.Label lbl_signup;
		private System.Windows.Forms.TextBox signup_password_tb;
		private System.Windows.Forms.TextBox signup_username_tb;
        private System.Windows.Forms.Label lbl_user_signup;
        private System.Windows.Forms.Label lbl_pwd_signup;
        private System.Windows.Forms.Panel signup_pnl;
    }
}