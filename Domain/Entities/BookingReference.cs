using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class BookingReference
	{
		[Column("BOOKING_REF_GROUP_ID")]
		public decimal? BOOKING_REF_GROUP_ID { get; set; }
		public bool ShouldSerializeBOOKING_REF_GROUP_ID() => BOOKING_REF_GROUP_ID.HasValue;
		[Column("PNR_SEQ")]
		public decimal? PNR_SEQ { get; set; }
		public bool ShouldSerializePNR_SEQ() => PNR_SEQ.HasValue;
		[Column("PNR_RECORD_LOCATOR")]
		public string PNR_RECORD_LOCATOR { get; set; }
		[Column("PNR_COMPANY_CD")]
		public string PNR_COMPANY_CD { get; set; }
		[Column("IS_HOST_PNR_FLAG")]
		public string IS_HOST_PNR_FLAG { get; set; }
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
	}
}