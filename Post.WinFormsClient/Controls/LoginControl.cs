using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Post.Model;
using System.Threading;
using Post.WinFormsClient.Properties;

namespace Post.WinFormsClient.Controls
{
	public partial class LoginControl : UserControl
	{
		readonly string LoginPlaceholder = "Логин";
		readonly string PasswordPlaceholder = "Пароль";
		public LoginControl()
		{
			InitializeComponent();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			if (!CheckFields())
				return;
			User user = new User
			{
				Account = LoginTextBox.Text,
				Password = PasswordTextBox.Text
			};

			var retUser= ServiceClient.LoginUser(user);
			if(retUser is User)
			{
				Settings.Default.UserID = ((User)retUser).ID;
				Settings.Default.CurrentUser = (User)retUser;
				Settings.Default.Save();
				(Parent as StartForm).CloseAndContinue();
			}
			else if(retUser is string)
			{
				WarningLabel.Text = (string)retUser;
				WarningLabel.Visible = true;
			}
			else
			{
				MessageBox.Show(retUser.ToString());
			}
		}


		private bool CheckFields()
		{
			bool ret = true;

			if (LoginTextBox.Text == LoginPlaceholder || String.IsNullOrWhiteSpace(LoginTextBox.Text))
			{
				LoginTextBox.ForeColor = Properties.Settings.Default.WarnColor;
				ret = false;
			}
			else
			{
				LoginTextBox.ForeColor = Properties.Settings.Default.PrimaryColor;
			}

			if (PasswordTextBox.Text == PasswordPlaceholder || String.IsNullOrWhiteSpace(PasswordTextBox.Text))
			{
				PasswordTextBox.ForeColor = Properties.Settings.Default.WarnColor;
				ret = false;
			}
			else
			{
				PasswordTextBox.ForeColor = Properties.Settings.Default.PrimaryColor;
			}
			return ret;
		}

		private void LoginTextbox_Enter(object sender, EventArgs e)
		{
			LoginTextBox.Text="";
		}

		//private void LoginTextbox_Leave(object sender, EventArgs e)
		//{
		//	LoginTextbox.AddText(LoginPlaceholder);
		//}

		private void PasswordTextbox_Enter(object sender, EventArgs e)
		{
			PasswordTextBox.Text="";
			PasswordTextBox.PasswordChar = '●';
		}

		//private void PasswordTextbox_Leave(object sender, EventArgs e)
		//{
		//	PasswordTextbox.AddText(PasswordPlaceholder);
		//	if (String.IsNullOrWhiteSpace(PasswordTextbox.Text) || PasswordTextbox.Text == PasswordPlaceholder)
		//		PasswordTextbox.PasswordChar = '\0';
		//}



		private void BackToStartButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			var parentForm = (this.Parent as StartForm);
			parentForm.BackToStartForm();
		}

		private void WarningLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
