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
	
	public partial class SearchControl : UserControl
	{
		private readonly MainForm _mf;

		public SearchControl(MainForm MF)
		{
			InitializeComponent();
			_mf = MF;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if(!string.IsNullOrWhiteSpace(SearchUserTextBox.Text))
			{
				User[] users=ServiceClient.SearchUsers(SearchUserTextBox.Text) as User[];
				_mf.AddSearchUsers(users);
			}
			else
			{
				SearchUserTextBox.Text = "Введите имя";
			}
		}
	}
}
