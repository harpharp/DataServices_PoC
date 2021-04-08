using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class FarePenalty
	{
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("FARE_PENALTY_SEQ")]
		public decimal? FARE_PENALTY_SEQ { get; set; }
		public bool ShouldSerializeFARE_PENALTY_SEQ() => FARE_PENALTY_SEQ.HasValue;
		[Column("PENALTY_TYPE")]
		public string PENALTY_TYPE { get; set; }
		[Column("PENALTY_AMT")]
		public decimal? PENALTY_AMT { get; set; }
		public bool ShouldSerializePENALTY_AMT() => PENALTY_AMT.HasValue;
		[Column("PENALTY_CURRENCY_CD")]
		public string PENALTY_CURRENCY_CD { get; set; }
		[Column("PENALTY_PCT")]
		public decimal? PENALTY_PCT { get; set; }
		public bool ShouldSerializePENALTY_PCT() => PENALTY_PCT.HasValue;
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