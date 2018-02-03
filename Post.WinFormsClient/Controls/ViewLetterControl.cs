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
	public partial class ViewLetterControl : UserControl
	{
		private Letter _letter;
		private MainForm _mf;

		public ViewLetterControl(Letter letter,MainForm MF)
		{
			InitializeComponent();
			_letter = letter;
			_mf = MF;
			TitleLabel.Text = _letter.Title;
			UserFromLabel.Text = _letter.UserFrom.Name;
			TextLabel.Text = _letter.Text;
			DateLabel.Text = _letter.Time.ToString();
		}

		private void AnswerButton_Click(object sender, EventArgs e)
		{

		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			Hide();
			ServiceClient.DeleteLetter(_letter.ID);
			_mf.ShowMainControl();
		}
	}
}
