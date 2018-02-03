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
using Post.WinFormsClient.Forms;

namespace Post.WinFormsClient
{
	public partial class StartForm : Form
	{
		int h, w;

		public StartForm()
		{
			InitializeComponent();
		}

		public void ShowLoginForm()
		{
			LoginButton.Visible = false;

			LoginControl loginControl = new LoginControl
			{
				Top = 220,
				Left = 30
			};
			Controls.Add(loginControl);
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			ShowLoginForm();
		}

		private void StartForm_Load(object sender, EventArgs e)
		{
			

		}
		public void BackToStartForm()
		{
			LoginButton.Visible=true;
		}
		public void CloseAndContinue()
		{
			Close();
			var newForm = new MainForm();

			newForm.Show();
		}
	}
}
