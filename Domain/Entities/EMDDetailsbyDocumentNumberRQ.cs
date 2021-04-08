using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class EMDDetailsbyDocumentNumberRQ
	{
		[NotMapped]
		[XmlElement]
		public List<MessageRequest> MessageRequest { get; set; } = new List<MessageRequest>();
		public bool ShouldSerializeMessageRequest() => MessageRequest.Count > 0;
		[Column("DocumentNumber")]
		public String DocumentNumber { get; set; }
		[Column("PrimaryAirlineCd")]
		public String PrimaryAirlineCd { get; set; }
	}
}