using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class Commission
	{
		[Column("COMMISSION_ID")]
		public decimal? COMMISSION_ID { get; set; }
		public bool ShouldSerializeCOMMISSION_ID() => COMMISSION_ID.HasValue;
		[Column("COMMISSION_TYPE")]
		public string COMMISSION_TYPE { get; set; }
		[Column("COMMISSION_AMT")]
		public decimal? COMMISSION_AMT { get; set; }
		public bool ShouldSerializeCOMMISSION_AMT() => COMMISSION_AMT.HasValue;
		[Column("COMMISSION_CURRENCY_CD")]
		public string COMMISSION_CURRENCY_CD { get; set; }
		[Column("COMMISSION_PERCENTAGE")]
		public decimal? COMMISSION_PERCENTAGE { get; set; }
		public bool ShouldSerializeCOMMISSION_PERCENTAGE() => COMMISSION_PERCENTAGE.HasValue;
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