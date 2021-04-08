using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class EMDItinerary
	{
		[Column("ITINERARY_ID")]
		public decimal? ITINERARY_ID { get; set; }
		public bool ShouldSerializeITINERARY_ID() => ITINERARY_ID.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("ENDORSEMENTS1_TXT")]
		public string ENDORSEMENTS1_TXT { get; set; }
		[Column("TOUR_CD_NBR")]
		public string TOUR_CD_NBR { get; set; }
		[Column("TFC_GROUP_ID")]
		public decimal? TFC_GROUP_ID { get; set; }
		public bool ShouldSerializeTFC_GROUP_ID() => TFC_GROUP_ID.HasValue;
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
		[Column("ITINERARY_AMT")]
		public decimal? ITINERARY_AMT { get; set; }
		public bool ShouldSerializeITINERARY_AMT() => ITINERARY_AMT.HasValue;
		[Column("ITINERARY_CURRENCY_CD")]
		public string ITINERARY_CURRENCY_CD { get; set; }
		[Column("ITINERARY_EPC_CONVERSION_RATE")]
		public decimal? ITINERARY_EPC_CONVERSION_RATE { get; set; }
		public bool ShouldSerializeITINERARY_EPC_CONVERSION_RATE() => ITINERARY_EPC_CONVERSION_RATE.HasValue;
		[Column("ITINERARY_CONVERSION_TYPE")]
		public string ITINERARY_CONVERSION_TYPE { get; set; }
		[Column("ITINERARY_EPC_CONVERSION_AMT")]
		public decimal? ITINERARY_EPC_CONVERSION_AMT { get; set; }
		public bool ShouldSerializeITINERARY_EPC_CONVERSION_AMT() => ITINERARY_EPC_CONVERSION_AMT.HasValue;
		[Column("ITINERARY_LCL_CONVERSION_RATE")]
		public decimal? ITINERARY_LCL_CONVERSION_RATE { get; set; }
		public bool ShouldSerializeITINERARY_LCL_CONVERSION_RATE() => ITINERARY_LCL_CONVERSION_RATE.HasValue;
		[Column("ITINERARY_LCL_CONVERSION_AMT")]
		public decimal? ITINERARY_LCL_CONVERSION_AMT { get; set; }
		public bool ShouldSerializeITINERARY_LCL_CONVERSION_AMT() => ITINERARY_LCL_CONVERSION_AMT.HasValue;
		[Column("ISSUING_COUNTRY_CD")]
		public string ISSUING_COUNTRY_CD { get; set; }
		[Column("ITINERARY_REMAINING_AMT")]
		public decimal? ITINERARY_REMAINING_AMT { get; set; }
		public bool ShouldSerializeITINERARY_REMAINING_AMT() => ITINERARY_REMAINING_AMT.HasValue;
		[NotMapped]
		[XmlElement]
		public List<TaxFeeChargesGroup> TaxFeeChargesGroup { get; set; } = new List<TaxFeeChargesGroup>();
		public bool ShouldSerializeTaxFeeChargesGroup() => TaxFeeChargesGroup.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TravelSegments> TravelSegments { get; set; } = new List<TravelSegments>();
		public bool ShouldSerializeTravelSegments() => TravelSegments.Count > 0;
	}
}