using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	[MessageContract]
	[XmlRoot(Namespace ="http:name.space/dataservice")]
	public class EMDDetailsbyDocumentNumberRS
	{
		[NotMapped]
		[XmlElement]
		public List<MessageResult> MessageResult { get; set; } = new List<MessageResult>();
		public bool ShouldSerializeMessageResult() => MessageResult.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<EMDDocumentDetail> EMDDocumentDetail { get; set; } = new List<EMDDocumentDetail>();
		public bool ShouldSerializeEMDDocumentDetail() => EMDDocumentDetail.Count > 0;
	}
}