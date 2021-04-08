using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class TravelDocumentFormofPayments
	{
		[Column("PRIMARY_DOCUMENT_NBR")]
		public string PRIMARY_DOCUMENT_NBR { get; set; }
		[Column("PRIMARY_AIRLINE_CD")]
		public string PRIMARY_AIRLINE_CD { get; set; }
		[Column("PRIMARY_ISSUE_DT")]
		public DateTime? PRIMARY_ISSUE_DT { get; set; }
		public bool ShouldSerializePRIMARY_ISSUE_DT() => PRIMARY_ISSUE_DT.HasValue;
		[Column("FOP_GROUP_ID")]
		public decimal? FOP_GROUP_ID { get; set; }
		public bool ShouldSerializeFOP_GROUP_ID() => FOP_GROUP_ID.HasValue;
		[Column("FOP_SEQ")]
		public decimal? FOP_SEQ { get; set; }
		public bool ShouldSerializeFOP_SEQ() => FOP_SEQ.HasValue;
		[Column("DIRECTLY_ASSOCIATED_IND")]
		public string DIRECTLY_ASSOCIATED_IND { get; set; }
		[Column("ROW_OBJECT_ID")]
		public string ROW_OBJECT_ID { get; set; }
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
	}
}