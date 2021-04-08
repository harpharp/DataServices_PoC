using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class EMDDocumentDetail
	{
		[Column("PURGE_STATUS_UPDATE_DT")]
		public DateTime? PURGE_STATUS_UPDATE_DT { get; set; }
		public bool ShouldSerializePURGE_STATUS_UPDATE_DT() => PURGE_STATUS_UPDATE_DT.HasValue;
		[Column("PRIMARY_EMD_DOCUMENT_NBR")]
		public string PRIMARY_EMD_DOCUMENT_NBR { get; set; }
		[Column("PURGE_STATUS_FLAG")]
		public decimal? PURGE_STATUS_FLAG { get; set; }
		public bool ShouldSerializePURGE_STATUS_FLAG() => PURGE_STATUS_FLAG.HasValue;
		[Column("PRIMARY_AIRLINE_CD")]
		public string PRIMARY_AIRLINE_CD { get; set; }
		[Column("PRIMARY_DOCUMENT_NBR")]
		public string PRIMARY_DOCUMENT_NBR { get; set; }
		[Column("PRIMARY_ISSUE_DT")]
		public DateTime? PRIMARY_ISSUE_DT { get; set; }
		public bool ShouldSerializePRIMARY_ISSUE_DT() => PRIMARY_ISSUE_DT.HasValue;
		[Column("HOST_AIRLINE_CD")]
		public string HOST_AIRLINE_CD { get; set; }
		[Column("DOCUMENT_TYPE_CD")]
		public string DOCUMENT_TYPE_CD { get; set; }
		[Column("DOCUMENT_SUB_TYPE_CD")]
		public string DOCUMENT_SUB_TYPE_CD { get; set; }
		[Column("DOCUMENT_BOOKLET_CNT")]
		public decimal? DOCUMENT_BOOKLET_CNT { get; set; }
		public bool ShouldSerializeDOCUMENT_BOOKLET_CNT() => DOCUMENT_BOOKLET_CNT.HasValue;
		[Column("PAX_ID")]
		public decimal? PAX_ID { get; set; }
		public bool ShouldSerializePAX_ID() => PAX_ID.HasValue;
		[Column("REASON_FOR_ISSUANCE_CD")]
		public string REASON_FOR_ISSUANCE_CD { get; set; }
		[Column("ORIGINAL_ISSUE_DT")]
		public DateTime? ORIGINAL_ISSUE_DT { get; set; }
		public bool ShouldSerializeORIGINAL_ISSUE_DT() => ORIGINAL_ISSUE_DT.HasValue;
		[Column("ITINERARY_ID")]
		public decimal? ITINERARY_ID { get; set; }
		public bool ShouldSerializeITINERARY_ID() => ITINERARY_ID.HasValue;
		[Column("TICKETING_MODE_IND")]
		public string TICKETING_MODE_IND { get; set; }
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
		[Column("FOP_GROUP_ID")]
		public decimal? FOP_GROUP_ID { get; set; }
		public bool ShouldSerializeFOP_GROUP_ID() => FOP_GROUP_ID.HasValue;
		[Column("DOCUMENT_ORPHAN_FLAG")]
		public string DOCUMENT_ORPHAN_FLAG { get; set; }
		[Column("SSR_UPDATE_TIME")]
		public DateTime? SSR_UPDATE_TIME { get; set; }
		public bool ShouldSerializeSSR_UPDATE_TIME() => SSR_UPDATE_TIME.HasValue;
		[Column("ACO_UPDATE_TIME")]
		public DateTime? ACO_UPDATE_TIME { get; set; }
		public bool ShouldSerializeACO_UPDATE_TIME() => ACO_UPDATE_TIME.HasValue;
		[Column("PURCHASE_TXN_ID")]
		public decimal? PURCHASE_TXN_ID { get; set; }
		public bool ShouldSerializePURCHASE_TXN_ID() => PURCHASE_TXN_ID.HasValue;
		[Column("ORIGINAL_ISSUING_AGENT_CD")]
		public string ORIGINAL_ISSUING_AGENT_CD { get; set; }
		[Column("ORIGINAL_ISSUE_LOC")]
		public string ORIGINAL_ISSUE_LOC { get; set; }
		[Column("ORIGINAL_DOCUMENT_NBR")]
		public string ORIGINAL_DOCUMENT_NBR { get; set; }
		[Column("IATA_PRESENT_TO_NM")]
		public string IATA_PRESENT_TO_NM { get; set; }
		[Column("IATA_PRESENT_AT_TXT")]
		public string IATA_PRESENT_AT_TXT { get; set; }
		[Column("EXCHANGE_DOCUMENT_NBR_FLAG")]
		public string EXCHANGE_DOCUMENT_NBR_FLAG { get; set; }
		[Column("COMMISSION_FLAG")]
		public string COMMISSION_FLAG { get; set; }
		[Column("ORIGIN_CITY_CD")]
		public string ORIGIN_CITY_CD { get; set; }
		[Column("DESTINATION_CITY_CD")]
		public string DESTINATION_CITY_CD { get; set; }
		[Column("ISSUING_AGENCY_AIRLINE_NM")]
		public string ISSUING_AGENCY_AIRLINE_NM { get; set; }
		[Column("ISSUING_AGENCY_AIRLINE_LOC")]
		public string ISSUING_AGENCY_AIRLINE_LOC { get; set; }
		[Column("PNR_VALIDATING_AIRLINE_CD")]
		public string PNR_VALIDATING_AIRLINE_CD { get; set; }
		[Column("ISSUING_COMPANY_CD")]
		public string ISSUING_COMPANY_CD { get; set; }
		[Column("ISSUING_IATA_LOCATION_CD")]
		public string ISSUING_IATA_LOCATION_CD { get; set; }
		[Column("IN_CONNECTION_DOC_NBR")]
		public string IN_CONNECTION_DOC_NBR { get; set; }
		[Column("INTERLINEABLE_FLAG")]
		public string INTERLINEABLE_FLAG { get; set; }
		[Column("EMD_ISSUER_TYPE_CD")]
		public string EMD_ISSUER_TYPE_CD { get; set; }
		[Column("BOOKING_REF_GROUP_ID")]
		public decimal? BOOKING_REF_GROUP_ID { get; set; }
		public bool ShouldSerializeBOOKING_REF_GROUP_ID() => BOOKING_REF_GROUP_ID.HasValue;
		[Column("ROUTING_DOM_INT_CD")]
		public string ROUTING_DOM_INT_CD { get; set; }
		[Column("LCL_PRIMARY_ISSUE_DT")]
		public DateTime? LCL_PRIMARY_ISSUE_DT { get; set; }
		public bool ShouldSerializeLCL_PRIMARY_ISSUE_DT() => LCL_PRIMARY_ISSUE_DT.HasValue;
		[Column("EXCHANGE_RESIDUAL_COUNT")]
		public decimal? EXCHANGE_RESIDUAL_COUNT { get; set; }
		public bool ShouldSerializeEXCHANGE_RESIDUAL_COUNT() => EXCHANGE_RESIDUAL_COUNT.HasValue;
		[NotMapped]
		[XmlElement]
		public List<PurchaseTransaction> PurchaseTransaction { get; set; } = new List<PurchaseTransaction>();
		public bool ShouldSerializePurchaseTransaction() => PurchaseTransaction.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<EMDBooklets> EMDBooklets { get; set; } = new List<EMDBooklets>();
		public bool ShouldSerializeEMDBooklets() => EMDBooklets.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<EMDItinerary> EMDItinerary { get; set; } = new List<EMDItinerary>();
		public bool ShouldSerializeEMDItinerary() => EMDItinerary.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<Passenger> Passenger { get; set; } = new List<Passenger>();
		public bool ShouldSerializePassenger() => Passenger.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TravelDocumentFormofPayments> TravelDocumentFormofPayments { get; set; } = new List<TravelDocumentFormofPayments>();
		public bool ShouldSerializeTravelDocumentFormofPayments() => TravelDocumentFormofPayments.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<TransactionHistory> TransactionHistory { get; set; } = new List<TransactionHistory>();
		public bool ShouldSerializeTransactionHistory() => TransactionHistory.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<Remark> Remark { get; set; } = new List<Remark>();
		public bool ShouldSerializeRemark() => Remark.Count > 0;
		[NotMapped]
		[XmlElement]
		public List<BookingReferenceGroup> BookingReferenceGroup { get; set; } = new List<BookingReferenceGroup>();
		public bool ShouldSerializeBookingReferenceGroup() => BookingReferenceGroup.Count > 0;
	}
}