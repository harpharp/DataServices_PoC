using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class FareComponentDetail
	{
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("PRICEABLE_UNIT_SEQ")]
		public decimal? PRICEABLE_UNIT_SEQ { get; set; }
		public bool ShouldSerializePRICEABLE_UNIT_SEQ() => PRICEABLE_UNIT_SEQ.HasValue;
		[Column("FARE_COMPONENT_DETAIL_SEQ")]
		public decimal? FARE_COMPONENT_DETAIL_SEQ { get; set; }
		public bool ShouldSerializeFARE_COMPONENT_DETAIL_SEQ() => FARE_COMPONENT_DETAIL_SEQ.HasValue;
		[Column("FARE_COMPONENT_DETAIL_NUM")]
		public decimal? FARE_COMPONENT_DETAIL_NUM { get; set; }
		public bool ShouldSerializeFARE_COMPONENT_DETAIL_NUM() => FARE_COMPONENT_DETAIL_NUM.HasValue;
		[Column("BASE_AMOUNT_ID")]
		public decimal? BASE_AMOUNT_ID { get; set; }
		public bool ShouldSerializeBASE_AMOUNT_ID() => BASE_AMOUNT_ID.HasValue;
		[Column("TARIFF_NUM")]
		public string TARIFF_NUM { get; set; }
		[Column("RULE_NM")]
		public string RULE_NM { get; set; }
		[Column("FARE_BASIS_CD")]
		public string FARE_BASIS_CD { get; set; }
		[Column("AGREEMENT_CD")]
		public string AGREEMENT_CD { get; set; }
		[Column("FARE_OWNER_CARRIER_CD")]
		public string FARE_OWNER_CARRIER_CD { get; set; }
		[Column("WAIVER_CD")]
		public string WAIVER_CD { get; set; }
		[Column("RULE_CD")]
		public string RULE_CD { get; set; }
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
		[Column("PAX_TYPE_CD")]
		public string PAX_TYPE_CD { get; set; }
		[NotMapped]
		[XmlElement]
		public List<FareComponentCouponSeq> FareComponentCouponSeq { get; set; } = new List<FareComponentCouponSeq>();
		public bool ShouldSerializeFareComponentCouponSeq() => FareComponentCouponSeq.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TicketDesignator> TicketDesignator { get; set; } = new List<TicketDesignator>();
		public bool ShouldSerializeTicketDesignator() => TicketDesignator.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<ConstructionPrinciple> ConstructionPrinciple { get; set; } = new List<ConstructionPrinciple>();
		public bool ShouldSerializeConstructionPrinciple() => ConstructionPrinciple.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<BaseFareAmountGroup> BaseFareAmountGroup { get; set; } = new List<BaseFareAmountGroup>();
		public bool ShouldSerializeBaseFareAmountGroup() => BaseFareAmountGroup.Count > 0;
	}
}