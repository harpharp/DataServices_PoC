using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class POS
	{
		[Column("TXN_HISTORY_ID")]
		public decimal? TXN_HISTORY_ID { get; set; }
		public bool ShouldSerializeTXN_HISTORY_ID() => TXN_HISTORY_ID.HasValue;
		[Column("POS_SEQ")]
		public decimal? POS_SEQ { get; set; }
		public bool ShouldSerializePOS_SEQ() => POS_SEQ.HasValue;
		[Column("USER_ID")]
		public string USER_ID { get; set; }
		[Column("USER_NAME")]
		public string USER_NAME { get; set; }
		[Column("USER_ROLE")]
		public string USER_ROLE { get; set; }
		[Column("AGENT_SINE")]
		public string AGENT_SINE { get; set; }
		[Column("PSEUDO_CITY_CD")]
		public string PSEUDO_CITY_CD { get; set; }
		[Column("ISO_COUNTRY_CD")]
		public string ISO_COUNTRY_CD { get; set; }
		[Column("ISO_CURRENCY_CD")]
		public string ISO_CURRENCY_CD { get; set; }
		[Column("AGENT_DUTY_CD")]
		public string AGENT_DUTY_CD { get; set; }
		[Column("AIRLINE_VENDOR_ID")]
		public string AIRLINE_VENDOR_ID { get; set; }
		[Column("AIRPORT_CD")]
		public string AIRPORT_CD { get; set; }
		[Column("REQUESTOR_ID")]
		public string REQUESTOR_ID { get; set; }
		[Column("REQUESTOR_ID_TYPE")]
		public string REQUESTOR_ID_TYPE { get; set; }
		[Column("IATA_LOCATION_CD")]
		public string IATA_LOCATION_CD { get; set; }
		[Column("ISSUING_AIRLINE_NM")]
		public string ISSUING_AIRLINE_NM { get; set; }
		[Column("ISSUING_AIRELINE_PLACE")]
		public string ISSUING_AIRELINE_PLACE { get; set; }
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
		[Column("REQUESTOR_ID_CONTEXT")]
		public string REQUESTOR_ID_CONTEXT { get; set; }
		[Column("ISSUING_COMPANY_CD")]
		public string ISSUING_COMPANY_CD { get; set; }
		[Column("POS_COMPANY_NM_CD_CONTEXT")]
		public string POS_COMPANY_NM_CD_CONTEXT { get; set; }
		[Column("ISSUING_COMPANY_NM")]
		public string ISSUING_COMPANY_NM { get; set; }
		[Column("POS_IATA_LOCATION_CD")]
		public string POS_IATA_LOCATION_CD { get; set; }
		[Column("TERMINAL_ID")]
		public string TERMINAL_ID { get; set; }
	}
}