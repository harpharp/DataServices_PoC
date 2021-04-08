using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class EMDCoupons
	{
		[Column("CONTROL_DT")]
		public DateTime? CONTROL_DT { get; set; }
		public bool ShouldSerializeCONTROL_DT() => CONTROL_DT.HasValue;
		[Column("MSG_EXP_DT")]
		public DateTime? MSG_EXP_DT { get; set; }
		public bool ShouldSerializeMSG_EXP_DT() => MSG_EXP_DT.HasValue;
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
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("BAGGAGE_ALLOWANCE_QTY")]
		public decimal? BAGGAGE_ALLOWANCE_QTY { get; set; }
		public bool ShouldSerializeBAGGAGE_ALLOWANCE_QTY() => BAGGAGE_ALLOWANCE_QTY.HasValue;
		[Column("BAGGAGE_ALLOWANCE_UNIT")]
		public string BAGGAGE_ALLOWANCE_UNIT { get; set; }
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
		[Column("CPN_FREE_TXT")]
		public string CPN_FREE_TXT { get; set; }
		[Column("CPN_AMT")]
		public decimal? CPN_AMT { get; set; }
		public bool ShouldSerializeCPN_AMT() => CPN_AMT.HasValue;
		[Column("CPN_CURRENCY_CD")]
		public string CPN_CURRENCY_CD { get; set; }
		[Column("CPN_CONVERSION_RATE")]
		public decimal? CPN_CONVERSION_RATE { get; set; }
		public bool ShouldSerializeCPN_CONVERSION_RATE() => CPN_CONVERSION_RATE.HasValue;
		[Column("TFC_GROUP_ID")]
		public decimal? TFC_GROUP_ID { get; set; }
		public bool ShouldSerializeTFC_GROUP_ID() => TFC_GROUP_ID.HasValue;
		[Column("IATA_CPN_STATUS_CD")]
		public string IATA_CPN_STATUS_CD { get; set; }
		[Column("REASON_FOR_ISSUANCE_SUB_CD")]
		public string REASON_FOR_ISSUANCE_SUB_CD { get; set; }
		[Column("ASSOCIATED_FARE_BASIS_CD")]
		public string ASSOCIATED_FARE_BASIS_CD { get; set; }
		[Column("CONSUMED_AT_ISSUANCE_FLAG")]
		public string CONSUMED_AT_ISSUANCE_FLAG { get; set; }
		[Column("CPN_ITINERARY_SEQ_NBR")]
		public string CPN_ITINERARY_SEQ_NBR { get; set; }
		[Column("CPN_SERVICE_DT")]
		public DateTime? CPN_SERVICE_DT { get; set; }
		public bool ShouldSerializeCPN_SERVICE_DT() => CPN_SERVICE_DT.HasValue;
		[Column("IN_CONNECTION_CPN_NBR")]
		public decimal? IN_CONNECTION_CPN_NBR { get; set; }
		public bool ShouldSerializeIN_CONNECTION_CPN_NBR() => IN_CONNECTION_CPN_NBR.HasValue;
		[Column("CPN_ASSOCIATE_FLAG")]
		public string CPN_ASSOCIATE_FLAG { get; set; }
		[Column("CPN_SERVICE_PROVIDER_NM")]
		public string CPN_SERVICE_PROVIDER_NM { get; set; }
		[Column("CPN_SERVICE_PROVIDER_LOC")]
		public string CPN_SERVICE_PROVIDER_LOC { get; set; }
		[Column("CPN_PROMOTIONAL_CD")]
		public string CPN_PROMOTIONAL_CD { get; set; }
		[Column("TAX_ON_EMD_FLAG")]
		public string TAX_ON_EMD_FLAG { get; set; }
		[Column("VALIDATING_AIRLINE_CD")]
		public string VALIDATING_AIRLINE_CD { get; set; }
		[Column("NUMBER_OF_SERVICES_CNT")]
		public decimal? NUMBER_OF_SERVICES_CNT { get; set; }
		public bool ShouldSerializeNUMBER_OF_SERVICES_CNT() => NUMBER_OF_SERVICES_CNT.HasValue;
		[Column("COUPON_TYPE")]
		public string COUPON_TYPE { get; set; }
		[Column("CPN_VALUE")]
		public decimal? CPN_VALUE { get; set; }
		public bool ShouldSerializeCPN_VALUE() => CPN_VALUE.HasValue;
		[Column("IN_CONNECTION_DOC_NBR")]
		public string IN_CONNECTION_DOC_NBR { get; set; }
		[Column("SETTLEMENT_AUTHORIZATION_CD")]
		public string SETTLEMENT_AUTHORIZATION_CD { get; set; }
		[Column("COMMERCIAL_NM")]
		public string COMMERCIAL_NM { get; set; }
		[Column("SSR_CD")]
		public string SSR_CD { get; set; }
		[Column("SVC_REQUIRED_FLAG")]
		public string SVC_REQUIRED_FLAG { get; set; }
		[Column("START_DT")]
		public DateTime? START_DT { get; set; }
		public bool ShouldSerializeSTART_DT() => START_DT.HasValue;
		[Column("END_DT")]
		public DateTime? END_DT { get; set; }
		public bool ShouldSerializeEND_DT() => END_DT.HasValue;
		[Column("DURATION_VAL")]
		public string DURATION_VAL { get; set; }
		[Column("EXCESS_BAGGAGE_AMT")]
		public decimal? EXCESS_BAGGAGE_AMT { get; set; }
		public bool ShouldSerializeEXCESS_BAGGAGE_AMT() => EXCESS_BAGGAGE_AMT.HasValue;
		[Column("EXCESS_BAGGAGE_CURRENCY_CD")]
		public string EXCESS_BAGGAGE_CURRENCY_CD { get; set; }
		[Column("VOLUNTARY_INVOLUNTARY_IND")]
		public string VOLUNTARY_INVOLUNTARY_IND { get; set; }
		[Column("CONTROLLING_AIRLINE_CD")]
		public string CONTROLLING_AIRLINE_CD { get; set; }
		[Column("IN_CONNECTION_PRIMARY_DOC_NBR")]
		public string IN_CONNECTION_PRIMARY_DOC_NBR { get; set; }
		[Column("BAGGAGE_UNIT_OF_MEAS")]
		public string BAGGAGE_UNIT_OF_MEAS { get; set; }
		[Column("FARE_BASIS_CD")]
		public string FARE_BASIS_CD { get; set; }
		[Column("ADDL_SVC_INFO_GRP")]
		public string ADDL_SVC_INFO_GRP { get; set; }
		[Column("ADDL_SVC_INFO_SUB_GRP")]
		public string ADDL_SVC_INFO_SUB_GRP { get; set; }
		[Column("ADDL_SVC_INFO_RFISC_DEF_TYPE")]
		public string ADDL_SVC_INFO_RFISC_DEF_TYPE { get; set; }
		[Column("ADDL_SVC_INFO_SVC_TYPE")]
		public string ADDL_SVC_INFO_SVC_TYPE { get; set; }
		[Column("INTERLINEABLE_FLAG")]
		public string INTERLINEABLE_FLAG { get; set; }
		[NotMapped]
		[XmlElement]
		public List<CouponAttributes> CouponAttributes { get; set; } = new List<CouponAttributes>();
		public bool ShouldSerializeCouponAttributes() => CouponAttributes.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<CouponSegments> CouponSegments { get; set; } = new List<CouponSegments>();
		public bool ShouldSerializeCouponSegments() => CouponSegments.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TaxFeeChargesGroup> TaxFeeChargesGroup { get; set; } = new List<TaxFeeChargesGroup>();
		public bool ShouldSerializeTaxFeeChargesGroup() => TaxFeeChargesGroup.Count > 0;
	}
}