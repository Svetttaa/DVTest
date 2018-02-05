using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Post.Model
{
	public class Letter
	{
		public Guid ID { get; set; } = Guid.NewGuid();

		[Required] public Guid UserFromID { get; set; }
		[ForeignKey("UserFromID")] public User UserFrom { get; set; }

		[Required] public Guid UserToID { get; set; }
		[ForeignKey("UserFromID")] public User UserTo { get; set; }

		[Required] public DateTime Time { get; set; } = DateTime.Now;
		public string Title { get; set; }
		public string Text { get; set; }
		public IEnumerable<Attach> Attaches { get; set; }
		public bool Read { get; set; } = false;
	}
}
