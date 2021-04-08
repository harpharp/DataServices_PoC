using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class TransactionHistoryCoupons
	{
		[Column("TXN_HISTORY_ID")]
		public decimal? TXN_HISTORY_ID { get; set; }
		public bool ShouldSerializeTXN_HISTORY_ID() => TXN_HISTORY_ID.HasValue;
		[Column("PRIMARY_AIRLINE_CD")]
		public string PRIMARY_AIRLINE_CD { get; set; }
		[Column("PRIMARY_DOCUMENT_NBR")]
		public string PRIMARY_DOCUMENT_NBR { get; set; }
		[Column("PRIMARY_ISSUE_DT")]
		public DateTime? PRIMARY_ISSUE_DT { get; set; }
		public bool ShouldSerializePRIMARY_ISSUE_DT() => PRIMARY_ISSUE_DT.HasValue;
		[Column("BOOKLET_DOCUMENT_NBR")]
		public string BOOKLET_DOCUMENT_NBR { get; set; }
		[Column("CPN_NBR")]
		public decimal? CPN_NBR { get; set; }
		public bool ShouldSerializeCPN_NBR() => CPN_NBR.HasValue;
		[Column("PRIOR_IATA_CPN_STATUS_CD")]
		public string PRIOR_IATA_CPN_STATUS_CD { get; set; }
		[Column("IATA_CPN_STATUS_CD")]
		public string IATA_CPN_STATUS_CD { get; set; }
		[Column("FLIGHT_NBR")]
		public string FLIGHT_NBR { get; set; }
		[Column("FLIGHT_DT")]
		public DateTime? FLIGHT_DT { get; set; }
		public bool ShouldSerializeFLIGHT_DT() => FLIGHT_DT.HasValue;
		[Column("ARRIVAL_AIRPORT_CD")]
		public string ARRIVAL_AIRPORT_CD { get; set; }
		[Column("DEPARTURE_AIRPORT_CD")]
		public string DEPARTURE_AIRPORT_CD { get; set; }
		[Column("IN_CONNECTION_CPN_NBR")]
		public decimal? IN_CONNECTION_CPN_NBR { get; set; }
		public bool ShouldSerializeIN_CONNECTION_CPN_NBR() => IN_CONNECTION_CPN_NBR.HasValue;
		[Column("CPN_ASSOCIATE_FLAG")]
		public string CPN_ASSOCIATE_FLAG { get; set; }
		[Column("VOLUNTARY_INVOLUNTARY_IND")]
		public string VOLUNTARY_INVOLUNTARY_IND { get; set; }
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
		[Column("IN_CONNECTION_DOC_NBR")]
		public string IN_CONNECTION_DOC_NBR { get; set; }
		[Column("SETTLEMENT_AUTHORIZATION_CD")]
		public string SETTLEMENT_AUTHORIZATION_CD { get; set; }
		[Column("REASON_FOR_CHANGE")]
		public string REASON_FOR_CHANGE { get; set; }
		[Column("COMMENT_FOR_CHANGE")]
		public string COMMENT_FOR_CHANGE { get; set; }
		[Column("CONTROLLING_AIRLINE_CD")]
		public string CONTROLLING_AIRLINE_CD { get; set; }
	}
}