using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class FormofPayments
	{
		[Column("PAYMENT_CARDTYPE_CD")]
		public string PAYMENT_CARDTYPE_CD { get; set; }
		[Column("PAYMENT_CARDCODE_CD")]
		public string PAYMENT_CARDCODE_CD { get; set; }
		[Column("MASKED_CARD_NBR")]
		public string MASKED_CARD_NBR { get; set; }
		[Column("FOP_GROUP_ID")]
		public decimal? FOP_GROUP_ID { get; set; }
		public bool ShouldSerializeFOP_GROUP_ID() => FOP_GROUP_ID.HasValue;
		[Column("FOP_SEQ")]
		public decimal? FOP_SEQ { get; set; }
		public bool ShouldSerializeFOP_SEQ() => FOP_SEQ.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("PAYMENT_TYPE")]
		public string PAYMENT_TYPE { get; set; }
		[Column("PAYMENT_REF")]
		public string PAYMENT_REF { get; set; }
		[Column("PAYMENT_AMT")]
		public decimal? PAYMENT_AMT { get; set; }
		public bool ShouldSerializePAYMENT_AMT() => PAYMENT_AMT.HasValue;
		[Column("PAYMENT_CURRENCY_CD")]
		public string PAYMENT_CURRENCY_CD { get; set; }
		[Column("APPROVAL_CD")]
		public string APPROVAL_CD { get; set; }
		[Column("CC_EXPIRY_DT")]
		public DateTime? CC_EXPIRY_DT { get; set; }
		public bool ShouldSerializeCC_EXPIRY_DT() => CC_EXPIRY_DT.HasValue;
		[Column("CC_NBR")]
		public string CC_NBR { get; set; }
		[Column("FOP_TXT")]
		public string FOP_TXT { get; set; }
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
		[Column("PAYMENT_EPC_CONVERSION_RATE")]
		public decimal? PAYMENT_EPC_CONVERSION_RATE { get; set; }
		public bool ShouldSerializePAYMENT_EPC_CONVERSION_RATE() => PAYMENT_EPC_CONVERSION_RATE.HasValue;
		[Column("EMD_AIRLINE_CD")]
		public string EMD_AIRLINE_CD { get; set; }
		[Column("EMD_DOCUMENT_NBR")]
		public string EMD_DOCUMENT_NBR { get; set; }
		[Column("EMD_ISSUE_DT")]
		public DateTime? EMD_ISSUE_DT { get; set; }
		public bool ShouldSerializeEMD_ISSUE_DT() => EMD_ISSUE_DT.HasValue;
		[Column("PAYMENT_CONVERSION_TYPE")]
		public string PAYMENT_CONVERSION_TYPE { get; set; }
		[Column("PAYMENT_EPC_CONVERSION_AMT")]
		public decimal? PAYMENT_EPC_CONVERSION_AMT { get; set; }
		public bool ShouldSerializePAYMENT_EPC_CONVERSION_AMT() => PAYMENT_EPC_CONVERSION_AMT.HasValue;
		[Column("PAYMENT_LCL_CONVERSION_RATE")]
		public decimal? PAYMENT_LCL_CONVERSION_RATE { get; set; }
		public bool ShouldSerializePAYMENT_LCL_CONVERSION_RATE() => PAYMENT_LCL_CONVERSION_RATE.HasValue;
		[Column("IDENTIFICATION_VAL")]
		public string IDENTIFICATION_VAL { get; set; }
		[Column("CC_LAST_4_NBR")]
		public string CC_LAST_4_NBR { get; set; }
		[Column("ADDRESS_LINE_1")]
		public string ADDRESS_LINE_1 { get; set; }
		[Column("ADDRESS_LINE_2")]
		public string ADDRESS_LINE_2 { get; set; }
		[Column("ADDRESS_LINE_3")]
		public string ADDRESS_LINE_3 { get; set; }
		[Column("ADDRESS_LINE_4")]
		public string ADDRESS_LINE_4 { get; set; }
		[Column("ADDRESS_LINE_5")]
		public string ADDRESS_LINE_5 { get; set; }
		[Column("PO_BOX_NBR")]
		public string PO_BOX_NBR { get; set; }
		[Column("STREET_NUMBER_SUFFIX_IND")]
		public string STREET_NUMBER_SUFFIX_IND { get; set; }
		[Column("STREET_DIRECTION_IND")]
		public string STREET_DIRECTION_IND { get; set; }
		[Column("RURAL_ROUTE_NBR")]
		public string RURAL_ROUTE_NBR { get; set; }
		[Column("BLDG_ROOM_NBR")]
		public string BLDG_ROOM_NBR { get; set; }
		[Column("CITY")]
		public string CITY { get; set; }
		[Column("STATE_PROVINCE_CD")]
		public string STATE_PROVINCE_CD { get; set; }
		[Column("COUNTRY_CD")]
		public string COUNTRY_CD { get; set; }
		[Column("POSTAL_CD")]
		public string POSTAL_CD { get; set; }
		[Column("CARD_HOLDER_NM")]
		public string CARD_HOLDER_NM { get; set; }
		[Column("COUNTY_NM")]
		public string COUNTY_NM { get; set; }
		[Column("STATE_PROVINCE_NM")]
		public string STATE_PROVINCE_NM { get; set; }
		[Column("COUNTRY_NM")]
		public string COUNTRY_NM { get; set; }
		[Column("CC_TRANSACTION_INFO")]
		public string CC_TRANSACTION_INFO { get; set; }
		[Column("AMOUNT_DETAIL_GROUP_ID")]
		public decimal? AMOUNT_DETAIL_GROUP_ID { get; set; }
		public bool ShouldSerializeAMOUNT_DETAIL_GROUP_ID() => AMOUNT_DETAIL_GROUP_ID.HasValue;
		[Column("CC_FIRST_6_NBR")]
		public string CC_FIRST_6_NBR { get; set; }
		[Column("QUALIFIER_CD")]
		public string QUALIFIER_CD { get; set; }
		[Column("IDENTIFICATION_TYPE")]
		public string IDENTIFICATION_TYPE { get; set; }
		[Column("PRE_AUTH_TRANSACTION_FLAG")]
		public string PRE_AUTH_TRANSACTION_FLAG { get; set; }
		[Column("EXCH_DOC_CPN_GROUP_ID")]
		public decimal? EXCH_DOC_CPN_GROUP_ID { get; set; }
		public bool ShouldSerializeEXCH_DOC_CPN_GROUP_ID() => EXCH_DOC_CPN_GROUP_ID.HasValue;
		[Column("APPROVAL_TYPE_CD")]
		public string APPROVAL_TYPE_CD { get; set; }
		[Column("EXTENDED_PAYMENT_CD")]
		public string EXTENDED_PAYMENT_CD { get; set; }
		[NotMapped]
		[XmlElement]
		public List<AmountDetailGroup> AmountDetailGroup { get; set; } = new List<AmountDetailGroup>();
		public bool ShouldSerializeAmountDetailGroup() => AmountDetailGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<FormOfPaymentAttribute> FormOfPaymentAttribute { get; set; } = new List<FormOfPaymentAttribute>();
		public bool ShouldSerializeFormOfPaymentAttribute() => FormOfPaymentAttribute.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<ExchangedCouponGroup> ExchangedCouponGroup { get; set; } = new List<ExchangedCouponGroup>();
		public bool ShouldSerializeExchangedCouponGroup() => ExchangedCouponGroup.Count > 0;
	}
}