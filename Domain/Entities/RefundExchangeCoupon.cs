using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class RefundExchangeCoupon
	{
		[Column("LAST_UPDATE_SOURCE_ID")]
		public string LAST_UPDATE_SOURCE_ID { get; set; }
		[Column("ROW_OBJECT_ID")]
		public string ROW_OBJECT_ID { get; set; }
		[Column("TXN_HISTORY_ID")]
		public decimal? TXN_HISTORY_ID { get; set; }
		public bool ShouldSerializeTXN_HISTORY_ID() => TXN_HISTORY_ID.HasValue;
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
		[Column("RFND_EXCH_CPN_TFC_GROUP_ID")]
		public decimal? RFND_EXCH_CPN_TFC_GROUP_ID { get; set; }
		public bool ShouldSerializeRFND_EXCH_CPN_TFC_GROUP_ID() => RFND_EXCH_CPN_TFC_GROUP_ID.HasValue;
		[Column("RFND_EXCH_CPN_AMT")]
		public decimal? RFND_EXCH_CPN_AMT { get; set; }
		public bool ShouldSerializeRFND_EXCH_CPN_AMT() => RFND_EXCH_CPN_AMT.HasValue;
		[Column("RFND_EXCH_CPN_CURRENCY_CD")]
		public string RFND_EXCH_CPN_CURRENCY_CD { get; set; }
		[Column("INSERT_DT")]
		public DateTime? INSERT_DT { get; set; }
		public bool ShouldSerializeINSERT_DT() => INSERT_DT.HasValue;
		[Column("INSERT_SOURCE_ID")]
		public string INSERT_SOURCE_ID { get; set; }
		[Column("LAST_UPDATE_DT")]
		public DateTime? LAST_UPDATE_DT { get; set; }
		public bool ShouldSerializeLAST_UPDATE_DT() => LAST_UPDATE_DT.HasValue;
		[NotMapped]
		[XmlElement]
		public List<RefundTaxFeeChargesGroup> RefundTaxFeeChargesGroup { get; set; } = new List<RefundTaxFeeChargesGroup>();
		public bool ShouldSerializeRefundTaxFeeChargesGroup() => RefundTaxFeeChargesGroup.Count > 0;
	}
}