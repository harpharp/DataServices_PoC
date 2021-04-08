using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class CarrierFeeAmount
	{
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("CARRIER_FEE_SEQ")]
		public decimal? CARRIER_FEE_SEQ { get; set; }
		public bool ShouldSerializeCARRIER_FEE_SEQ() => CARRIER_FEE_SEQ.HasValue;
		[Column("CARRIER_FEE_AMOUNT_SEQ")]
		public decimal? CARRIER_FEE_AMOUNT_SEQ { get; set; }
		public bool ShouldSerializeCARRIER_FEE_AMOUNT_SEQ() => CARRIER_FEE_AMOUNT_SEQ.HasValue;
		[Column("CARRIER_FEE_AMT")]
		public decimal? CARRIER_FEE_AMT { get; set; }
		public bool ShouldSerializeCARRIER_FEE_AMT() => CARRIER_FEE_AMT.HasValue;
		[Column("CARRIER_FEE_AMOUNT_TYPE_CD")]
		public string CARRIER_FEE_AMOUNT_TYPE_CD { get; set; }
		[Column("CARRIER_FEE_APPLICATION_CD")]
		public string CARRIER_FEE_APPLICATION_CD { get; set; }
		[Column("CARRIER_FEE_FROM_AIRPORT_CD")]
		public string CARRIER_FEE_FROM_AIRPORT_CD { get; set; }
		[Column("CARRIER_FEE_TO_AIRPORT_CD")]
		public string CARRIER_FEE_TO_AIRPORT_CD { get; set; }
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