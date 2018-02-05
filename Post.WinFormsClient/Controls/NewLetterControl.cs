using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Post.Model;
using Post.WinFormsClient.Forms;
using Post.WinFormsClient.Properties;

namespace Post.WinFormsClient.Controls
{
	public partial class NewLetterControl : UserControl
	{
		private MainForm _owner;
		private readonly User _userTo;
		private List<Attach> Attaches = new List<Attach>();

		public NewLetterControl(MainForm owner, User to = null)
		{
			InitializeComponent();
			_owner = owner;
			if (to != null)
			{
				_userTo = to;
				UserToDropDown.Items.Add(_userTo);
			}
			else
			{
				UserToDropDown.Items.AddRange(ServiceClient.GetAllUsers().Where(x => x.ID != Settings.Default.UserID).ToArray());
			}
		}

		private void AttachButton_Click(object sender, System.EventArgs e)
		{
			if (openAttach.ShowDialog() != DialogResult.OK)
				return;

			// Максимальный размер - 10 мб
			foreach (var fileName in openAttach.FileNames)
			{
				var file = new FileInfo(fileName);
				if (file.Length > 10000000)
				{
					MessageBox.Show("Размер каждого файла не должен превышать 10 МБ");
					Attaches.Clear();
					return;
				}
				Attaches.Add(new Attach
				{
					AttachBytes = ServiceClient.GetBytes(fileName),
					AttachName = fileName.Split('\\').Last()
				});
			}

			AttachesLabel.Text = "Файлов: " + openAttach.FileNames.Length;
			ClearAttaches.Visible = true;
		}

		private void ClearAttaches_Click(object sender, System.EventArgs e)
		{
			Attaches.Clear();
			ClearAttaches.Visible = false;
			AttachesLabel.Text = "Файлов: 0";
		}

		private void SendButton_Click(object sender, System.EventArgs e)
		{
			ServiceClient.SendLetter(
									 new Letter()
									 {
										 Attaches = Attaches.ToArray(),
										 Text = TextLetterTextBox.Text,
										 Title = TitleTextBox.Text,
										 UserFromID = Settings.Default.UserID,
										 UserToID = ((User)UserToDropDown.SelectedItem).ID
									 }
			                        );
			Hide();
			_owner.ShowMainControl();
		}
	}
}
