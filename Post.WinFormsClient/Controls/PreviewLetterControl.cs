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
			if(!_thisLetter.Read)
			{
				TitleLabel.Font = new Font(DefaultFont, FontStyle.Bold);
				TextLabel.Font = new Font(DefaultFont, FontStyle.Bold);
				NameLabel.Font = new Font(DefaultFont, FontStyle.Bold);
				DateLabel.Font = new Font(DefaultFont, FontStyle.Bold);
			}

		}

		private void PreviewLetterControl_Click(object sender, EventArgs e)
		{
			if(!_thisLetter.Read)
			{
				ServiceClient.ChangeReadStatus(_thisLetter.ID);
				TitleLabel.Font = new Font(DefaultFont, FontStyle.Regular);
				TextLabel.Font = new Font(DefaultFont, FontStyle.Regular);
				NameLabel.Font = new Font(DefaultFont, FontStyle.Regular);
				DateLabel.Font = new Font(DefaultFont, FontStyle.Regular);
			}
	
			_owner.OpenLetter(_thisLetter);
			

		}


	}
}
