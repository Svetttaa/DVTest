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
	public partial class UserSearchControl : UserControl
	{
		private readonly MainForm _mf;
		private readonly User _user;
		public UserSearchControl(User user, MainForm MF)
		{
			InitializeComponent();
			_user = user;
			_mf = MF;
			NameLabel.Text = _user.Name;
			AccountLabel.Text = _user.Account;
		}



		private void WriteLetterButton_Click(object sender, EventArgs e)
		{
			Hide();
			_mf.AnswerLetter(_user);
		}
	}
}
