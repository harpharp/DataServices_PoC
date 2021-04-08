using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class BaseFareAmount
	{
		[Column("AMOUNT_DETAIL_GROUP_ID")]
		public decimal? AMOUNT_DETAIL_GROUP_ID { get; set; }
		public bool ShouldSerializeAMOUNT_DETAIL_GROUP_ID() => AMOUNT_DETAIL_GROUP_ID.HasValue;
		[Column("AMOUNT_SEQ")]
		public decimal? AMOUNT_SEQ { get; set; }
		public bool ShouldSerializeAMOUNT_SEQ() => AMOUNT_SEQ.HasValue;
		[Column("AMOUNT_VAL")]
		public decimal? AMOUNT_VAL { get; set; }
		public bool ShouldSerializeAMOUNT_VAL() => AMOUNT_VAL.HasValue;
		[Column("PURPOSE_TYPE_NM")]
		public string PURPOSE_TYPE_NM { get; set; }
		[Column("CURRENCY_CD")]
		public string CURRENCY_CD { get; set; }
		[Column("FARE_AMOUNT_TYPE_NM")]
		public string FARE_AMOUNT_TYPE_NM { get; set; }
		[Column("REFUND_CALCULATION_IND")]
		public string REFUND_CALCULATION_IND { get; set; }
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