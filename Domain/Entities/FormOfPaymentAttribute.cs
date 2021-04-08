using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class FormOfPaymentAttribute
	{
		[Column("FOP_GROUP_ID")]
		public decimal? FOP_GROUP_ID { get; set; }
		public bool ShouldSerializeFOP_GROUP_ID() => FOP_GROUP_ID.HasValue;
		[Column("FOP_SEQ")]
		public decimal? FOP_SEQ { get; set; }
		public bool ShouldSerializeFOP_SEQ() => FOP_SEQ.HasValue;
		[Column("FOP_ATTR_SEQ")]
		public decimal? FOP_ATTR_SEQ { get; set; }
		public bool ShouldSerializeFOP_ATTR_SEQ() => FOP_ATTR_SEQ.HasValue;
		[Column("PAYMENT_NM")]
		public string PAYMENT_NM { get; set; }
		[Column("PAYMENT_VAL")]
		public string PAYMENT_VAL { get; set; }
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