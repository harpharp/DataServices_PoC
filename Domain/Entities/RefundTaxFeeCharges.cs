using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class RefundTaxFeeCharges
	{
		[Column("RFND_EXCH_TFC_GROUP_ID")]
		public decimal? RFND_EXCH_TFC_GROUP_ID { get; set; }
		public bool ShouldSerializeRFND_EXCH_TFC_GROUP_ID() => RFND_EXCH_TFC_GROUP_ID.HasValue;
		[Column("RFND_EXCH_TFC_SEQ")]
		public decimal? RFND_EXCH_TFC_SEQ { get; set; }
		public bool ShouldSerializeRFND_EXCH_TFC_SEQ() => RFND_EXCH_TFC_SEQ.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("RFND_EXCH_TFC_AMT")]
		public decimal? RFND_EXCH_TFC_AMT { get; set; }
		public bool ShouldSerializeRFND_EXCH_TFC_AMT() => RFND_EXCH_TFC_AMT.HasValue;
		[Column("RFND_EXCH_TFC_CURRNCY_CD")]
		public string RFND_EXCH_TFC_CURRNCY_CD { get; set; }
		[Column("RFND_EXCH_TFC_EPC_CONVERSN_AMT")]
		public decimal? RFND_EXCH_TFC_EPC_CONVERSN_AMT { get; set; }
		public bool ShouldSerializeRFND_EXCH_TFC_EPC_CONVERSN_AMT() => RFND_EXCH_TFC_EPC_CONVERSN_AMT.HasValue;
		[Column("RFND_EXCH_TFC_LCL_CONVERSN_AMT")]
		public decimal? RFND_EXCH_TFC_LCL_CONVERSN_AMT { get; set; }
		public bool ShouldSerializeRFND_EXCH_TFC_LCL_CONVERSN_AMT() => RFND_EXCH_TFC_LCL_CONVERSN_AMT.HasValue;
		[Column("RFND_EXCH_TFC_QUALIFIER_CD")]
		public string RFND_EXCH_TFC_QUALIFIER_CD { get; set; }
		[Column("TAX_APPLICATION_CD")]
		public string TAX_APPLICATION_CD { get; set; }
		[Column("FILED_TAX_TYPE")]
		public string FILED_TAX_TYPE { get; set; }
		[Column("RFND_EXCH_TFC_IATA_COUNTRY_CD")]
		public string RFND_EXCH_TFC_IATA_COUNTRY_CD { get; set; }
		[Column("RFND_EXCH_TFC_TAX_TYPE")]
		public string RFND_EXCH_TFC_TAX_TYPE { get; set; }
		[Column("RFND_EXCH_TFC_FILED_AMT")]
		public decimal? RFND_EXCH_TFC_FILED_AMT { get; set; }
		public bool ShouldSerializeRFND_EXCH_TFC_FILED_AMT() => RFND_EXCH_TFC_FILED_AMT.HasValue;
		[Column("RFND_EXCH_TFC_FILED_CURRNCY_CD")]
		public string RFND_EXCH_TFC_FILED_CURRNCY_CD { get; set; }
		[Column("RFND_EXCH_TFC_CONVERSN_RATE")]
		public decimal? RFND_EXCH_TFC_CONVERSN_RATE { get; set; }
		public bool ShouldSerializeRFND_EXCH_TFC_CONVERSN_RATE() => RFND_EXCH_TFC_CONVERSN_RATE.HasValue;
		[Column("RFND_EXCH_TFC_USAGE_TXT")]
		public string RFND_EXCH_TFC_USAGE_TXT { get; set; }
		[Column("AIRPORT_CD")]
		public string AIRPORT_CD { get; set; }
		[Column("SEG_ORIG_AIRPORT_CD")]
		public string SEG_ORIG_AIRPORT_CD { get; set; }
		[Column("SEG_DEST_AIRPORT_CD")]
		public string SEG_DEST_AIRPORT_CD { get; set; }
		[Column("RFND_EXCH_TFC_REISS_REFND_IND")]
		public string RFND_EXCH_TFC_REISS_REFND_IND { get; set; }
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