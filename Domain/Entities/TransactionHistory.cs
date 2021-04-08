using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class TransactionHistory
	{
		[Column("TXN_HISTORY_ID")]
		public decimal? TXN_HISTORY_ID { get; set; }
		public bool ShouldSerializeTXN_HISTORY_ID() => TXN_HISTORY_ID.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("APPLICATION_CD")]
		public string APPLICATION_CD { get; set; }
		[Column("TXN_TYPE_CD")]
		public string TXN_TYPE_CD { get; set; }
		[Column("TXN_REF")]
		public string TXN_REF { get; set; }
		[Column("TXN_DT")]
		public DateTime? TXN_DT { get; set; }
		public bool ShouldSerializeTXN_DT() => TXN_DT.HasValue;
		[Column("CRS_ACTION_FLAG")]
		public string CRS_ACTION_FLAG { get; set; }
		[Column("ACO_ACTION_FLAG")]
		public string ACO_ACTION_FLAG { get; set; }
		[Column("TXN_DETAIL_TXT")]
		public string TXN_DETAIL_TXT { get; set; }
		[Column("PRIMARY_AIRLINE_CD")]
		public string PRIMARY_AIRLINE_CD { get; set; }
		[Column("PRIMARY_DOCUMENT_NBR")]
		public string PRIMARY_DOCUMENT_NBR { get; set; }
		[Column("PRIMARY_ISSUE_DT")]
		public DateTime? PRIMARY_ISSUE_DT { get; set; }
		public bool ShouldSerializePRIMARY_ISSUE_DT() => PRIMARY_ISSUE_DT.HasValue;
		[Column("TRAVEL_DOCUMENT_VER_NBR")]
		public decimal? TRAVEL_DOCUMENT_VER_NBR { get; set; }
		public bool ShouldSerializeTRAVEL_DOCUMENT_VER_NBR() => TRAVEL_DOCUMENT_VER_NBR.HasValue;
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
		[Column("TICKET_ISSUANCE_ORIGINATOR_CD")]
		public string TICKET_ISSUANCE_ORIGINATOR_CD { get; set; }
		[Column("TICKET_HANDLER_AIRLINE_CD")]
		public string TICKET_HANDLER_AIRLINE_CD { get; set; }
		[Column("SALES_REPORT_ID")]
		public decimal? SALES_REPORT_ID { get; set; }
		public bool ShouldSerializeSALES_REPORT_ID() => SALES_REPORT_ID.HasValue;
		[Column("DISH_HANDOFF_DT")]
		public DateTime? DISH_HANDOFF_DT { get; set; }
		public bool ShouldSerializeDISH_HANDOFF_DT() => DISH_HANDOFF_DT.HasValue;
		[Column("DISH_HANDOFF_ID")]
		public decimal? DISH_HANDOFF_ID { get; set; }
		public bool ShouldSerializeDISH_HANDOFF_ID() => DISH_HANDOFF_ID.HasValue;
		[Column("ECR_HANDOFF_DT")]
		public DateTime? ECR_HANDOFF_DT { get; set; }
		public bool ShouldSerializeECR_HANDOFF_DT() => ECR_HANDOFF_DT.HasValue;
		[Column("ECR_HANDOFF_ID")]
		public decimal? ECR_HANDOFF_ID { get; set; }
		public bool ShouldSerializeECR_HANDOFF_ID() => ECR_HANDOFF_ID.HasValue;
		[Column("PNR_RECORD_LOCATOR")]
		public string PNR_RECORD_LOCATOR { get; set; }
		[Column("SALES_REPORTING_REQUIRED_IND")]
		public string SALES_REPORTING_REQUIRED_IND { get; set; }
		[Column("EXCH_TO_AIRLINE_CD")]
		public string EXCH_TO_AIRLINE_CD { get; set; }
		[Column("EXCH_TO_DOCUMENT_NBR")]
		public string EXCH_TO_DOCUMENT_NBR { get; set; }
		[Column("RESIDUAL_TO_AIRLINE_CD")]
		public string RESIDUAL_TO_AIRLINE_CD { get; set; }
		[Column("RESIDUAL_TO_DOCUMENT_NBR")]
		public string RESIDUAL_TO_DOCUMENT_NBR { get; set; }
		[Column("TXN_HISTORY_SEQ")]
		public decimal? TXN_HISTORY_SEQ { get; set; }
		public bool ShouldSerializeTXN_HISTORY_SEQ() => TXN_HISTORY_SEQ.HasValue;
		[NotMapped]
		[XmlElement]
		public List<POS> POS { get; set; } = new List<POS>();
		public bool ShouldSerializePOS() => POS.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TransactionHistoryCoupons> TransactionHistoryCoupons { get; set; } = new List<TransactionHistoryCoupons>();
		public bool ShouldSerializeTransactionHistoryCoupons() => TransactionHistoryCoupons.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<RefundExchange> RefundExchange { get; set; } = new List<RefundExchange>();
		public bool ShouldSerializeRefundExchange() => RefundExchange.Count > 0;
	}
}