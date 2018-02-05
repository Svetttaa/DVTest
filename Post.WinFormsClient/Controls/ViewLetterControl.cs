using System;
using System.Linq;
using System.Windows.Forms;
using Post.Model;
using Post.WinFormsClient.Forms;

namespace Post.WinFormsClient.Controls
{
	public partial class ViewLetterControl : UserControl
	{
		private Letter _letter;
		private MainForm _mf;

		public ViewLetterControl(Guid idLetter, MainForm MF)
		{
			InitializeComponent();
			_letter = ServiceClient.GetLetter(idLetter);
			_mf = MF;
			TitleLabel.Text = _letter.Title;
			UserFromLabel.Text = _letter.UserFrom.Name;
			TextLetterTextBox.Text = _letter.Text;
			DateLabel.Text = _letter.Time.ToString();
			//AttachesLabel.Text = "Файлов: " + _letter.Attaches.Count();

			//foreach (var att in _letter.Attaches)
			//{
			//	var menuItem = new ToolStripButton
			//	{
			//		Text = att.AttachName
			//	};
			//	menuItem.Click += (sender, args) =>
			//				  {
			//					  SaveAttachDialog.FileName = att.AttachName;
			//					  if (SaveAttachDialog.ShowDialog() != DialogResult.OK)
			//						  return;

			//					  ServiceClient.WriteFile(SaveAttachDialog.FileName, att.AttachBytes);
			//				  };

			//	AttachesMenu.Items.Add(menuItem);
			//}
		}

		private void AnswerButton_Click(object sender, EventArgs e)
		{
			Hide();
			_mf.AnswerLetter(_letter.UserFrom);
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			Hide();
			_mf.MinusLettersCount();
			ServiceClient.DeleteLetter(_letter.ID);
			_mf.ShowMainControl();
		}
	}
}
