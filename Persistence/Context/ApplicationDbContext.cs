using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.Context
{
	public class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }

		public DbSet<AmountDetailGroup> AmountDetailGroup { get; set; }
		public DbSet<AmountDetail> AmountDetail { get; set; }
		public DbSet<BaseFareAmountGroup> BaseFareAmountGroup { get; set; }
		public DbSet<BaseFareAmount> BaseFareAmount { get; set; }
		public DbSet<BookingReferenceGroup> BookingReferenceGroup { get; set; }
		public DbSet<BookingReference> BookingReference { get; set; }
		public DbSet<CarrierFee> CarrierFee { get; set; }
		public DbSet<CarrierFeeAmount> CarrierFeeAmount { get; set; }
		public DbSet<CarrierFeeFormofPayment> CarrierFeeFormofPayment { get; set; }
		public DbSet<ExchangedCouponGroup> ExchangedCouponGroup { get; set; }
		public DbSet<FormOfPaymentAttribute> FormOfPaymentAttribute { get; set; }
		public DbSet<CarrierFeeFormofPaymentGroup> CarrierFeeFormofPaymentGroup { get; set; }
		public DbSet<CarrierFeeTaxFeeChargesGroup> CarrierFeeTaxFeeChargesGroup { get; set; }
		public DbSet<CarrierFeeTaxFeeCharges> CarrierFeeTaxFeeCharges { get; set; }
		public DbSet<EMDBooklets> EMDBooklets { get; set; }
		public DbSet<EMDCoupons> EMDCoupons { get; set; }
		public DbSet<CouponAttributes> CouponAttributes { get; set; }
		public DbSet<CouponSegments> CouponSegments { get; set; }
		public DbSet<TaxFeeChargesGroup> TaxFeeChargesGroup { get; set; }
		public DbSet<EMDDetailsbyDocumentNumberRQ> EMDDetailsbyDocumentNumberRQ { get; set; }
		public DbSet<MessageRequest> MessageRequest { get; set; }
		public DbSet<EMDDetailsbyDocumentNumberRS> EMDDetailsbyDocumentNumberRS { get; set; }
		public DbSet<EMDDocumentDetail> EMDDocumentDetail { get; set; }
		public DbSet<MessageResult> MessageResult { get; set; }
		public DbSet<EMDItinerary> EMDItinerary { get; set; }
		public DbSet<Passenger> Passenger { get; set; }
		public DbSet<PurchaseTransaction> PurchaseTransaction { get; set; }
		public DbSet<Remark> Remark { get; set; }
		public DbSet<TransactionHistory> TransactionHistory { get; set; }
		public DbSet<TravelDocumentFormofPayments> TravelDocumentFormofPayments { get; set; }
		public DbSet<TravelSegments> TravelSegments { get; set; }
		public DbSet<EquivalentFareAmountGroup> EquivalentFareAmountGroup { get; set; }
		public DbSet<EquivalentFareAmount> EquivalentFareAmount { get; set; }
		public DbSet<ExchangedCoupon> ExchangedCoupon { get; set; }
		public DbSet<FareComponentDetail> FareComponentDetail { get; set; }
		public DbSet<ConstructionPrinciple> ConstructionPrinciple { get; set; }
		public DbSet<FareComponentCouponSeq> FareComponentCouponSeq { get; set; }
		public DbSet<TicketDesignator> TicketDesignator { get; set; }
		public DbSet<FormofPaymentGroup> FormofPaymentGroup { get; set; }
		public DbSet<FormofPayments> FormofPayments { get; set; }
		public DbSet<Commission> Commission { get; set; }
		public DbSet<CustomerLoyalty> CustomerLoyalty { get; set; }
		public DbSet<FareCategory> FareCategory { get; set; }
		public DbSet<FarePenalty> FarePenalty { get; set; }
		public DbSet<FareWaiver> FareWaiver { get; set; }
		public DbSet<PriceableUnit> PriceableUnit { get; set; }
		public DbSet<TotalConstructionAmountGroup> TotalConstructionAmountGroup { get; set; }
		public DbSet<TotalFareAmountGroup> TotalFareAmountGroup { get; set; }
		public DbSet<TravelIdentifier> TravelIdentifier { get; set; }
		public DbSet<UnstructuredFareCalcInfo> UnstructuredFareCalcInfo { get; set; }
		public DbSet<RefundExchange> RefundExchange { get; set; }
		public DbSet<FormOfRefund> FormOfRefund { get; set; }
		public DbSet<RefundExchangeCoupon> RefundExchangeCoupon { get; set; }
		public DbSet<RefundTaxFeeChargesGroup> RefundTaxFeeChargesGroup { get; set; }
		public DbSet<RefundTaxFeeCharges> RefundTaxFeeCharges { get; set; }
		public DbSet<TaxFeeCharges> TaxFeeCharges { get; set; }
		public DbSet<TotalConstructionAmount> TotalConstructionAmount { get; set; }
		public DbSet<TotalFareAmount> TotalFareAmount { get; set; }
		public DbSet<POS> POS { get; set; }
		public DbSet<TransactionHistoryCoupons> TransactionHistoryCoupons { get; set; }
		public DbSet<Equipment> Equipment { get; set; }
		public DbSet<IntermediateStop> IntermediateStop { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Model.SetMaxIdentifierLength(30);
			modelBuilder.Entity<AmountDetail>(x =>
				{
					x.ToTable("AMOUNT_DETAIL");
					x.HasKey(AmountDetailTable => new {
				AmountDetailTable.AMOUNT_DETAIL_GROUP_ID,
				AmountDetailTable.AMOUNT_SEQ,
				});
			});

			modelBuilder.Entity<BaseFareAmount>(x =>
				{
					x.ToTable("AMOUNT_DETAIL");
					x.HasKey(BaseFareAmountTable => new {
				BaseFareAmountTable.AMOUNT_DETAIL_GROUP_ID,
				BaseFareAmountTable.AMOUNT_SEQ,
				});
x.HasOne<AmountDetail>().WithOne().HasForeignKey<BaseFareAmount>(z => new { z.AMOUNT_DETAIL_GROUP_ID, z.AMOUNT_SEQ});
			});

			modelBuilder.Entity<BookingReference>(x =>
				{
					x.ToTable("BOOKING_REFERENCE");
					x.HasKey(BookingReferenceTable => new {
				BookingReferenceTable.BOOKING_REF_GROUP_ID,
				BookingReferenceTable.PNR_SEQ,
				});
			});

			modelBuilder.Entity<CarrierFeeAmount>(x =>
				{
					x.ToTable("CARRIER_FEE_AMOUNT");
					x.HasKey(CarrierFeeAmountTable => new {
				CarrierFeeAmountTable.PAX_ID,
				CarrierFeeAmountTable.CARRIER_FEE_SEQ,
				CarrierFeeAmountTable.CARRIER_FEE_AMOUNT_SEQ,
				});
			});

			modelBuilder.Entity<AmountDetailGroup>(x =>
				{
					x.ToTable("AMOUNT_DETAIL_GROUP");
					x.HasKey(AmountDetailGroupTable => new {
				AmountDetailGroupTable.AMOUNT_DETAIL_GROUP_ID,
				});
			});

			modelBuilder.Entity<ExchangedCouponGroup>(x =>
				{
					x.ToTable("EXCHANGED_COUPON_GROUP");
					x.HasKey(ExchangedCouponGroupTable => new {
				ExchangedCouponGroupTable.EXCH_DOC_CPN_GROUP_ID,
				});
			});

			modelBuilder.Entity<FormOfPaymentAttribute>(x =>
				{
					x.ToTable("FORM_OF_PAYMENT_ATTRIBUTE");
					x.HasKey(FormOfPaymentAttributeTable => new {
				FormOfPaymentAttributeTable.FOP_GROUP_ID,
				FormOfPaymentAttributeTable.FOP_SEQ,
				FormOfPaymentAttributeTable.FOP_ATTR_SEQ,
				});
			});

			modelBuilder.Entity<CarrierFeeFormofPayment>(x =>
				{
					x.ToTable("FORM_OF_PAYMENT");
					x.HasKey(CarrierFeeFormofPaymentTable => new {
				CarrierFeeFormofPaymentTable.FOP_GROUP_ID,
				CarrierFeeFormofPaymentTable.FOP_SEQ,
				});
x.HasOne<FormofPayments>().WithOne().HasForeignKey<CarrierFeeFormofPayment>(z => new { z.FOP_GROUP_ID, z.FOP_SEQ});
			});

			modelBuilder.Entity<CarrierFeeTaxFeeCharges>(x =>
				{
					x.ToTable("TAX_FEE_CHARGES");
					x.HasKey(CarrierFeeTaxFeeChargesTable => new {
				CarrierFeeTaxFeeChargesTable.TFC_GROUP_ID,
				CarrierFeeTaxFeeChargesTable.TFC_SEQ,
				});
x.HasOne<TaxFeeCharges>().WithOne().HasForeignKey<CarrierFeeTaxFeeCharges>(z => new { z.TFC_GROUP_ID, z.TFC_SEQ});
			});

			modelBuilder.Entity<EMDCoupons>(x =>
				{
					x.ToTable("COUPONS");
					x.HasKey(EMDCouponsTable => new {
				EMDCouponsTable.PRIMARY_DOCUMENT_NBR,
				EMDCouponsTable.PRIMARY_AIRLINE_CD,
				EMDCouponsTable.PRIMARY_ISSUE_DT,
				EMDCouponsTable.BOOKLET_DOCUMENT_NBR,
				EMDCouponsTable.CPN_NBR,
				});
			});

			modelBuilder.Entity<CouponAttributes>(x =>
				{
					x.ToTable("COUPON_TYPE_ATTRIBUTES");
					x.HasKey(CouponAttributesTable => new {
				CouponAttributesTable.PRIMARY_DOCUMENT_NBR,
				CouponAttributesTable.PRIMARY_AIRLINE_CD,
				CouponAttributesTable.PRIMARY_ISSUE_DT,
				CouponAttributesTable.BOOKLET_DOCUMENT_NBR,
				CouponAttributesTable.CPN_NBR,
				CouponAttributesTable.CPN_ATTRIBUTE_CD,
				});
			});

			modelBuilder.Entity<CouponSegments>(x =>
				{
					x.ToTable("COUPON_SEGMENTS");
					x.HasKey(CouponSegmentsTable => new {
				CouponSegmentsTable.PRIMARY_DOCUMENT_NBR,
				CouponSegmentsTable.PRIMARY_AIRLINE_CD,
				CouponSegmentsTable.PRIMARY_ISSUE_DT,
				CouponSegmentsTable.BOOKLET_DOCUMENT_NBR,
				CouponSegmentsTable.CPN_NBR,
				CouponSegmentsTable.ITINERARY_ID,
				CouponSegmentsTable.SEG_SEQ,
				});
			});

			modelBuilder.Entity<TaxFeeChargesGroup>(x =>
				{
					x.ToTable("TAX_FEE_CHARGES_GROUP");
					x.HasKey(TaxFeeChargesGroupTable => new {
				TaxFeeChargesGroupTable.TFC_GROUP_ID,
				});
			});

			modelBuilder.Entity<EMDDocumentDetail>(x =>
				{
					x.ToTable("TRAVEL_DOCUMENT");
					x.HasKey(EMDDocumentDetailTable => new {
				EMDDocumentDetailTable.PRIMARY_DOCUMENT_NBR,
				EMDDocumentDetailTable.PRIMARY_AIRLINE_CD,
				EMDDocumentDetailTable.PRIMARY_ISSUE_DT,
				});
			});

			modelBuilder.Entity<BookingReferenceGroup>(x =>
				{
					x.ToTable("BOOKING_REFERENCE_GROUP");
					x.HasKey(BookingReferenceGroupTable => new {
				BookingReferenceGroupTable.BOOKING_REF_GROUP_ID,
				});
			});

			modelBuilder.Entity<EMDBooklets>(x =>
				{
					x.ToTable("TRAVEL_DOCUMENT_BOOKLET");
					x.HasKey(EMDBookletsTable => new {
				EMDBookletsTable.PRIMARY_DOCUMENT_NBR,
				EMDBookletsTable.PRIMARY_AIRLINE_CD,
				EMDBookletsTable.PRIMARY_ISSUE_DT,
				EMDBookletsTable.BOOKLET_DOCUMENT_NBR,
				});
			});

			modelBuilder.Entity<EMDItinerary>(x =>
				{
					x.ToTable("ITINERARY");
					x.HasKey(EMDItineraryTable => new {
				EMDItineraryTable.ITINERARY_ID,
				});
			});

			modelBuilder.Entity<Passenger>(x =>
				{
					x.ToTable("PASSENGER");
					x.HasKey(PassengerTable => new {
				PassengerTable.PAX_ID,
				});
			});

			modelBuilder.Entity<PurchaseTransaction>(x =>
				{
					x.ToTable("PURCHASE_TRANSACTION");
					x.HasKey(PurchaseTransactionTable => new {
				PurchaseTransactionTable.PURCHASE_TXN_ID,
				});
			});

			modelBuilder.Entity<Remark>(x =>
				{
					x.ToTable("REMARK");
					x.HasKey(RemarkTable => new {
				RemarkTable.PRIMARY_DOCUMENT_NBR,
				RemarkTable.PRIMARY_AIRLINE_CD,
				RemarkTable.PRIMARY_ISSUE_DT,
				RemarkTable.REMARK_SEQ,
				});
			});

			modelBuilder.Entity<TransactionHistory>(x =>
				{
					x.ToTable("TRANSACTION_HISTORY");
					x.HasKey(TransactionHistoryTable => new {
				TransactionHistoryTable.TXN_HISTORY_ID,
				});
			});

			modelBuilder.Entity<TravelDocumentFormofPayments>(x =>
				{
					x.ToTable("TRAVEL_DOCUMENT_FOP");
					x.HasKey(TravelDocumentFormofPaymentsTable => new {
				TravelDocumentFormofPaymentsTable.PRIMARY_DOCUMENT_NBR,
				TravelDocumentFormofPaymentsTable.PRIMARY_AIRLINE_CD,
				TravelDocumentFormofPaymentsTable.PRIMARY_ISSUE_DT,
				TravelDocumentFormofPaymentsTable.FOP_GROUP_ID,
				TravelDocumentFormofPaymentsTable.FOP_SEQ,
				});
			});

			modelBuilder.Entity<TravelSegments>(x =>
				{
					x.ToTable("TRAVEL_SEGMENT");
					x.HasKey(TravelSegmentsTable => new {
				TravelSegmentsTable.ITINERARY_ID,
				TravelSegmentsTable.SEG_SEQ,
				});
			});

			modelBuilder.Entity<EquivalentFareAmount>(x =>
				{
					x.ToTable("AMOUNT_DETAIL");
					x.HasKey(EquivalentFareAmountTable => new {
				EquivalentFareAmountTable.AMOUNT_DETAIL_GROUP_ID,
				EquivalentFareAmountTable.AMOUNT_SEQ,
				});
x.HasOne<AmountDetail>().WithOne().HasForeignKey<EquivalentFareAmount>(z => new { z.AMOUNT_DETAIL_GROUP_ID, z.AMOUNT_SEQ});
			});

			modelBuilder.Entity<ExchangedCoupon>(x =>
				{
					x.ToTable("EXCHANGED_COUPON");
					x.HasKey(ExchangedCouponTable => new {
				ExchangedCouponTable.EXCH_DOC_CPN_GROUP_ID,
				ExchangedCouponTable.CPN_NBR,
				});
			});

			modelBuilder.Entity<BaseFareAmountGroup>(x =>
				{
					x.ToTable("AMOUNT_DETAIL_GROUP");
					x.HasKey(BaseFareAmountGroupTable => new {
				BaseFareAmountGroupTable.AMOUNT_DETAIL_GROUP_ID,
				});
x.HasOne<AmountDetailGroup>().WithOne().HasForeignKey<BaseFareAmountGroup>(z => new { z.AMOUNT_DETAIL_GROUP_ID});
			});

			modelBuilder.Entity<ConstructionPrinciple>(x =>
				{
					x.ToTable("CONSTRUCTION_PRINCIPLE");
					x.HasKey(ConstructionPrincipleTable => new {
				ConstructionPrincipleTable.PAX_ID,
				ConstructionPrincipleTable.PRICEABLE_UNIT_SEQ,
				ConstructionPrincipleTable.FARE_COMPONENT_DETAIL_SEQ,
				ConstructionPrincipleTable.CONSTRUCTION_PRINCIPLE_SEQ,
				});
			});

			modelBuilder.Entity<FareComponentCouponSeq>(x =>
				{
					x.ToTable("FARE_COMPONENT_COUPON_SEQ");
					x.HasKey(FareComponentCouponSeqTable => new {
				FareComponentCouponSeqTable.PAX_ID,
				FareComponentCouponSeqTable.PRICEABLE_UNIT_SEQ,
				FareComponentCouponSeqTable.FARE_COMPONENT_DETAIL_SEQ,
				FareComponentCouponSeqTable.FARE_COMPONENT_COUPON_SEQ_SEQ,
				});
			});

			modelBuilder.Entity<TicketDesignator>(x =>
				{
					x.ToTable("TICKET_DESIGNATOR");
					x.HasKey(TicketDesignatorTable => new {
				TicketDesignatorTable.PAX_ID,
				TicketDesignatorTable.PRICEABLE_UNIT_SEQ,
				TicketDesignatorTable.FARE_COMPONENT_DETAIL_SEQ,
				TicketDesignatorTable.TICKET_DESIGNATOR_SEQ,
				});
			});

			modelBuilder.Entity<FormofPayments>(x =>
				{
					x.ToTable("FORM_OF_PAYMENT");
					x.HasKey(FormofPaymentsTable => new {
				FormofPaymentsTable.FOP_GROUP_ID,
				FormofPaymentsTable.FOP_SEQ,
				});
			});

			modelBuilder.Entity<CarrierFee>(x =>
				{
					x.ToTable("CARRIER_FEE");
					x.HasKey(CarrierFeeTable => new {
				CarrierFeeTable.PAX_ID,
				CarrierFeeTable.CARRIER_FEE_SEQ,
				});
			});

			modelBuilder.Entity<CarrierFeeFormofPaymentGroup>(x =>
				{
					x.ToTable("FORM_OF_PAYMENT_GROUP");
					x.HasKey(CarrierFeeFormofPaymentGroupTable => new {
				CarrierFeeFormofPaymentGroupTable.FOP_GROUP_ID,
				});
x.HasOne<FormofPaymentGroup>().WithOne().HasForeignKey<CarrierFeeFormofPaymentGroup>(z => new { z.FOP_GROUP_ID});
			});

			modelBuilder.Entity<CarrierFeeTaxFeeChargesGroup>(x =>
				{
					x.ToTable("TAX_FEE_CHARGES_GROUP");
					x.HasKey(CarrierFeeTaxFeeChargesGroupTable => new {
				CarrierFeeTaxFeeChargesGroupTable.TFC_GROUP_ID,
				});
x.HasOne<TaxFeeChargesGroup>().WithOne().HasForeignKey<CarrierFeeTaxFeeChargesGroup>(z => new { z.TFC_GROUP_ID});
			});

			modelBuilder.Entity<Commission>(x =>
				{
					x.ToTable("COMMISSION");
					x.HasKey(CommissionTable => new {
				CommissionTable.COMMISSION_ID,
				});
			});

			modelBuilder.Entity<CustomerLoyalty>(x =>
				{
					x.ToTable("CUSTOMER_LOYALTY");
					x.HasKey(CustomerLoyaltyTable => new {
				CustomerLoyaltyTable.PAX_ID,
				CustomerLoyaltyTable.CUSTOMER_LOYALTY_SEQ,
				});
			});

			modelBuilder.Entity<EquivalentFareAmountGroup>(x =>
				{
					x.ToTable("AMOUNT_DETAIL_GROUP");
					x.HasKey(EquivalentFareAmountGroupTable => new {
				EquivalentFareAmountGroupTable.AMOUNT_DETAIL_GROUP_ID,
				});
x.HasOne<AmountDetailGroup>().WithOne().HasForeignKey<EquivalentFareAmountGroup>(z => new { z.AMOUNT_DETAIL_GROUP_ID});
			});

			modelBuilder.Entity<FareCategory>(x =>
				{
					x.ToTable("FARE_CATEGORY");
					x.HasKey(FareCategoryTable => new {
				FareCategoryTable.PAX_ID,
				FareCategoryTable.FARE_CATEGORY_SEQ,
				});
			});

			modelBuilder.Entity<FarePenalty>(x =>
				{
					x.ToTable("FARE_PENALTY");
					x.HasKey(FarePenaltyTable => new {
				FarePenaltyTable.PAX_ID,
				FarePenaltyTable.FARE_PENALTY_SEQ,
				});
			});

			modelBuilder.Entity<FareWaiver>(x =>
				{
					x.ToTable("FARE_WAIVER");
					x.HasKey(FareWaiverTable => new {
				FareWaiverTable.PAX_ID,
				FareWaiverTable.FARE_WAIVER_SEQ,
				});
			});

			modelBuilder.Entity<PriceableUnit>(x =>
				{
					x.ToTable("PRICEABLE_UNIT");
					x.HasKey(PriceableUnitTable => new {
				PriceableUnitTable.PAX_ID,
				PriceableUnitTable.PRICEABLE_UNIT_SEQ,
				});
			});

			modelBuilder.Entity<TotalConstructionAmountGroup>(x =>
				{
					x.ToTable("AMOUNT_DETAIL_GROUP");
					x.HasKey(TotalConstructionAmountGroupTable => new {
				TotalConstructionAmountGroupTable.AMOUNT_DETAIL_GROUP_ID,
				});
x.HasOne<AmountDetailGroup>().WithOne().HasForeignKey<TotalConstructionAmountGroup>(z => new { z.AMOUNT_DETAIL_GROUP_ID});
			});

			modelBuilder.Entity<TotalFareAmountGroup>(x =>
				{
					x.ToTable("AMOUNT_DETAIL_GROUP");
					x.HasKey(TotalFareAmountGroupTable => new {
				TotalFareAmountGroupTable.AMOUNT_DETAIL_GROUP_ID,
				});
x.HasOne<AmountDetailGroup>().WithOne().HasForeignKey<TotalFareAmountGroup>(z => new { z.AMOUNT_DETAIL_GROUP_ID});
			});

			modelBuilder.Entity<TravelIdentifier>(x =>
				{
					x.ToTable("TRAVEL_IDENTIFIER");
					x.HasKey(TravelIdentifierTable => new {
				TravelIdentifierTable.PAX_ID,
				TravelIdentifierTable.TRAVEL_IDENTIFIER_SEQ,
				});
			});

			modelBuilder.Entity<UnstructuredFareCalcInfo>(x =>
				{
					x.ToTable("UNSTRUCTURED_FARE_CALC_INFO");
					x.HasKey(UnstructuredFareCalcInfoTable => new {
				UnstructuredFareCalcInfoTable.PAX_ID,
				UnstructuredFareCalcInfoTable.UFCI_SEQ,
				});
			});

			modelBuilder.Entity<FareComponentDetail>(x =>
				{
					x.ToTable("FARE_COMPONENT_DETAIL");
					x.HasKey(FareComponentDetailTable => new {
				FareComponentDetailTable.PAX_ID,
				FareComponentDetailTable.PRICEABLE_UNIT_SEQ,
				FareComponentDetailTable.FARE_COMPONENT_DETAIL_SEQ,
				});
			});

			modelBuilder.Entity<FormofPaymentGroup>(x =>
				{
					x.ToTable("FORM_OF_PAYMENT_GROUP");
					x.HasKey(FormofPaymentGroupTable => new {
				FormofPaymentGroupTable.FOP_GROUP_ID,
				});
			});

			modelBuilder.Entity<FormOfRefund>(x =>
				{
					x.ToTable("FORM_OF_REFUND");
					x.HasKey(FormOfRefundTable => new {
				FormOfRefundTable.FORM_OF_REFUND_ID,
				});
			});

			modelBuilder.Entity<RefundExchangeCoupon>(x =>
				{
					x.ToTable("REFUND_EXCHANGE_COUPONS");
					x.HasKey(RefundExchangeCouponTable => new {
				RefundExchangeCouponTable.TXN_HISTORY_ID,
				RefundExchangeCouponTable.PRIMARY_AIRLINE_CD,
				RefundExchangeCouponTable.PRIMARY_DOCUMENT_NBR,
				RefundExchangeCouponTable.PRIMARY_ISSUE_DT,
				RefundExchangeCouponTable.BOOKLET_DOCUMENT_NBR,
				RefundExchangeCouponTable.CPN_NBR,
				});
			});

			modelBuilder.Entity<RefundTaxFeeChargesGroup>(x =>
				{
					x.ToTable("RFND_EXCH_TAX_FEE_CHARGES_GRP");
					x.HasKey(RefundTaxFeeChargesGroupTable => new {
				RefundTaxFeeChargesGroupTable.RFND_EXCH_TFC_GROUP_ID,
				});
			});

			modelBuilder.Entity<RefundTaxFeeCharges>(x =>
				{
					x.ToTable("RFND_EXCH_TAX_FEE_CHARGES");
					x.HasKey(RefundTaxFeeChargesTable => new {
				RefundTaxFeeChargesTable.RFND_EXCH_TFC_GROUP_ID,
				RefundTaxFeeChargesTable.RFND_EXCH_TFC_SEQ,
				});
			});

			modelBuilder.Entity<TaxFeeCharges>(x =>
				{
					x.ToTable("TAX_FEE_CHARGES");
					x.HasKey(TaxFeeChargesTable => new {
				TaxFeeChargesTable.TFC_GROUP_ID,
				TaxFeeChargesTable.TFC_SEQ,
				});
			});

			modelBuilder.Entity<TotalConstructionAmount>(x =>
				{
					x.ToTable("AMOUNT_DETAIL");
					x.HasKey(TotalConstructionAmountTable => new {
				TotalConstructionAmountTable.AMOUNT_DETAIL_GROUP_ID,
				TotalConstructionAmountTable.AMOUNT_SEQ,
				});
x.HasOne<AmountDetail>().WithOne().HasForeignKey<TotalConstructionAmount>(z => new { z.AMOUNT_DETAIL_GROUP_ID, z.AMOUNT_SEQ});
			});

			modelBuilder.Entity<TotalFareAmount>(x =>
				{
					x.ToTable("AMOUNT_DETAIL");
					x.HasKey(TotalFareAmountTable => new {
				TotalFareAmountTable.AMOUNT_DETAIL_GROUP_ID,
				TotalFareAmountTable.AMOUNT_SEQ,
				});
x.HasOne<AmountDetail>().WithOne().HasForeignKey<TotalFareAmount>(z => new { z.AMOUNT_DETAIL_GROUP_ID, z.AMOUNT_SEQ});
			});

			modelBuilder.Entity<POS>(x =>
				{
					x.ToTable("POS");
					x.HasKey(POSTable => new {
				POSTable.TXN_HISTORY_ID,
				POSTable.POS_SEQ,
				});
			});

			modelBuilder.Entity<RefundExchange>(x =>
				{
					x.ToTable("REFUND_EXCHANGE");
					x.HasKey(RefundExchangeTable => new {
				RefundExchangeTable.TXN_HISTORY_ID,
				});
			});

			modelBuilder.Entity<TransactionHistoryCoupons>(x =>
				{
					x.ToTable("TRANSACTION_HISTORY_COUPONS");
					x.HasKey(TransactionHistoryCouponsTable => new {
				TransactionHistoryCouponsTable.TXN_HISTORY_ID,
				TransactionHistoryCouponsTable.PRIMARY_AIRLINE_CD,
				TransactionHistoryCouponsTable.PRIMARY_DOCUMENT_NBR,
				TransactionHistoryCouponsTable.PRIMARY_ISSUE_DT,
				TransactionHistoryCouponsTable.BOOKLET_DOCUMENT_NBR,
				TransactionHistoryCouponsTable.CPN_NBR,
				});
			});

			modelBuilder.Entity<Equipment>(x =>
				{
					x.ToTable("EQUIPMENT");
					x.HasKey(EquipmentTable => new {
				EquipmentTable.ITINERARY_ID,
				EquipmentTable.SEG_SEQ,
				EquipmentTable.EQUIPMENT_SEQ,
				});
			});

			modelBuilder.Entity<IntermediateStop>(x =>
				{
					x.ToTable("INTERMEDIATE_STOP");
					x.HasKey(IntermediateStopTable => new {
				IntermediateStopTable.ITINERARY_ID,
				IntermediateStopTable.SEG_SEQ,
				IntermediateStopTable.STOP_SEQ,
				});
			});

			modelBuilder.Entity<Domain.Entities.EMDDetailsbyDocumentNumberRQ>().HasNoKey();
			modelBuilder.Entity<Domain.Entities.EMDDetailsbyDocumentNumberRS>().HasNoKey();
			modelBuilder.Entity<Domain.Entities.MessageRequest>().HasNoKey();
			modelBuilder.Entity<Domain.Entities.MessageResult>().HasNoKey();
		}

		public async Task<int> SaveChangesAsync()
		{
			return await base.SaveChangesAsync();		}
	}
}