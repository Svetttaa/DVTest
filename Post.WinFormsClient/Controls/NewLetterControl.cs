using System.Windows.Forms;
using Post.Model;
using Post.WinFormsClient.Forms;

namespace Post.WinFormsClient.Controls
{
	public partial class NewLetterControl : UserControl
	{
		private MainForm _owner;
		private readonly User _userTo;

		public NewLetterControl(MainForm owner, User to = null)
		{
			InitializeComponent();
			_owner = owner;
			if(to != null)
				_userTo = to;
		}
	}
}
