using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class MessageResult
	{
		[Column("CorrelationHandleID")]
		public String CorrelationHandleID { get; set; }
		[Column("Message")]
		public String Message { get; set; }
		[Column("ResponseTime")]
		public String ResponseTime { get; set; }
		[Column("SQLInfo")]
		public String SQLInfo { get; set; }
	}
}