using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Post.WinFormsClient.Controls;
using Post.WinFormsClient.Properties;

namespace Post.WinFormsClient.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			CurrentUserLabel.Text = Settings.Default.CurrentUser.Name;
			if (Settings.Default.CurrentUser.Password == "0")
			{
				UserSearchButton.Visible = false;
				WriteLetterButton.Visible = false;
			}

			panel3.Controls.Add(new MainControl(this){Top=50,Left = 50});
			//panel3.Controls.Add(new ChangePasswordControl());
		}

		private void UserExitButton_Click(object sender, EventArgs e)
		{
			Settings.Default.CurrentUser = null;
			Settings.Default.UserID=new Guid();
			Settings.Default.Save();
			Close();
			(new StartForm()).Show();
		}

		private void WriteLetterButton_Click(object sender, EventArgs e)
		{

		}

		public void ShowChangePasswordControl()
		{
			ChangePasswordControl newPasswordControl=new ChangePasswordControl(this){Left = 50,Top=50};
			panel3.Controls.Add(newPasswordControl);
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{
			ShowChangePasswordControl();
		}
	}
}
