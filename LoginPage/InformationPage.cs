using System.IO;
using System.Windows.Forms;
using System;

namespace LoginPage
{
	public partial class InformationPage : Form
	{
		public InformationPage(User user)
		{
			InitializeComponent();

            string path = Path.GetDirectoryName(Application.ExecutablePath)+@"\user_information.txt";

            using (StreamReader str = new StreamReader(path))
            {
                string info = str.ReadToEnd();
                tbx_info.Text = "Dear," + user.GetUsername()+ Environment.NewLine  + info;
            }

      
    }

    private void InformationPage_Load(object sender, System.EventArgs e)
        {
            ActiveControl = top_panel;
        }

        private void tbx_info_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void InformationPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
