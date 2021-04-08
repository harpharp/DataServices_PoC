using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class PurchaseTransaction
	{
		[Column("PURCHASE_TXN_ID")]
		public decimal? PURCHASE_TXN_ID { get; set; }
		public bool ShouldSerializePURCHASE_TXN_ID() => PURCHASE_TXN_ID.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("TXN_AMT")]
		public decimal? TXN_AMT { get; set; }
		public bool ShouldSerializeTXN_AMT() => TXN_AMT.HasValue;
		[Column("TXN_CURRENCY_CD")]
		public string TXN_CURRENCY_CD { get; set; }
		[Column("EQUIVALENT_PAID_AMT")]
		public decimal? EQUIVALENT_PAID_AMT { get; set; }
		public bool ShouldSerializeEQUIVALENT_PAID_AMT() => EQUIVALENT_PAID_AMT.HasValue;
		[Column("EQUIVALENT_CURRENCY_CD")]
		public string EQUIVALENT_CURRENCY_CD { get; set; }
		[Column("EQUIVALENT_CONVERSION_RATE")]
		public decimal? EQUIVALENT_CONVERSION_RATE { get; set; }
		public bool ShouldSerializeEQUIVALENT_CONVERSION_RATE() => EQUIVALENT_CONVERSION_RATE.HasValue;
		[Column("TXN_DT")]
		public DateTime? TXN_DT { get; set; }
		public bool ShouldSerializeTXN_DT() => TXN_DT.HasValue;
		[Column("FOP_GROUP_ID")]
		public decimal? FOP_GROUP_ID { get; set; }
		public bool ShouldSerializeFOP_GROUP_ID() => FOP_GROUP_ID.HasValue;
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
		[Column("EQUIVALENT_CONVERSION_TYPE")]
		public string EQUIVALENT_CONVERSION_TYPE { get; set; }
		[NotMapped]
		[XmlElement]
		public List<FormofPaymentGroup> FormofPaymentGroup { get; set; } = new List<FormofPaymentGroup>();
		public bool ShouldSerializeFormofPaymentGroup() => FormofPaymentGroup.Count > 0;
	}
}