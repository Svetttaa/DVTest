using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Post.WinFormsClient.Controls;
using Post.WinFormsClient.Properties;
using Post.Model;

namespace Post.WinFormsClient.Forms
{
	public partial class MainForm : Form
	{
		private int UpdaterDelay = 0;
		private bool KeepUpdating = true;
		private int Skip = 0;
		private const int Amount = 10;
		private int LettersCount = ServiceClient.GetAmountLetters(Settings.Default.UserID);

		public MainForm()
		{
			InitializeComponent();
			CurrentUserLabel.Text = Settings.Default.CurrentUser.Name;
			if (Settings.Default.CurrentUser.Password == "0")
			{
				UserSearchButton.Visible = false;
				WriteLetterButton.Visible = false;
			}

			ShowMainControl();
			LettersUpdateBGW.RunWorkerAsync();
		}

		private void UserExitButton_Click(object sender, EventArgs e)
		{
			Settings.Default.CurrentUser = null;
			Settings.Default.UserID = new Guid();
			Settings.Default.Save();
			KeepUpdating = false;
			Close();
			(new StartForm()).Show();
		}

		public void ShowChangePasswordControl()
		{
			ChangePasswordControl newPasswordControl = new ChangePasswordControl(this) { Left = 50, Top = 50 };
			panel3.Controls.Add(newPasswordControl);
		}

		public void ShowSearchControl()
		{
			SearchControl newSearchControl=new SearchControl(this) { Left = 0, Top = 0 };
			panel3.Controls.Add(newSearchControl);
		}

		public void ShowMainControl()
		{
			MainControl newMainControl = new MainControl(this) { Left = 50, Top = 50 };
			panel3.Controls.Add(newMainControl);
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			ShowChangePasswordControl();
		}

		private void UserSearchButton_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			ShowSearchControl();
		}

		private void WriteLetterButton_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			var l=new NewLetterControl(this);
			panel3.Controls.Add(l);
		}

		public void AnswerLetter(User user)
		{

			panel3.Controls.Clear();
			var l = new NewLetterControl(this,user);
			panel3.Controls.Add(l);
		}

		public void OpenLetter(Letter letter)
		{
			panel3.Controls.Clear();
			var l = new ViewLetterControl(letter.ID, this);
			//l.Location = new Point(Top = 50, Left = 50);
			panel3.Controls.Add(l);
		}

		private void LettersUpdateBGW_DoWork(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(UpdaterDelay);
			var currentAmount =KeepUpdating? ServiceClient.GetAmountLetters(Settings.Default.UserID):0;
			if (currentAmount == LettersCount && UpdaterDelay!=0)
			{
				e.Result = new Letter[0];
			}
			else
			{
				e.Result = KeepUpdating
					           ? ServiceClient.GetLetters(Settings.Default.CurrentUser.ID, Skip, Amount) as Letter[]
					           : new Letter[0];
				LettersCount = currentAmount;
			}
		}

		private void LettersUpdateBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

			var letters = e.Result as Letter[];

			if(letters.Length > 0)
			{
				panel2.Controls.Clear();
				for(int i = 0; i < letters.Length; i++)
				{
					panel2.Controls.Add(
					                    new PreviewLetterControl(letters[i], this)
					                    {
						                    Top = i * 75 + 20,
					                    }
					                   );
				}

			}

			if (UpdaterDelay == 0)
				UpdaterDelay = 7000;

			if (KeepUpdating)
				LettersUpdateBGW.RunWorkerAsync();
		}

		public void MinusLettersCount()
		{
			LettersCount--;
		}

		public void AddSearchUsers(User[] users)
		{
			if (users.Length > 0)
			{
				panel3.Controls.Add(panel4);
				panel4.Visible = true;
				panel4.Controls.Clear();
				for (int i = 0; i < users.Length; i++)
				{
					panel4.Controls.Add(
					                        new UserSearchControl(users[i], this)
					                        {
						                        Top = i * 70 + 20,
					                        }
					                       );
				}

			}
		}
	}
}
