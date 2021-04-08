using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
	public interface IApplicationDbContext
	{
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
		Task<int> SaveChangesAsync();
	}
}