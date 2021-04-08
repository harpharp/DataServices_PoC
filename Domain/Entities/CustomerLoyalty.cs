using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class CustomerLoyalty
	{
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("CUSTOMER_LOYALTY_SEQ")]
		public decimal? CUSTOMER_LOYALTY_SEQ { get; set; }
		public bool ShouldSerializeCUSTOMER_LOYALTY_SEQ() => CUSTOMER_LOYALTY_SEQ.HasValue;
		[Column("PROGRAM_ID")]
		public string PROGRAM_ID { get; set; }
		[Column("MEMBERSHIP_ID")]
		public string MEMBERSHIP_ID { get; set; }
		[Column("INSERT_DT")]
		public DateTime? INSERT_DT { get; set; }
		public bool ShouldSerializeINSERT_DT() => INSERT_DT.HasValue;
		[Column("INSERT_SOURCE_ID")]
		public string INSERT_SOURCE_ID { get; set; }
		[Column("LAST_UPDATE_DT")]
		public DateTime? LAST_UPDATE_DT { get; set; }
		public bool ShouldSerializeLAST_UPDATE_DT() => LAST_UPDATE_DT.HasValue;
		[Column("LAST_UPDATE_SOURCE_ID")]
		public string LAST_UPDATE_SOURCE_ID { get; set; }
		[Column("ROW_OBJECT_ID")]
		public string ROW_OBJECT_ID { get; set; }
		[Column("LOYAL_LEVEL_TYPE")]
		public string LOYAL_LEVEL_TYPE { get; set; }
		[Column("VENDOR_CD")]
		public string VENDOR_CD { get; set; }
		[Column("MEMBERSHIP_ID_ENC")]
		public string MEMBERSHIP_ID_ENC { get; set; }
		[Column("MEMBERSHIP_ID_HASH")]
		public string MEMBERSHIP_ID_HASH { get; set; }
	}
}