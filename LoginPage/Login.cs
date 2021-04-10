using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LoginPage
{

	public partial class LoginPage : Form
	{
		private string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\sign_up.txt";

		public LoginPage()
		{
			InitializeComponent();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			User user = new User(username_tb.Text, password_tb.Text);

			if (IfUserSignUp(user))
			{
				MessageBox.Show("You successfully logged in!");
				InformationPage informationPage = new InformationPage(user);
				informationPage.Show();
                Hide();
            }
			else
			{
				MessageBox.Show("You don't have an account, please sign up!");
			}
		}

		private bool IfUserSignUp(User user)
		{
			List<string> information = File.ReadLines(path).ToList();

			foreach (string info in information)
			{
				string[] splitInfo = info.Split(' ');
				string savedname = splitInfo[0];
				string savedPassword = splitInfo[1];

				if (user.GetUsername() == savedname && user.GetPassword() == savedPassword)
				{
					return true;
				}
			}

			return false;
		}

		private void btn_signup_Click(object sender, EventArgs e)
		{
			SignUpPage signUpPage = new SignUpPage();
			signUpPage.Show();
			Hide();
		}

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
