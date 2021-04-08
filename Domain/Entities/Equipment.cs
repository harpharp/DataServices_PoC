using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class Equipment
	{
		[Column("ITINERARY_ID")]
		public decimal? ITINERARY_ID { get; set; }
		public bool ShouldSerializeITINERARY_ID() => ITINERARY_ID.HasValue;
		[Column("SEG_SEQ")]
		public decimal? SEG_SEQ { get; set; }
		public bool ShouldSerializeSEG_SEQ() => SEG_SEQ.HasValue;
		[Column("EQUIPMENT_SEQ")]
		public decimal? EQUIPMENT_SEQ { get; set; }
		public bool ShouldSerializeEQUIPMENT_SEQ() => EQUIPMENT_SEQ.HasValue;
		[Column("AIR_EQUIPMENT_TYPE")]
		public string AIR_EQUIPMENT_TYPE { get; set; }
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