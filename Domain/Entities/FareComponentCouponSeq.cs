using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class FareComponentCouponSeq
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
		[Column("FARE_COMPONENT_COUPON_SEQ_SEQ")]
		public decimal? FARE_COMPONENT_COUPON_SEQ_SEQ { get; set; }
		public bool ShouldSerializeFARE_COMPONENT_COUPON_SEQ_SEQ() => FARE_COMPONENT_COUPON_SEQ_SEQ.HasValue;
		[Column("COUPON_ITINERARY_SEQ_NUM")]
		public decimal? COUPON_ITINERARY_SEQ_NUM { get; set; }
		public bool ShouldSerializeCOUPON_ITINERARY_SEQ_NUM() => COUPON_ITINERARY_SEQ_NUM.HasValue;
		[Column("SEQUENCE_NUM")]
		public string SEQUENCE_NUM { get; set; }
		[Column("ORIGIN_CITY_CD")]
		public string ORIGIN_CITY_CD { get; set; }
		[Column("DESTINATION_CITY_CD")]
		public string DESTINATION_CITY_CD { get; set; }
		[Column("STOPOVER_IND")]
		public string STOPOVER_IND { get; set; }
		[Column("AIRLINE_DESIGNATOR_CD")]
		public string AIRLINE_DESIGNATOR_CD { get; set; }
		[Column("RES_BOOK_DESIG_CD")]
		public string RES_BOOK_DESIG_CD { get; set; }
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