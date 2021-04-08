using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class CarrierFeeTaxFeeCharges
	{
		[Column("TFC_REISSUE_REFUND_IND_CD")]
		public string TFC_REISSUE_REFUND_IND_CD { get; set; }
		[Column("TFC_GROUP_ID")]
		public decimal? TFC_GROUP_ID { get; set; }
		public bool ShouldSerializeTFC_GROUP_ID() => TFC_GROUP_ID.HasValue;
		[Column("TFC_SEQ")]
		public decimal? TFC_SEQ { get; set; }
		public bool ShouldSerializeTFC_SEQ() => TFC_SEQ.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("TFC_AMT")]
		public decimal? TFC_AMT { get; set; }
		public bool ShouldSerializeTFC_AMT() => TFC_AMT.HasValue;
		[Column("TFC_CURRENCY_CD")]
		public string TFC_CURRENCY_CD { get; set; }
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
		[Column("TFC_EPC_CONVERSION_AMT")]
		public decimal? TFC_EPC_CONVERSION_AMT { get; set; }
		public bool ShouldSerializeTFC_EPC_CONVERSION_AMT() => TFC_EPC_CONVERSION_AMT.HasValue;
		[Column("TFC_LCL_CONVERSION_AMT")]
		public decimal? TFC_LCL_CONVERSION_AMT { get; set; }
		public bool ShouldSerializeTFC_LCL_CONVERSION_AMT() => TFC_LCL_CONVERSION_AMT.HasValue;
		[Column("TFC_QUALIFIER_CD")]
		public string TFC_QUALIFIER_CD { get; set; }
		[Column("TAX_APPLICATION_CD")]
		public string TAX_APPLICATION_CD { get; set; }
		[Column("FILED_TAX_TYPE")]
		public string FILED_TAX_TYPE { get; set; }
		[Column("TFC_IATA_COUNTRY_CD")]
		public string TFC_IATA_COUNTRY_CD { get; set; }
		[Column("TFC_TAX_TYPE")]
		public string TFC_TAX_TYPE { get; set; }
		[Column("TFC_FILED_AMT")]
		public decimal? TFC_FILED_AMT { get; set; }
		public bool ShouldSerializeTFC_FILED_AMT() => TFC_FILED_AMT.HasValue;
		[Column("TFC_FILED_CURRENCY_CD")]
		public string TFC_FILED_CURRENCY_CD { get; set; }
		[Column("TFC_CONVERSION_RATE")]
		public decimal? TFC_CONVERSION_RATE { get; set; }
		public bool ShouldSerializeTFC_CONVERSION_RATE() => TFC_CONVERSION_RATE.HasValue;
		[Column("TFC_USAGE_TXT")]
		public string TFC_USAGE_TXT { get; set; }
		[Column("AIRPORT_CD")]
		public string AIRPORT_CD { get; set; }
		[Column("SEG_ORIG_AIRPORT_CD")]
		public string SEG_ORIG_AIRPORT_CD { get; set; }
		[Column("SEG_DEST_AIRPORT_CD")]
		public string SEG_DEST_AIRPORT_CD { get; set; }
	}
}