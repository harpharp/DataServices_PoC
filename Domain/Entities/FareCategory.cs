using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class FareCategory
	{
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("FARE_CATEGORY_SEQ")]
		public decimal? FARE_CATEGORY_SEQ { get; set; }
		public bool ShouldSerializeFARE_CATEGORY_SEQ() => FARE_CATEGORY_SEQ.HasValue;
		[Column("ATPCO_FARE_CATEGORY_NBR")]
		public decimal? ATPCO_FARE_CATEGORY_NBR { get; set; }
		public bool ShouldSerializeATPCO_FARE_CATEGORY_NBR() => ATPCO_FARE_CATEGORY_NBR.HasValue;
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