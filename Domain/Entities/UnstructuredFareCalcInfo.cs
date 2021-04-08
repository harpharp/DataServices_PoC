using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class UnstructuredFareCalcInfo
	{
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
		[Column("UFCI_SEQ")]
		public decimal? UFCI_SEQ { get; set; }
		public bool ShouldSerializeUFCI_SEQ() => UFCI_SEQ.HasValue;
		[Column("PURPOSE_TYPE_NM")]
		public string PURPOSE_TYPE_NM { get; set; }
		[Column("PRICING_CD")]
		public string PRICING_CD { get; set; }
		[Column("REPORTING_CD")]
		public string REPORTING_CD { get; set; }
		[Column("FARE_CALC_AREA")]
		public string FARE_CALC_AREA { get; set; }
		[Column("INSERT_DT")]
		public DateTime? INSERT_DT { get; set; }
		public bool ShouldSerializeINSERT_DT() => INSERT_DT.HasValue;
	}
}