using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class FormOfRefund
	{
		[Column("MASKED_CARD_NBR")]
		public string MASKED_CARD_NBR { get; set; }
		[Column("FORM_OF_REFUND_ID")]
		public decimal? FORM_OF_REFUND_ID { get; set; }
		public bool ShouldSerializeFORM_OF_REFUND_ID() => FORM_OF_REFUND_ID.HasValue;
		[Column("TXN_HISTORY_ID")]
		public decimal? TXN_HISTORY_ID { get; set; }
		public bool ShouldSerializeTXN_HISTORY_ID() => TXN_HISTORY_ID.HasValue;
		[Column("REFUND_TYPE")]
		public string REFUND_TYPE { get; set; }
		[Column("IDENTIFICATION_TYPE")]
		public string IDENTIFICATION_TYPE { get; set; }
		[Column("REFUND_TXT")]
		public string REFUND_TXT { get; set; }
		[Column("REFUND_REF")]
		public string REFUND_REF { get; set; }
		[Column("REFUND_CARDTYPE_CD")]
		public string REFUND_CARDTYPE_CD { get; set; }
		[Column("REFUND_CARDCODE_CD")]
		public string REFUND_CARDCODE_CD { get; set; }
		[Column("CARD_NBR")]
		public string CARD_NBR { get; set; }
		[Column("CARD_EXPIRY_DT")]
		public DateTime? CARD_EXPIRY_DT { get; set; }
		public bool ShouldSerializeCARD_EXPIRY_DT() => CARD_EXPIRY_DT.HasValue;
		[Column("CARD_FIRST_6_NBR")]
		public string CARD_FIRST_6_NBR { get; set; }
		[Column("CARD_LAST_4_NBR")]
		public string CARD_LAST_4_NBR { get; set; }
		[Column("APPROVAL_CD")]
		public string APPROVAL_CD { get; set; }
		[Column("CARD_TRANSACTION_INFO")]
		public string CARD_TRANSACTION_INFO { get; set; }
		[Column("APPROVAL_TYPE_CD")]
		public string APPROVAL_TYPE_CD { get; set; }
		[Column("CARD_HOLDER_NM")]
		public string CARD_HOLDER_NM { get; set; }
		[Column("REFUND_AMT")]
		public decimal? REFUND_AMT { get; set; }
		public bool ShouldSerializeREFUND_AMT() => REFUND_AMT.HasValue;
		[Column("REFUND_CURRENCY_CD")]
		public string REFUND_CURRENCY_CD { get; set; }
		[Column("REFUND_CALC_CD")]
		public string REFUND_CALC_CD { get; set; }
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