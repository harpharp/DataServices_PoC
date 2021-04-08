using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class ConstructionPrinciple
	{
		[Column("PERCENT")]
		public decimal? PERCENT { get; set; }
		public bool ShouldSerializePERCENT() => PERCENT.HasValue;
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
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("PRICEABLE_UNIT_SEQ")]
		public decimal? PRICEABLE_UNIT_SEQ { get; set; }
		public bool ShouldSerializePRICEABLE_UNIT_SEQ() => PRICEABLE_UNIT_SEQ.HasValue;
		[Column("FARE_COMPONENT_DETAIL_SEQ")]
		public decimal? FARE_COMPONENT_DETAIL_SEQ { get; set; }
		public bool ShouldSerializeFARE_COMPONENT_DETAIL_SEQ() => FARE_COMPONENT_DETAIL_SEQ.HasValue;
		[Column("CONSTRUCTION_PRINCIPLE_SEQ")]
		public decimal? CONSTRUCTION_PRINCIPLE_SEQ { get; set; }
		public bool ShouldSerializeCONSTRUCTION_PRINCIPLE_SEQ() => CONSTRUCTION_PRINCIPLE_SEQ.HasValue;
		[Column("CONST_PRIC_IND_CD")]
		public string CONST_PRIC_IND_CD { get; set; }
		[Column("ORIGIN_CITY_CD")]
		public string ORIGIN_CITY_CD { get; set; }
		[Column("DESTINATION_CITY_CD")]
		public string DESTINATION_CITY_CD { get; set; }
		[Column("AMOUNT")]
		public decimal? AMOUNT { get; set; }
		public bool ShouldSerializeAMOUNT() => AMOUNT.HasValue;
	}
}