using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class CouponSegments
	{
		[Column("PRIMARY_AIRLINE_CD")]
		public string PRIMARY_AIRLINE_CD { get; set; }
		[Column("PRIMARY_DOCUMENT_NBR")]
		public string PRIMARY_DOCUMENT_NBR { get; set; }
		[Column("PRIMARY_ISSUE_DT")]
		public DateTime? PRIMARY_ISSUE_DT { get; set; }
		public bool ShouldSerializePRIMARY_ISSUE_DT() => PRIMARY_ISSUE_DT.HasValue;
		[Column("BOOKLET_DOCUMENT_NBR")]
		public string BOOKLET_DOCUMENT_NBR { get; set; }
		[Column("CPN_NBR")]
		public decimal? CPN_NBR { get; set; }
		public bool ShouldSerializeCPN_NBR() => CPN_NBR.HasValue;
		[Column("ITINERARY_ID")]
		public decimal? ITINERARY_ID { get; set; }
		public bool ShouldSerializeITINERARY_ID() => ITINERARY_ID.HasValue;
		[Column("SEG_SEQ")]
		public decimal? SEG_SEQ { get; set; }
		public bool ShouldSerializeSEG_SEQ() => SEG_SEQ.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("ROW_OBJECT_ID")]
		public string ROW_OBJECT_ID { get; set; }
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
	}
}