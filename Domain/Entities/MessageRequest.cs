using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class MessageRequest
	{
		[Column("CorrelationHandleID")]
		public String CorrelationHandleID { get; set; }
		[Column("HostCarrierCode")]
		public String HostCarrierCode { get; set; }
	}
}