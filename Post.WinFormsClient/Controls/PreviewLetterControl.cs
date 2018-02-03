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
	public partial class PreviewLetterControl : UserControl
	{
		private readonly Letter _thisLetter;
		private readonly MainForm _owner;

		public PreviewLetterControl(Letter letter,MainForm owner)
		{
			InitializeComponent();
			_thisLetter = letter;
			_owner = owner;

			TitleLabel.Text = _thisLetter.Title;
			TextLabel.Text = _thisLetter.Text+" ...";
			DateLabel.Text = _thisLetter.Time.ToString();
			NameLabel.Text = _thisLetter.UserFrom.Name;
			//NameLabel.Text = ServiceClient.GetUser(_thisLetter.UserFromID).Name;

		}

		private void PreviewLetterControl_Click(object sender, EventArgs e)
		{
			//При открытии установаить read=true и сохранить
			//(MainForm)Parent.OpenLetter(_thisLetter);
			//OpenLetter(_thisLetter);
			_owner.OpenLetter(_thisLetter);
		}
	}
}
