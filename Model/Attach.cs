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
		//"Message": "An error has occurred.",
		//"ExceptionMessage": "The 'ObjectContent`1' type failed to serialize the response body for content type 'application/json; charset=utf-8'.",
		//"ExceptionType": "System.InvalidOperationException",
		//"StackTrace": null,
		//"InnerException": {
		//	"Message": "An error has occurred.",
		//	"ExceptionMessage": "Self referencing loop detected for property 'Letter' with type 'Post.Model.Letter'. Path 'Attaches[0]'.",
		//	"ExceptionType": "Newtonsoft.Json.JsonSerializationException",
		//	"StackTrace": "   at Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.CheckForCircularReference(JsonWriter writer, Object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)\r\n 
}
}
