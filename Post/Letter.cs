using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Post.Model
{
	public class Letter
	{
		public Guid ID { get; set; }

		[Required] public Guid UserFromID { get; set; }
		[ForeignKey("UserFromID")] public User UserFrom { get; set; }

		[Required] public Guid UserToID { get; set; }
		[ForeignKey("UserFromID")] public User UserTo { get; set; }

		[Required] public DateTime Time { get; set; }
		public string Text { get; set; }
		public byte[] Attach { get; set; }
		public string AttachName { get; set; }
	}
}