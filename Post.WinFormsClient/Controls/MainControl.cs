using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Post.WinFormsClient.Forms;
using Post.WinFormsClient.Properties;

namespace Post.WinFormsClient.Controls
{
	public partial class MainControl : UserControl
	{
		private readonly MainForm _owner;

		public MainControl(MainForm owner)
		{
			InitializeComponent();
			if (Settings.Default.CurrentUser.Password == "0")
			{
				HelloLabel.Text = "Добрый день. Для начала работы необходимо изменить пароль :)";
				ChangePasswButton.Visible = true;
			}
			else
			{
				HelloLabel.Text = "Добрый день. Хорошей работы с Post :)";
			}

			_owner = owner;
		}

		private void ChangePasswButton_Click(object sender, EventArgs e)
		{
			Hide();
			_owner.ShowChangePasswordControl();
		}
	}
}
