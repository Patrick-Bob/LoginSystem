namespace LoginPage
{
	partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.btn_login = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.lbl_login_pwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(352, 258);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 60);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.username_tb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.username_tb.Location = new System.Drawing.Point(180, 93);
            this.username_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(235, 33);
            this.username_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.Color.Black;
            this.password_tb.Location = new System.Drawing.Point(180, 171);
            this.password_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(235, 33);
            this.password_tb.TabIndex = 2;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(21, 18);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(121, 40);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Sign In";
            // 
            // btn_signup
            // 
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(112, 220);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(171, 57);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "Sign Up Now";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(23, 96);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(115, 27);
            this.lbl_login_username.TabIndex = 5;
            this.lbl_login_username.Text = "Username";
            // 
            // lbl_login_pwd
            // 
            this.lbl_login_pwd.AutoSize = true;
            this.lbl_login_pwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_pwd.Location = new System.Drawing.Point(23, 171);
            this.lbl_login_pwd.Name = "lbl_login_pwd";
            this.lbl_login_pwd.Size = new System.Drawing.Size(108, 27);
            this.lbl_login_pwd.TabIndex = 6;
            this.lbl_login_pwd.Text = "Password";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(584, 437);
            this.Controls.Add(this.lbl_login_pwd);
            this.Controls.Add(this.lbl_login_username);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.TextBox username_tb;
		private System.Windows.Forms.TextBox password_tb;
		private System.Windows.Forms.Label lbl_login;
		private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_pwd;
    }
}

