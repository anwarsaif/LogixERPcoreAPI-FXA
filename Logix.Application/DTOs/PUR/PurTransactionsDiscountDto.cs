using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public partial class PurTransactionsDiscountDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public string? BillCode { get; set; }
        public string? SupplierCode { get; set; }
        public string? CostCenterCode { get; set; }
        public int? BranchId { get; set; }
        public long? TransactionId { get; set; }
        public long? PeriodId { get; set; }
        public string? DiscountDate { get; set; }
        public string? DiscountDate2 { get; set; }
        public decimal? DiscountAmount { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? Description { get; set; }
        public decimal? Vat { get; set; }
        public decimal? VatAmount { get; set; }
        public int? FacilityId { get; set; }
        public decimal? DiscountRate { get; set; }
        public long? DiscountType { get; set; }
        public long? CcId { get; set; }
        public decimal? BillAmount { get; set; }
    }
    public partial class PurTransactionsDiscountCMFilterDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public string? BillCode { get; set; }
        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }
        public int? BranchId { get; set; }
        public long? TransactionId { get; set; }
        public long? ProjectCode { get; set; }
        public string? DiscountDate { get; set; }
        public string? DiscountDate2 { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? Description { get; set; }
        public decimal? Vat { get; set; }
        public decimal? VatAmount { get; set; }
        public int? FacilityId { get; set; }
        public decimal? DiscountRate { get; set; }
        public long? DiscountType { get; set; }
        public long? CcId { get; set; }
        public decimal? BillAmount { get; set; }
    }
    public partial class PurTransactionsDiscountEditDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? BranchId { get; set; }
        public long? TransactionId { get; set; }
        public string? DiscountDate { get; set; }
        public string? DiscountDate2 { get; set; }
        public decimal? DiscountAmount { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? Description { get; set; }
        public decimal? Vat { get; set; }
        public decimal? VatAmount { get; set; }
        public int? FacilityId { get; set; }
        public decimal? DiscountRate { get; set; }
        public long? DiscountType { get; set; }
        public long? CcId { get; set; }
        public decimal? BillAmount { get; set; }
    }
    public class PurTransactionNoCodeDiscountDto
    {
        public int? No { get; set; }
        public string? Code { get; set; }
    }
}
