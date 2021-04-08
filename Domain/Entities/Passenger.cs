using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class Passenger
	{
		[Column("CARRIER_FEE_FOP_GROUP_ID")]
		public decimal? CARRIER_FEE_FOP_GROUP_ID { get; set; }
		public bool ShouldSerializeCARRIER_FEE_FOP_GROUP_ID() => CARRIER_FEE_FOP_GROUP_ID.HasValue;
		[Column("CARRIER_FEE_TFC_GROUP_ID")]
		public decimal? CARRIER_FEE_TFC_GROUP_ID { get; set; }
		public bool ShouldSerializeCARRIER_FEE_TFC_GROUP_ID() => CARRIER_FEE_TFC_GROUP_ID.HasValue;
		[Column("BASE_FARE_AD_GROUP_ID")]
		public decimal? BASE_FARE_AD_GROUP_ID { get; set; }
		public bool ShouldSerializeBASE_FARE_AD_GROUP_ID() => BASE_FARE_AD_GROUP_ID.HasValue;
		[Column("EQUIVALENT_FARE_AD_GROUP_ID")]
		public decimal? EQUIVALENT_FARE_AD_GROUP_ID { get; set; }
		public bool ShouldSerializeEQUIVALENT_FARE_AD_GROUP_ID() => EQUIVALENT_FARE_AD_GROUP_ID.HasValue;
		[Column("TOTAL_FARE_AD_GROUP_ID")]
		public decimal? TOTAL_FARE_AD_GROUP_ID { get; set; }
		public bool ShouldSerializeTOTAL_FARE_AD_GROUP_ID() => TOTAL_FARE_AD_GROUP_ID.HasValue;
		[Column("PRICE_QUOTE_DT")]
		public DateTime? PRICE_QUOTE_DT { get; set; }
		public bool ShouldSerializePRICE_QUOTE_DT() => PRICE_QUOTE_DT.HasValue;
		[Column("ACCOUNTING_CD")]
		public string ACCOUNTING_CD { get; set; }
		[Column("PRICING_DESIGNATOR")]
		public string PRICING_DESIGNATOR { get; set; }
		[Column("QUANTITY")]
		public decimal? QUANTITY { get; set; }
		public bool ShouldSerializeQUANTITY() => QUANTITY.HasValue;
		[Column("EXCHANGE_RATE")]
		public decimal? EXCHANGE_RATE { get; set; }
		public bool ShouldSerializeEXCHANGE_RATE() => EXCHANGE_RATE.HasValue;
		[Column("TOTAL_CONST_AD_GROUP_ID")]
		public decimal? TOTAL_CONST_AD_GROUP_ID { get; set; }
		public bool ShouldSerializeTOTAL_CONST_AD_GROUP_ID() => TOTAL_CONST_AD_GROUP_ID.HasValue;
		[Column("COMMISSION_ID")]
		public decimal? COMMISSION_ID { get; set; }
		public bool ShouldSerializeCOMMISSION_ID() => COMMISSION_ID.HasValue;
		[Column("BUNDLING_FLAG")]
		public string BUNDLING_FLAG { get; set; }
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("PAX_LAST_NM")]
		public string PAX_LAST_NM { get; set; }
		[Column("PAX_FIRST_NM")]
		public string PAX_FIRST_NM { get; set; }
		[Column("PAX_MIDDLE_NM")]
		public string PAX_MIDDLE_NM { get; set; }
		[Column("PAX_TYPE")]
		public string PAX_TYPE { get; set; }
		[Column("PAX_AGE")]
		public decimal? PAX_AGE { get; set; }
		public bool ShouldSerializePAX_AGE() => PAX_AGE.HasValue;
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
		[Column("PAX_PREFIX_NM")]
		public string PAX_PREFIX_NM { get; set; }
		[Column("PAX_SURNAME_PREFIX_NM")]
		public string PAX_SURNAME_PREFIX_NM { get; set; }
		[Column("PAX_SURNAME_SUFFIX_NM")]
		public string PAX_SURNAME_SUFFIX_NM { get; set; }
		[Column("PAX_TITLE_NM")]
		public string PAX_TITLE_NM { get; set; }
		[Column("PAX_SPECIFIC_DATA_VAL")]
		public string PAX_SPECIFIC_DATA_VAL { get; set; }
		[Column("FARE_NET_REPORTING_IND")]
		public string FARE_NET_REPORTING_IND { get; set; }
		[Column("FARE_NON_COMMISSIONABLE_FLAG")]
		public string FARE_NON_COMMISSIONABLE_FLAG { get; set; }
		[Column("FARE_NON_ENDORSABLE_FLAG")]
		public string FARE_NON_ENDORSABLE_FLAG { get; set; }
		[Column("FARE_NON_INTERLINEABLE_FLAG")]
		public string FARE_NON_INTERLINEABLE_FLAG { get; set; }
		[Column("FARE_NON_REFUNDABLE_FLAG")]
		public string FARE_NON_REFUNDABLE_FLAG { get; set; }
		[Column("FARE_NON_REISSUE_NON_XCHG_FLAG")]
		public string FARE_NON_REISSUE_NON_XCHG_FLAG { get; set; }
		[Column("FARE_PENALTY_RESTRICTION_FLAG")]
		public string FARE_PENALTY_RESTRICTION_FLAG { get; set; }
		[Column("FARE_PRICING_SYSTEM_CD")]
		public string FARE_PRICING_SYSTEM_CD { get; set; }
		[Column("FARE_STATISTICAL_CD")]
		public string FARE_STATISTICAL_CD { get; set; }
		[NotMapped]
		[XmlElement]
		public List<TravelIdentifier> TravelIdentifier { get; set; } = new List<TravelIdentifier>();
		public bool ShouldSerializeTravelIdentifier() => TravelIdentifier.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<FareCategory> FareCategory { get; set; } = new List<FareCategory>();
		public bool ShouldSerializeFareCategory() => FareCategory.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<FarePenalty> FarePenalty { get; set; } = new List<FarePenalty>();
		public bool ShouldSerializeFarePenalty() => FarePenalty.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<FareWaiver> FareWaiver { get; set; } = new List<FareWaiver>();
		public bool ShouldSerializeFareWaiver() => FareWaiver.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<BaseFareAmountGroup> BaseFareAmountGroup { get; set; } = new List<BaseFareAmountGroup>();
		public bool ShouldSerializeBaseFareAmountGroup() => BaseFareAmountGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<EquivalentFareAmountGroup> EquivalentFareAmountGroup { get; set; } = new List<EquivalentFareAmountGroup>();
		public bool ShouldSerializeEquivalentFareAmountGroup() => EquivalentFareAmountGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<CarrierFee> CarrierFee { get; set; } = new List<CarrierFee>();
		public bool ShouldSerializeCarrierFee() => CarrierFee.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TotalFareAmountGroup> TotalFareAmountGroup { get; set; } = new List<TotalFareAmountGroup>();
		public bool ShouldSerializeTotalFareAmountGroup() => TotalFareAmountGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<CarrierFeeFormofPaymentGroup> CarrierFeeFormofPaymentGroup { get; set; } = new List<CarrierFeeFormofPaymentGroup>();
		public bool ShouldSerializeCarrierFeeFormofPaymentGroup() => CarrierFeeFormofPaymentGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<Commission> Commission { get; set; } = new List<Commission>();
		public bool ShouldSerializeCommission() => Commission.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<CarrierFeeTaxFeeChargesGroup> CarrierFeeTaxFeeChargesGroup { get; set; } = new List<CarrierFeeTaxFeeChargesGroup>();
		public bool ShouldSerializeCarrierFeeTaxFeeChargesGroup() => CarrierFeeTaxFeeChargesGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<CustomerLoyalty> CustomerLoyalty { get; set; } = new List<CustomerLoyalty>();
		public bool ShouldSerializeCustomerLoyalty() => CustomerLoyalty.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<PriceableUnit> PriceableUnit { get; set; } = new List<PriceableUnit>();
		public bool ShouldSerializePriceableUnit() => PriceableUnit.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TotalConstructionAmountGroup> TotalConstructionAmountGroup { get; set; } = new List<TotalConstructionAmountGroup>();
		public bool ShouldSerializeTotalConstructionAmountGroup() => TotalConstructionAmountGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<UnstructuredFareCalcInfo> UnstructuredFareCalcInfo { get; set; } = new List<UnstructuredFareCalcInfo>();
		public bool ShouldSerializeUnstructuredFareCalcInfo() => UnstructuredFareCalcInfo.Count > 0;
	}
}