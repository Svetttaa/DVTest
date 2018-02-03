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
using Post.WinFormsClient.Forms;

namespace Post.WinFormsClient.Controls
{
	public partial class ChangePasswordControl : UserControl
	{
		private readonly MainForm _mf;
		public ChangePasswordControl(MainForm MF)
		{
			InitializeComponent();
			_mf = MF;
		}

		private void SaveNewPassButton_Click(object sender, EventArgs e)
		{
			if(PassTextBox.Text!=PassAgainTextBox.Text)
			{
				ErrorsLabel.Text = "Введенные пароли не совпадают";
				ErrorsLabel.Visible = true;
				return;
			}
			if (string.IsNullOrWhiteSpace(PassTextBox.Text))
			{
				ErrorsLabel.Text = "Пароль не должен быть пустым";
				ErrorsLabel.Visible = true;
				return;
			}
			User u = new User
			{
				ID = Properties.Settings.Default.CurrentUser.ID,
				Password= PassAgainTextBox.Text
			};
			ErrorsLabel.Text = "";
			ErrorsLabel.Visible = false;
			ServiceClient.ChangePassword(u);
			//_mf.Controls.Add(//new MainControl);
		}
	}
}
