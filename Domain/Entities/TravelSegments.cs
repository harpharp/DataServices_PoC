using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class TravelSegments
	{
		[Column("STOP_QTY")]
		public decimal? STOP_QTY { get; set; }
		public bool ShouldSerializeSTOP_QTY() => STOP_QTY.HasValue;
		[Column("SEAT_NBR")]
		public string SEAT_NBR { get; set; }
		[Column("MARKETING_FLIGHT_NBR")]
		public string MARKETING_FLIGHT_NBR { get; set; }
		[Column("ITINERARY_ID")]
		public decimal? ITINERARY_ID { get; set; }
		public bool ShouldSerializeITINERARY_ID() => ITINERARY_ID.HasValue;
		[Column("SEG_SEQ")]
		public decimal? SEG_SEQ { get; set; }
		public bool ShouldSerializeSEG_SEQ() => SEG_SEQ.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("MARKETING_CARRIER_CD")]
		public string MARKETING_CARRIER_CD { get; set; }
		[Column("OPERATING_CARRIER_CD")]
		public string OPERATING_CARRIER_CD { get; set; }
		[Column("OPERATING_FLIGHT_NBR")]
		public string OPERATING_FLIGHT_NBR { get; set; }
		[Column("FLIGHT_DT")]
		public DateTime? FLIGHT_DT { get; set; }
		public bool ShouldSerializeFLIGHT_DT() => FLIGHT_DT.HasValue;
		[Column("SEG_DEPARTURE_DT")]
		public DateTime? SEG_DEPARTURE_DT { get; set; }
		public bool ShouldSerializeSEG_DEPARTURE_DT() => SEG_DEPARTURE_DT.HasValue;
		[Column("SEG_ARRIVAL_DT")]
		public DateTime? SEG_ARRIVAL_DT { get; set; }
		public bool ShouldSerializeSEG_ARRIVAL_DT() => SEG_ARRIVAL_DT.HasValue;
		[Column("DEPARTURE_AIRPORT_CD")]
		public string DEPARTURE_AIRPORT_CD { get; set; }
		[Column("ARRIVAL_AIRPORT_CD")]
		public string ARRIVAL_AIRPORT_CD { get; set; }
		[Column("BOOKED_CLASS_OF_SERVICE_CD")]
		public string BOOKED_CLASS_OF_SERVICE_CD { get; set; }
		[Column("TICKET_DESIGNATOR_CD")]
		public string TICKET_DESIGNATOR_CD { get; set; }
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
		[Column("STOPOVER_CD")]
		public string STOPOVER_CD { get; set; }
		[NotMapped]
		[XmlElement]
		public List<Equipment> Equipment { get; set; } = new List<Equipment>();
		public bool ShouldSerializeEquipment() => Equipment.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<IntermediateStop> IntermediateStop { get; set; } = new List<IntermediateStop>();
		public bool ShouldSerializeIntermediateStop() => IntermediateStop.Count > 0;
	}
}