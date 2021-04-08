using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using MediatR;
using System.Threading;
using Domain.Entities;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Application.Features.ProductFeatures.Operation
{
	public class RetrieveEMDDetailsbyDocumentNumber : IRequest<EMDDetailsbyDocumentNumberRS>
	{
		public EMDDetailsbyDocumentNumberRQ EMDDetailsbyDocumentNumberRQ { get; set; }
		[XmlIgnore]
		 public Dictionary<string, string> filteredQueries;
		public class RetrieveEMDDetailsbyDocumentNumberHandler : IRequestHandler<RetrieveEMDDetailsbyDocumentNumber, EMDDetailsbyDocumentNumberRS> {
			private readonly IApplicationDbContext _context;
			public RetrieveEMDDetailsbyDocumentNumberHandler(IApplicationDbContext context)
			{
				_context = context;
			}

			public async Task<EMDDetailsbyDocumentNumberRS> Handle(RetrieveEMDDetailsbyDocumentNumber query, CancellationToken cancellationToken)
			{
				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();
				var reworkedQueries = new Dictionary<string, string>();
				foreach (var kvp in query.filteredQueries)
				{
					var item = kvp.Value;
					item = StringOperations.ParametrizeQuery(query.EMDDetailsbyDocumentNumberRQ, item);

					reworkedQueries.Add(kvp.Key, item);
				}

				AmountDetail AmountDetail = new AmountDetail();
				AmountDetailGroup AmountDetailGroup = new AmountDetailGroup();
				BaseFareAmount BaseFareAmount = new BaseFareAmount();
				BaseFareAmountGroup BaseFareAmountGroup = new BaseFareAmountGroup();
				BookingReference BookingReference = new BookingReference();
				BookingReferenceGroup BookingReferenceGroup = new BookingReferenceGroup();
				CarrierFee CarrierFee = new CarrierFee();
				CarrierFeeAmount CarrierFeeAmount = new CarrierFeeAmount();
				CarrierFeeFormofPayment CarrierFeeFormofPayment = new CarrierFeeFormofPayment();
				CarrierFeeFormofPaymentGroup CarrierFeeFormofPaymentGroup = new CarrierFeeFormofPaymentGroup();
				CarrierFeeTaxFeeCharges CarrierFeeTaxFeeCharges = new CarrierFeeTaxFeeCharges();
				CarrierFeeTaxFeeChargesGroup CarrierFeeTaxFeeChargesGroup = new CarrierFeeTaxFeeChargesGroup();
				Commission Commission = new Commission();
				ConstructionPrinciple ConstructionPrinciple = new ConstructionPrinciple();
				CouponAttributes CouponAttributes = new CouponAttributes();
				CouponSegments CouponSegments = new CouponSegments();
				CustomerLoyalty CustomerLoyalty = new CustomerLoyalty();
				EMDBooklets EMDBooklets = new EMDBooklets();
				EMDCoupons EMDCoupons = new EMDCoupons();
				EMDDetailsbyDocumentNumberRS EMDDetailsbyDocumentNumberRS = new EMDDetailsbyDocumentNumberRS();
				EMDDocumentDetail EMDDocumentDetail = new EMDDocumentDetail();
				EMDItinerary EMDItinerary = new EMDItinerary();
				Equipment Equipment = new Equipment();
				EquivalentFareAmount EquivalentFareAmount = new EquivalentFareAmount();
				EquivalentFareAmountGroup EquivalentFareAmountGroup = new EquivalentFareAmountGroup();
				ExchangedCoupon ExchangedCoupon = new ExchangedCoupon();
				ExchangedCouponGroup ExchangedCouponGroup = new ExchangedCouponGroup();
				FareCategory FareCategory = new FareCategory();
				FareComponentCouponSeq FareComponentCouponSeq = new FareComponentCouponSeq();
				FareComponentDetail FareComponentDetail = new FareComponentDetail();
				FarePenalty FarePenalty = new FarePenalty();
				FareWaiver FareWaiver = new FareWaiver();
				FormOfPaymentAttribute FormOfPaymentAttribute = new FormOfPaymentAttribute();
				FormofPaymentGroup FormofPaymentGroup = new FormofPaymentGroup();
				FormofPayments FormofPayments = new FormofPayments();
				FormOfRefund FormOfRefund = new FormOfRefund();
				IntermediateStop IntermediateStop = new IntermediateStop();
				MessageResult MessageResult = new MessageResult();
				Passenger Passenger = new Passenger();
				POS POS = new POS();
				PriceableUnit PriceableUnit = new PriceableUnit();
				PurchaseTransaction PurchaseTransaction = new PurchaseTransaction();
				RefundExchange RefundExchange = new RefundExchange();
				RefundExchangeCoupon RefundExchangeCoupon = new RefundExchangeCoupon();
				RefundTaxFeeCharges RefundTaxFeeCharges = new RefundTaxFeeCharges();
				RefundTaxFeeChargesGroup RefundTaxFeeChargesGroup = new RefundTaxFeeChargesGroup();
				Remark Remark = new Remark();
				TaxFeeCharges TaxFeeCharges = new TaxFeeCharges();
				TaxFeeChargesGroup TaxFeeChargesGroup = new TaxFeeChargesGroup();
				TicketDesignator TicketDesignator = new TicketDesignator();
				TotalConstructionAmount TotalConstructionAmount = new TotalConstructionAmount();
				TotalConstructionAmountGroup TotalConstructionAmountGroup = new TotalConstructionAmountGroup();
				TotalFareAmount TotalFareAmount = new TotalFareAmount();
				TotalFareAmountGroup TotalFareAmountGroup = new TotalFareAmountGroup();
				TransactionHistory TransactionHistory = new TransactionHistory();
				TransactionHistoryCoupons TransactionHistoryCoupons = new TransactionHistoryCoupons();
				TravelDocumentFormofPayments TravelDocumentFormofPayments = new TravelDocumentFormofPayments();
				TravelIdentifier TravelIdentifier = new TravelIdentifier();
				TravelSegments TravelSegments = new TravelSegments();
				UnstructuredFareCalcInfo UnstructuredFareCalcInfo = new UnstructuredFareCalcInfo();
				foreach (var loop1 in await _context.EMDDocumentDetail.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail"]).AsNoTracking().ToListAsync())
				{
					{
				foreach (var loop2 in await _context.PurchaseTransaction.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction"]).AsNoTracking().ToListAsync())
				{
					if ((loop2.PURCHASE_TXN_ID == loop1.PURCHASE_TXN_ID))
					{
						loop1.PurchaseTransaction.Add(loop2);
				foreach (var loop3 in await _context.FormofPaymentGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction.FormofPaymentGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.FOP_GROUP_ID == loop2.FOP_GROUP_ID))
					{
						loop2.FormofPaymentGroup.Add(loop3);
				foreach (var loop4 in await _context.FormofPayments.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction.FormofPaymentGroup.FormofPayments"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.FOP_GROUP_ID == loop3.FOP_GROUP_ID))
					{
						loop3.FormofPayments.Add(loop4);
				foreach (var loop5 in await _context.AmountDetailGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction.FormofPaymentGroup.FormofPayments.AmountDetailGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.AMOUNT_DETAIL_GROUP_ID == loop4.AMOUNT_DETAIL_GROUP_ID))
					{
						loop4.AmountDetailGroup.Add(loop5);
				foreach (var loop6 in await _context.AmountDetail.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction.FormofPaymentGroup.FormofPayments.AmountDetailGroup.AmountDetail"]).AsNoTracking().ToListAsync())
				{
					if ((loop6.AMOUNT_DETAIL_GROUP_ID == loop5.AMOUNT_DETAIL_GROUP_ID))
					{
						loop5.AmountDetail.Add(loop6);
				}
				}
				}
				}
				foreach (var loop5 in await _context.FormOfPaymentAttribute.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction.FormofPaymentGroup.FormofPayments.FormOfPaymentAttribute"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.FOP_GROUP_ID == loop4.FOP_GROUP_ID) && (loop5.FOP_SEQ == loop4.FOP_SEQ))
					{
						loop4.FormOfPaymentAttribute.Add(loop5);
					}
					}
				foreach (var loop5 in await _context.ExchangedCouponGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction.FormofPaymentGroup.FormofPayments.ExchangedCouponGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.EXCH_DOC_CPN_GROUP_ID == loop4.EXCH_DOC_CPN_GROUP_ID))
					{
						loop4.ExchangedCouponGroup.Add(loop5);
				foreach (var loop6 in await _context.ExchangedCoupon.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.PurchaseTransaction.FormofPaymentGroup.FormofPayments.ExchangedCouponGroup.ExchangedCoupon"]).AsNoTracking().ToListAsync())
				{
					if ((loop6.EXCH_DOC_CPN_GROUP_ID == loop5.EXCH_DOC_CPN_GROUP_ID))
					{
						loop5.ExchangedCoupon.Add(loop6);
										}
										}
										}
										}
										}
										}
										}
										}
										}
										}
				foreach (var loop2 in await _context.EMDBooklets.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDBooklets"]).AsNoTracking().ToListAsync())
				{
					if ((loop2.PRIMARY_AIRLINE_CD == loop1.PRIMARY_AIRLINE_CD) && (loop2.PRIMARY_DOCUMENT_NBR == loop1.PRIMARY_DOCUMENT_NBR) && (loop2.PRIMARY_ISSUE_DT == loop1.PRIMARY_ISSUE_DT))
					{
						loop1.EMDBooklets.Add(loop2);
				foreach (var loop3 in await _context.EMDCoupons.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDBooklets.EMDCoupons"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.BOOKLET_DOCUMENT_NBR == loop2.BOOKLET_DOCUMENT_NBR) && (loop3.PRIMARY_AIRLINE_CD == loop2.PRIMARY_AIRLINE_CD) && (loop3.PRIMARY_DOCUMENT_NBR == loop2.PRIMARY_DOCUMENT_NBR) && (loop3.PRIMARY_ISSUE_DT == loop2.PRIMARY_ISSUE_DT))
					{
						loop2.EMDCoupons.Add(loop3);
				foreach (var loop4 in await _context.CouponAttributes.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDBooklets.EMDCoupons.CouponAttributes"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.BOOKLET_DOCUMENT_NBR == loop3.BOOKLET_DOCUMENT_NBR) && (loop4.CPN_NBR == loop3.CPN_NBR) && (loop4.PRIMARY_AIRLINE_CD == loop3.PRIMARY_AIRLINE_CD) && (loop4.PRIMARY_DOCUMENT_NBR == loop3.PRIMARY_DOCUMENT_NBR) && (loop4.PRIMARY_ISSUE_DT == loop3.PRIMARY_ISSUE_DT))
					{
						loop3.CouponAttributes.Add(loop4);
				}
				}
				foreach (var loop4 in await _context.CouponSegments.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDBooklets.EMDCoupons.CouponSegments"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.BOOKLET_DOCUMENT_NBR == loop3.BOOKLET_DOCUMENT_NBR) && (loop4.CPN_NBR == loop3.CPN_NBR) && (loop4.PRIMARY_AIRLINE_CD == loop3.PRIMARY_AIRLINE_CD) && (loop4.PRIMARY_DOCUMENT_NBR == loop3.PRIMARY_DOCUMENT_NBR) && (loop4.PRIMARY_ISSUE_DT == loop3.PRIMARY_ISSUE_DT))
					{
						loop3.CouponSegments.Add(loop4);
				}
				}
				foreach (var loop4 in await _context.TaxFeeChargesGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDBooklets.EMDCoupons.TaxFeeChargesGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.TFC_GROUP_ID == loop3.TFC_GROUP_ID))
					{
						loop3.TaxFeeChargesGroup.Add(loop4);
				foreach (var loop5 in await _context.TaxFeeCharges.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDBooklets.EMDCoupons.TaxFeeChargesGroup.TaxFeeCharges"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.TFC_GROUP_ID == loop4.TFC_GROUP_ID))
					{
						loop4.TaxFeeCharges.Add(loop5);
								}
								}
								}
								}
								}
								}
								}
								}
				foreach (var loop2 in await _context.EMDItinerary.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDItinerary"]).AsNoTracking().ToListAsync())
				{
					if ((loop2.ITINERARY_ID == loop1.ITINERARY_ID))
					{
						loop1.EMDItinerary.Add(loop2);
				foreach (var loop3 in await _context.TaxFeeChargesGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDItinerary.TaxFeeChargesGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.TFC_GROUP_ID == loop2.TFC_GROUP_ID))
					{
						loop2.TaxFeeChargesGroup.Add(loop3);
				foreach (var loop4 in await _context.TaxFeeCharges.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDItinerary.TaxFeeChargesGroup.TaxFeeCharges"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.TFC_GROUP_ID == loop3.TFC_GROUP_ID))
					{
						loop3.TaxFeeCharges.Add(loop4);
				}
				}
				}
				}
				foreach (var loop3 in await _context.TravelSegments.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDItinerary.TravelSegments"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.ITINERARY_ID == loop2.ITINERARY_ID))
					{
						loop2.TravelSegments.Add(loop3);
				foreach (var loop4 in await _context.Equipment.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDItinerary.TravelSegments.Equipment"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.ITINERARY_ID == loop3.ITINERARY_ID) && (loop4.SEG_SEQ == loop3.SEG_SEQ))
					{
						loop3.Equipment.Add(loop4);
				}
				}
				foreach (var loop4 in await _context.IntermediateStop.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.EMDItinerary.TravelSegments.IntermediateStop"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.ITINERARY_ID == loop3.ITINERARY_ID) && (loop4.SEG_SEQ == loop3.SEG_SEQ))
					{
						loop3.IntermediateStop.Add(loop4);
						}
						}
						}
						}
						}
						}
				foreach (var loop2 in await _context.Passenger.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger"]).AsNoTracking().ToListAsync())
				{
					if ((loop2.PAX_ID == loop1.PAX_ID))
					{
						loop1.Passenger.Add(loop2);
				foreach (var loop3 in await _context.TravelIdentifier.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.TravelIdentifier"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.TravelIdentifier.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.FareCategory.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.FareCategory"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.FareCategory.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.FarePenalty.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.FarePenalty"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.FarePenalty.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.FareWaiver.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.FareWaiver"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.FareWaiver.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.BaseFareAmountGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.BaseFareAmountGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.AMOUNT_DETAIL_GROUP_ID == loop2.BASE_FARE_AD_GROUP_ID))
					{
						loop2.BaseFareAmountGroup.Add(loop3);
				foreach (var loop4 in await _context.BaseFareAmount.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.BaseFareAmountGroup.BaseFareAmount"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.AMOUNT_DETAIL_GROUP_ID == loop3.AMOUNT_DETAIL_GROUP_ID))
					{
						loop3.BaseFareAmount.Add(loop4);
				}
				}
				}
				}
				foreach (var loop3 in await _context.EquivalentFareAmountGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.EquivalentFareAmountGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.AMOUNT_DETAIL_GROUP_ID == loop2.EQUIVALENT_FARE_AD_GROUP_ID))
					{
						loop2.EquivalentFareAmountGroup.Add(loop3);
				foreach (var loop4 in await _context.EquivalentFareAmount.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.EquivalentFareAmountGroup.EquivalentFareAmount"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.AMOUNT_DETAIL_GROUP_ID == loop3.AMOUNT_DETAIL_GROUP_ID))
					{
						loop3.EquivalentFareAmount.Add(loop4);
				}
				}
				}
				}
				foreach (var loop3 in await _context.CarrierFee.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFee"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.CarrierFee.Add(loop3);
				foreach (var loop4 in await _context.CarrierFeeAmount.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFee.CarrierFeeAmount"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.CARRIER_FEE_SEQ == loop3.CARRIER_FEE_SEQ) && (loop4.PAX_ID == loop3.PAX_ID))
					{
						loop3.CarrierFeeAmount.Add(loop4);
				}
				}
				}
				}
				foreach (var loop3 in await _context.TotalFareAmountGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.TotalFareAmountGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.AMOUNT_DETAIL_GROUP_ID == loop2.TOTAL_FARE_AD_GROUP_ID))
					{
						loop2.TotalFareAmountGroup.Add(loop3);
				foreach (var loop4 in await _context.TotalFareAmount.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.TotalFareAmountGroup.TotalFareAmount"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.AMOUNT_DETAIL_GROUP_ID == loop3.AMOUNT_DETAIL_GROUP_ID))
					{
						loop3.TotalFareAmount.Add(loop4);
				}
				}
				}
				}
				foreach (var loop3 in await _context.CarrierFeeFormofPaymentGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeFormofPaymentGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.FOP_GROUP_ID == loop2.CARRIER_FEE_FOP_GROUP_ID))
					{
						loop2.CarrierFeeFormofPaymentGroup.Add(loop3);
				foreach (var loop4 in await _context.CarrierFeeFormofPayment.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeFormofPaymentGroup.CarrierFeeFormofPayment"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.FOP_GROUP_ID == loop3.FOP_GROUP_ID))
					{
						loop3.CarrierFeeFormofPayment.Add(loop4);
				foreach (var loop5 in await _context.AmountDetailGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeFormofPaymentGroup.CarrierFeeFormofPayment.AmountDetailGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.AMOUNT_DETAIL_GROUP_ID == loop4.AMOUNT_DETAIL_GROUP_ID))
					{
						loop4.AmountDetailGroup.Add(loop5);
				foreach (var loop6 in await _context.AmountDetail.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeFormofPaymentGroup.CarrierFeeFormofPayment.AmountDetailGroup.AmountDetail"]).AsNoTracking().ToListAsync())
				{
					if ((loop6.AMOUNT_DETAIL_GROUP_ID == loop5.AMOUNT_DETAIL_GROUP_ID))
					{
						loop5.AmountDetail.Add(loop6);
				}
				}
				}
				}
				foreach (var loop5 in await _context.FormOfPaymentAttribute.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeFormofPaymentGroup.CarrierFeeFormofPayment.FormOfPaymentAttribute"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.FOP_GROUP_ID == loop4.FOP_GROUP_ID) && (loop5.FOP_SEQ == loop4.FOP_SEQ))
					{
						loop4.FormOfPaymentAttribute.Add(loop5);
					}
					}
				foreach (var loop5 in await _context.ExchangedCouponGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeFormofPaymentGroup.CarrierFeeFormofPayment.ExchangedCouponGroup"]).AsNoTracking().ToListAsync())
				{
					{
						loop4.ExchangedCouponGroup.Add(loop5);
				foreach (var loop6 in await _context.ExchangedCoupon.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeFormofPaymentGroup.CarrierFeeFormofPayment.ExchangedCouponGroup.ExchangedCoupon"]).AsNoTracking().ToListAsync())
				{
					if ((loop6.EXCH_DOC_CPN_GROUP_ID == loop5.EXCH_DOC_CPN_GROUP_ID))
					{
						loop5.ExchangedCoupon.Add(loop6);
								}
								}
								}
								}
								}
								}
								}
								}
				foreach (var loop3 in await _context.Commission.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.Commission"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.COMMISSION_ID == loop2.COMMISSION_ID))
					{
						loop2.Commission.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.CarrierFeeTaxFeeChargesGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeTaxFeeChargesGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.TFC_GROUP_ID == loop2.CARRIER_FEE_TFC_GROUP_ID))
					{
						loop2.CarrierFeeTaxFeeChargesGroup.Add(loop3);
				foreach (var loop4 in await _context.CarrierFeeTaxFeeCharges.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CarrierFeeTaxFeeChargesGroup.CarrierFeeTaxFeeCharges"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.TFC_GROUP_ID == loop3.TFC_GROUP_ID))
					{
						loop3.CarrierFeeTaxFeeCharges.Add(loop4);
				}
				}
				}
				}
				foreach (var loop3 in await _context.CustomerLoyalty.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.CustomerLoyalty"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.CustomerLoyalty.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.PriceableUnit.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.PriceableUnit"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.PriceableUnit.Add(loop3);
				foreach (var loop4 in await _context.FareComponentDetail.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.PriceableUnit.FareComponentDetail"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.PAX_ID == loop3.PAX_ID) && (loop4.PRICEABLE_UNIT_SEQ == loop3.PRICEABLE_UNIT_SEQ))
					{
						loop3.FareComponentDetail.Add(loop4);
				foreach (var loop5 in await _context.FareComponentCouponSeq.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.PriceableUnit.FareComponentDetail.FareComponentCouponSeq"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.FARE_COMPONENT_DETAIL_SEQ == loop4.FARE_COMPONENT_DETAIL_SEQ) && (loop5.PAX_ID == loop4.PAX_ID) && (loop5.PRICEABLE_UNIT_SEQ == loop4.PRICEABLE_UNIT_SEQ))
					{
						loop4.FareComponentCouponSeq.Add(loop5);
					}
					}
				foreach (var loop5 in await _context.TicketDesignator.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.PriceableUnit.FareComponentDetail.TicketDesignator"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.FARE_COMPONENT_DETAIL_SEQ == loop4.FARE_COMPONENT_DETAIL_SEQ) && (loop5.PAX_ID == loop4.PAX_ID) && (loop5.PRICEABLE_UNIT_SEQ == loop4.PRICEABLE_UNIT_SEQ))
					{
						loop4.TicketDesignator.Add(loop5);
					}
					}
				foreach (var loop5 in await _context.ConstructionPrinciple.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.PriceableUnit.FareComponentDetail.ConstructionPrinciple"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.FARE_COMPONENT_DETAIL_SEQ == loop4.FARE_COMPONENT_DETAIL_SEQ) && (loop5.PAX_ID == loop4.PAX_ID) && (loop5.PRICEABLE_UNIT_SEQ == loop4.PRICEABLE_UNIT_SEQ))
					{
						loop4.ConstructionPrinciple.Add(loop5);
					}
					}
				foreach (var loop5 in await _context.BaseFareAmountGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.PriceableUnit.FareComponentDetail.BaseFareAmountGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.AMOUNT_DETAIL_GROUP_ID == loop4.BASE_AMOUNT_ID))
					{
						loop4.BaseFareAmountGroup.Add(loop5);
				foreach (var loop6 in await _context.BaseFareAmount.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.PriceableUnit.FareComponentDetail.BaseFareAmountGroup.BaseFareAmount"]).AsNoTracking().ToListAsync())
				{
					if ((loop6.AMOUNT_DETAIL_GROUP_ID == loop5.AMOUNT_DETAIL_GROUP_ID))
					{
						loop5.BaseFareAmount.Add(loop6);
								}
								}
								}
								}
								}
								}
								}
								}
				foreach (var loop3 in await _context.TotalConstructionAmountGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.TotalConstructionAmountGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.AMOUNT_DETAIL_GROUP_ID == loop2.TOTAL_CONST_AD_GROUP_ID))
					{
						loop2.TotalConstructionAmountGroup.Add(loop3);
				foreach (var loop4 in await _context.TotalConstructionAmount.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.TotalConstructionAmountGroup.TotalConstructionAmount"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.AMOUNT_DETAIL_GROUP_ID == loop3.AMOUNT_DETAIL_GROUP_ID))
					{
						loop3.TotalConstructionAmount.Add(loop4);
				}
				}
				}
				}
				foreach (var loop3 in await _context.UnstructuredFareCalcInfo.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Passenger.UnstructuredFareCalcInfo"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.PAX_ID == loop2.PAX_ID))
					{
						loop2.UnstructuredFareCalcInfo.Add(loop3);
				}
				}
				}
				}
				foreach (var loop2 in await _context.TravelDocumentFormofPayments.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TravelDocumentFormofPayments"]).AsNoTracking().ToListAsync())
				{
					if ((loop2.PRIMARY_AIRLINE_CD == loop1.PRIMARY_AIRLINE_CD) && (loop2.PRIMARY_DOCUMENT_NBR == loop1.PRIMARY_DOCUMENT_NBR) && (loop2.PRIMARY_ISSUE_DT == loop1.PRIMARY_ISSUE_DT))
					{
						loop1.TravelDocumentFormofPayments.Add(loop2);
		}
		}
				foreach (var loop2 in await _context.TransactionHistory.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory"]).AsNoTracking().ToListAsync())
				{
					if ((loop2.PRIMARY_AIRLINE_CD == loop1.PRIMARY_AIRLINE_CD) && (loop2.PRIMARY_DOCUMENT_NBR == loop1.PRIMARY_DOCUMENT_NBR))
					{
						loop1.TransactionHistory.Add(loop2);
				foreach (var loop3 in await _context.POS.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.POS"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.TXN_HISTORY_ID == loop2.TXN_HISTORY_ID))
					{
						loop2.POS.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.TransactionHistoryCoupons.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.TransactionHistoryCoupons"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.TXN_HISTORY_ID == loop2.TXN_HISTORY_ID))
					{
						loop2.TransactionHistoryCoupons.Add(loop3);
			}
			}
				foreach (var loop3 in await _context.RefundExchange.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.RefundExchange"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.TXN_HISTORY_ID == loop2.TXN_HISTORY_ID))
					{
						loop2.RefundExchange.Add(loop3);
				foreach (var loop4 in await _context.FormOfRefund.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.RefundExchange.FormOfRefund"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.TXN_HISTORY_ID == loop3.TXN_HISTORY_ID))
					{
						loop3.FormOfRefund.Add(loop4);
				}
				}
				foreach (var loop4 in await _context.RefundTaxFeeChargesGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.RefundExchange.RefundTaxFeeChargesGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.RFND_EXCH_TFC_GROUP_ID == loop3.RFND_EXCH_EMD_TFC_GROUP_ID))
					{
						loop3.RefundTaxFeeChargesGroup.Add(loop4);
				foreach (var loop5 in await _context.RefundTaxFeeCharges.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.RefundExchange.RefundTaxFeeChargesGroup.RefundTaxFeeCharges"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.RFND_EXCH_TFC_GROUP_ID == loop4.RFND_EXCH_TFC_GROUP_ID))
					{
						loop4.RefundTaxFeeCharges.Add(loop5);
				}
				}
				}
				}
				foreach (var loop4 in await _context.RefundExchangeCoupon.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.RefundExchange.RefundExchangeCoupon"]).AsNoTracking().ToListAsync())
				{
					if ((loop4.TXN_HISTORY_ID == loop3.TXN_HISTORY_ID))
					{
						loop3.RefundExchangeCoupon.Add(loop4);
				foreach (var loop5 in await _context.RefundTaxFeeChargesGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.RefundExchange.RefundExchangeCoupon.RefundTaxFeeChargesGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop5.RFND_EXCH_TFC_GROUP_ID == loop4.RFND_EXCH_CPN_TFC_GROUP_ID))
					{
						loop4.RefundTaxFeeChargesGroup.Add(loop5);
				foreach (var loop6 in await _context.RefundTaxFeeCharges.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.TransactionHistory.RefundExchange.RefundExchangeCoupon.RefundTaxFeeChargesGroup.RefundTaxFeeCharges"]).AsNoTracking().ToListAsync())
				{
					if ((loop6.RFND_EXCH_TFC_GROUP_ID == loop5.RFND_EXCH_TFC_GROUP_ID))
					{
						loop5.RefundTaxFeeCharges.Add(loop6);
										}
										}
										}
										}
										}
										}
										}
										}
										}
										}
				foreach (var loop2 in await _context.Remark.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Remark"]).AsNoTracking().ToListAsync())
				{
					{
						loop1.Remark.Add(loop2);
		}
		}
				foreach (var loop2 in await _context.BookingReferenceGroup.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.BookingReferenceGroup"]).AsNoTracking().ToListAsync())
				{
					if ((loop2.BOOKING_REF_GROUP_ID == loop1.BOOKING_REF_GROUP_ID))
					{
						loop1.BookingReferenceGroup.Add(loop2);
				foreach (var loop3 in await _context.BookingReference.FromSqlRaw(reworkedQueries["EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.BookingReferenceGroup.BookingReference"]).AsNoTracking().ToListAsync())
				{
					if ((loop3.BOOKING_REF_GROUP_ID == loop2.BOOKING_REF_GROUP_ID))
					{
						loop2.BookingReference.Add(loop3);
				}
				}
				}
					}
				}
				EMDDetailsbyDocumentNumberRS.EMDDocumentDetail.Add(loop1);
			}
				stopWatch.Stop();
				MessageResult.ResponseTime = stopWatch.ElapsedMilliseconds.ToString();
				EMDDetailsbyDocumentNumberRS.MessageResult.Add(MessageResult);
				return EMDDetailsbyDocumentNumberRS ?? null;
			}
		}
	}
}