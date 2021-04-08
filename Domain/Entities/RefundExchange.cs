using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class RefundExchange
	{
		[Column("RFND_BASE_FARE_AMT")]
		public decimal? RFND_BASE_FARE_AMT { get; set; }
		public bool ShouldSerializeRFND_BASE_FARE_AMT() => RFND_BASE_FARE_AMT.HasValue;
		[Column("RFND_EXCH_EMD_TFC_GROUP_ID")]
		public decimal? RFND_EXCH_EMD_TFC_GROUP_ID { get; set; }
		public bool ShouldSerializeRFND_EXCH_EMD_TFC_GROUP_ID() => RFND_EXCH_EMD_TFC_GROUP_ID.HasValue;
		[Column("TXN_HISTORY_ID")]
		public decimal? TXN_HISTORY_ID { get; set; }
		public bool ShouldSerializeTXN_HISTORY_ID() => TXN_HISTORY_ID.HasValue;
		[Column("RFND_EXCH_TYPE_CD")]
		public string RFND_EXCH_TYPE_CD { get; set; }
		[Column("RFND_CALC_CD")]
		public string RFND_CALC_CD { get; set; }
		[Column("RFND_EXCH_AMT")]
		public decimal? RFND_EXCH_AMT { get; set; }
		public bool ShouldSerializeRFND_EXCH_AMT() => RFND_EXCH_AMT.HasValue;
		[Column("RFND_EXCH_CURRENCY_CD")]
		public string RFND_EXCH_CURRENCY_CD { get; set; }
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
		[NotMapped]
		[XmlElement]
		public List<FormOfRefund> FormOfRefund { get; set; } = new List<FormOfRefund>();
		public bool ShouldSerializeFormOfRefund() => FormOfRefund.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<RefundTaxFeeChargesGroup> RefundTaxFeeChargesGroup { get; set; } = new List<RefundTaxFeeChargesGroup>();
		public bool ShouldSerializeRefundTaxFeeChargesGroup() => RefundTaxFeeChargesGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<RefundExchangeCoupon> RefundExchangeCoupon { get; set; } = new List<RefundExchangeCoupon>();
		public bool ShouldSerializeRefundExchangeCoupon() => RefundExchangeCoupon.Count > 0;
	}
}