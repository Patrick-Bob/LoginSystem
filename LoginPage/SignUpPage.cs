using System;
using System.IO;
using System.Windows.Forms;

namespace LoginPage
{
	public partial class SignUpPage : Form
	{
		private string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\sign_up.txt";

		public SignUpPage()
		{
			InitializeComponent();
		}

		private void btn_signup_Click(object sender, EventArgs e)
		{
			string username = signup_username_tb.Text;
			string password = signup_password_tb.Text;

			using (StreamWriter stw = new StreamWriter(path, true))
			{
				stw.WriteLine(username + " " + password);
			}

			LoginPage loginPage = new LoginPage();
			loginPage.Show();
			Hide();
		}

        private void SignUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
