using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class PriceableUnit
	{
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("PRICEABLE_UNIT_SEQ")]
		public decimal? PRICEABLE_UNIT_SEQ { get; set; }
		public bool ShouldSerializePRICEABLE_UNIT_SEQ() => PRICEABLE_UNIT_SEQ.HasValue;
		[Column("PRICEABLE_UNIT_NUM")]
		public decimal? PRICEABLE_UNIT_NUM { get; set; }
		public bool ShouldSerializePRICEABLE_UNIT_NUM() => PRICEABLE_UNIT_NUM.HasValue;
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
		[NotMapped]
		[XmlElement]
		public List<FareComponentDetail> FareComponentDetail { get; set; } = new List<FareComponentDetail>();
		public bool ShouldSerializeFareComponentDetail() => FareComponentDetail.Count > 0;
	}
}