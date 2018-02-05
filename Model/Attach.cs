using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Model
{
	public class Attach
	{
		public Guid ID { get; set; }
		public byte[] AttachBytes { get; set; }
		public string AttachName { get; set; }

		public Guid LetterID { get; set; }
		//[ForeignKey("LetterID")]
		public Letter Letter { get; set; }
		//{"Object reference not set to an instance of an object."}
}
}
