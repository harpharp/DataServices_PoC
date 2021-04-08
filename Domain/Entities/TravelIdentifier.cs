using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class TravelIdentifier
	{
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("TRAVEL_IDENTIFIER_REF_CD")]
		public string TRAVEL_IDENTIFIER_REF_CD { get; set; }
		[Column("TRAVEL_IDENTIFIER_TYPE")]
		public string TRAVEL_IDENTIFIER_TYPE { get; set; }
		[Column("TRAVEL_DOCUMENT_ISSUER_CD")]
		public string TRAVEL_DOCUMENT_ISSUER_CD { get; set; }
		[Column("TRAVEL_DOCUMENT_ID_VAL")]
		public string TRAVEL_DOCUMENT_ID_VAL { get; set; }
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
		[Column("TRAVEL_IDENTIFIER_SEQ")]
		public decimal? TRAVEL_IDENTIFIER_SEQ { get; set; }
		public bool ShouldSerializeTRAVEL_IDENTIFIER_SEQ() => TRAVEL_IDENTIFIER_SEQ.HasValue;
		[Column("TRAVEL_DOCUMENT_ID_CONTEXT")]
		public string TRAVEL_DOCUMENT_ID_CONTEXT { get; set; }
		[Column("TRAVEL_DOCUM_ISSUER_CD_CONTEXT")]
		public string TRAVEL_DOCUM_ISSUER_CD_CONTEXT { get; set; }
		[Column("TRAVEL_IDENTIFIER_INSTANCE")]
		public string TRAVEL_IDENTIFIER_INSTANCE { get; set; }
		[Column("TRAVEL_DOCUMENT_ID_ENC")]
		public string TRAVEL_DOCUMENT_ID_ENC { get; set; }
		[Column("TRAVEL_DOCUMENT_ID_HASH")]
		public string TRAVEL_DOCUMENT_ID_HASH { get; set; }
	}
}