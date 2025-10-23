using Logix.Application.DTOs.ACC;
using Logix.Application.DTOs.GB;
using Logix.Application.DTOs.Main;
using Logix.Application.DTOs.WH;
using Logix.Domain.ACC;
using Logix.Domain.PUR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurTransactionDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        public int? BranchId { get; set; }
        public string? VendorCode { get; set; }
        public long? VendorId { get; set; }
        public int? VendorType { get; set; }
        public long? RecipientId { get; set; }
        public string? RecipientName { get; set; }
        public string? Address { get; set; }
        public string? RefNumber { get; set; }
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        [Required]
        public string? DeliveryDate { get; set; }
        [Required]
        public string? ExpirationDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public decimal? Net { get; set; }
        public string? DeliveryContact { get; set; }
        [Required]
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        public long? RefranceId { get; set; }
        public int? InventoriesId { get; set; }
        public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? AppId { get; set; }
        public int? TypeId2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
        public string? Details3 { get; set; }
        public int? ContractType { get; set; }
        public bool? HasDownpayment { get; set; }
        public int? DownpaymentType { get; set; }
        public decimal? DownpaymentRate { get; set; }
        public decimal? DownpaymentAmount { get; set; }
        public string? RequestCode { get; set; }
        public string? ContractualPaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PeriodBillsDay { get; set; }
        public long? EmpId { get; set; }
        public long? TenderType { get; set; }
        public bool? SendtoSupplier { get; set; }
        public string? LastSubmissionDate { get; set; }
        public string? OpeningOffersDate { get; set; }
        public string? CheckingOffersDate { get; set; }
        public decimal? TenderValue { get; set; }
        [Required]
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PeriodExecution { get; set; }
        public string? Staff { get; set; }
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? ActivityFieldId { get; set; }
        public long? CommitteeId { get; set; }
        public int? RfqStutesId { get; set; }
        public string? Scope { get; set; }
        public string? LastInquiriesDate { get; set; }
        public int? QuotationId { get; set; }
        public string? QuotationCode { get; set; }
        public long? OrId { get; set; }
        public string? OrCode { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? ComparisonType { get; set; }
        public long? PoId { get; set; }
        public string? PoCode { get; set; }
        public string? EstimatedPrice { get; set; }
        public int? AgreementId { get; set; }
        public string? ProjectStartDate { get; set; }
        public string? ProjectEndDate { get; set; }
        public int? BillType { get; set; }
        public string? DueDate { get; set; }
        public long? ContractId { get; set; }
        public long? FinancYearId { get; set; }
        public int? MonthId { get; set; }
        public List<PurTransactionsProductDto>? Products { get; set; }
    }
    public class PurTransactionCMDto
    {
        public long? Id { get; set; }
        //public long? No { get; set; }
        //public string? Code { get; set; }
        //public int? TransTypeId { get; set; }
        public int? BranchId { get; set; }
        //public string? VendorCode { get; set; }
        //public long? VendorId { get; set; }
        //public int? VendorType { get; set; }
        //public long? RecipientId { get; set; }
        //public string? RecipientName { get; set; }
        //public string? Address { get; set; }
        //public string? RefNumber { get; set; }
        public string? Date1 { get; set; }
        //public string? Date2 { get; set; }
        //[Required]
        //public string? DeliveryDate { get; set; }
        //[Required]
        //public string? ExpirationDate { get; set; }
        //public int? PaymentTermsId { get; set; }
        //public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        //public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountNotice { get; set; }
        //public decimal? Amount { get; set; }
        //public decimal? TotalDiscount { get; set; }
        public decimal? AmountDiscount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        //public decimal? Net { get; set; }
        //public string? DeliveryContact { get; set; }
        //[Required]
        //public string? DeliveryAddress { get; set; }
        //public long? ProjectId { get; set; }
        //public string? ProjectCode { get; set; }
        //public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        //public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        //public long? RefranceId { get; set; }
        //public int? InventoriesId { get; set; }
        //public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        //public decimal? VatAmount { get; set; }
        //public long? AppId { get; set; }
        //public int? TypeId2 { get; set; }
        //public string? Details1 { get; set; }
        //public string? Details2 { get; set; }
        //public string? Details3 { get; set; }
        //public int? ContractType { get; set; }
        //public bool? HasDownpayment { get; set; }
        //public int? DownpaymentType { get; set; }
        //public decimal? DownpaymentRate { get; set; }
        //public decimal? DownpaymentAmount { get; set; }
        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }
        //public string? ContractualPaymentDate { get; set; }
        //public int? PaymentTypeId { get; set; }
        //public int? PeriodBillsDay { get; set; }
        //public long? EmpId { get; set; }
        //public long? TenderType { get; set; }
        //public bool? SendtoSupplier { get; set; }
        //public string? LastSubmissionDate { get; set; }
        //public string? OpeningOffersDate { get; set; }
        //public string? CheckingOffersDate { get; set; }
        //public decimal? TenderValue { get; set; }
        //[Required]
        //public string? Subject { get; set; }
        //public string? Description { get; set; }
        //public string? PaymentTerms { get; set; }
        //public string? PeriodExecution { get; set; }
        //public string? Staff { get; set; }
        //public string? SupplyStartDate { get; set; }
        //public string? SupplyEndDate { get; set; }
        //public int? ActivityFieldId { get; set; }
        //public long? CommitteeId { get; set; }
        //public int? RfqStutesId { get; set; }
        //public string? Scope { get; set; }
        //public string? LastInquiriesDate { get; set; }
        //public int? QuotationId { get; set; }
        //public string? QuotationCode { get; set; }
        //public long? OrId { get; set; }
        //public string? OrCode { get; set; }
        //public int? DurationType { get; set; }
        //public string? Duration { get; set; }
        //public int? ComparisonType { get; set; }
        //public long? PoId { get; set; }
        //public string? PoCode { get; set; }
        //public string? EstimatedPrice { get; set; }
        //public int? AgreementId { get; set; }
        //public string? ProjectStartDate { get; set; }
        //public string? ProjectEndDate { get; set; }
        //public int? BillType { get; set; }
        //public string? DueDate { get; set; }
        //public long? ContractId { get; set; }
        //public long? FinancYearId { get; set; }
        //public int? MonthId { get; set; }
        //public List<PurTransactionsProductDto>? Products { get; set; }
    }
    public class PurTransactionEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        public int? BranchId { get; set; }
        public long? VendorId { get; set; }
        public long? RecipientId { get; set; }
        public string? RecipientName { get; set; }
        public string? Address { get; set; }
        public string? RefNumber { get; set; }
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        public string? DeliveryDate { get; set; }
        public string? ExpirationDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? ProjectCode { get; set; }
        public long? ProjectId { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        public long? RefranceId { get; set; }
        public int? InventoriesId { get; set; }
        public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? AppId { get; set; }
        public int? TypeId2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
        public string? Details3 { get; set; }
        public int? ContractType { get; set; }
        public bool? HasDownpayment { get; set; }
        public int? DownpaymentType { get; set; }
        public decimal? DownpaymentRate { get; set; }
        public decimal? DownpaymentAmount { get; set; }
        public string? RequestCode { get; set; }
        public string? ContractualPaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PeriodBillsDay { get; set; }
        public long? EmpId { get; set; }
        public long? TenderType { get; set; }
        public bool? SendtoSupplier { get; set; }
        public string? LastSubmissionDate { get; set; }
        public string? OpeningOffersDate { get; set; }
        public string? CheckingOffersDate { get; set; }
        public decimal? TenderValue { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PeriodExecution { get; set; }
        public string? Staff { get; set; }
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? ActivityFieldId { get; set; }
        public long? CommitteeId { get; set; }
        public int? RfqStutesId { get; set; }
        public string? Scope { get; set; }
        public string? LastInquiriesDate { get; set; }
        public int? QuotationId { get; set; }
        public string? QuotationCode { get; set; }
        public long? OrId { get; set; }
        public string? OrCode { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? ComparisonType { get; set; }
        public long? PoId { get; set; }
        public string? PoCode { get; set; }
        public string? EstimatedPrice { get; set; }
        public int? AgreementId { get; set; }
        public string? ProjectStartDate { get; set; }
        public string? ProjectEndDate { get; set; }
        public int? BillType { get; set; }
        public string? DueDate { get; set; }
        public long? ContractId { get; set; }
        public long? FinancYearId { get; set; }
        public int? MonthId { get; set; }
        public List<PurTransactionsProductDto>? Products { get; set; }
        public List<PurTransactionsSupplierDto>? Suppliers { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionPRDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? DeliveryAddress { get; set; }
        [Required]
        public string? DeliveryDate { get; set; }
        [Required]
        public string? ExpirationDate { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? BranchId { get; set; }
        public int? InventoriesId { get; set; }
        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }
        public string? DocumentNote { get; set; }
        public long? AppId { get; set; }
        public long? FacilityId { get; set; }
        public string? PrivateNote { get; set; }

        public int? StatusId { get; set; } = 1;
        public int? TransTypeId { get; set; } = 6;
        public int? CurrencyId { get; set; } = 1;
        public decimal? ExchangeRate { get; set; } = 1;
        public int? TypeId2 { get; set; } = 1;


        public decimal? Total { get; set; }
        public long? VendorId { get; set; }
        public int? AppTypeId { get; set; } = 0;
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? Subtotal { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? RefNumber { get; set; }
        public bool IsDeleted { get; set; }
        public List<PurTransactionsProductDto>? Products { get; set; }
        public List<PurTransactionsSupplierDto>? Suppliers { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionEditPRDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? DeliveryAddress { get; set; }
        [Required]
        public string? DeliveryDate { get; set; }
        [Required]
        public string? ExpirationDate { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? BranchId { get; set; }
        public int? InventoriesId { get; set; }
        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }
        public string? DocumentNote { get; set; }
        public long? AppId { get; set; }
        public long? FacilityId { get; set; }
        public string? PrivateNote { get; set; }

        public int? StatusId { get; set; } = 1;
        public int? TransTypeId { get; set; } = 6;
        public int? CurrencyId { get; set; } = 1;
        public decimal? ExchangeRate { get; set; } = 1;
        public int? TypeId2 { get; set; } = 1;


        public decimal? Total { get; set; }
        public long? VendorId { get; set; }
        public int? AppTypeId { get; set; } = 0;
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? Subtotal { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? RefNumber { get; set; }
        public bool IsDeleted { get; set; }
        public List<PurTransactionsProductDto>? Products { get; set; }
        public List<PurTransactionsSupplierDto>? Suppliers { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionQDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        [Required]
        public int? BranchId { get; set; }
        [Required]
        public string? VendorCode { get; set; }
        [Required]
        public string? VendorName { get; set; }
        public long? VendorId { get; set; }
        public int? VendorType { get; set; }
        public long? RecipientId { get; set; }
        public string? RecipientName { get; set; }
        public string? Address { get; set; }
        [Required]
        public string? RefNumber { get; set; }
        [Required]
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        public string? DeliveryDate { get; set; }
        [Required]
        public string? ExpirationDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public decimal? Net { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        public long? RefranceId { get; set; }
        public int? InventoriesId { get; set; }
        public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? AppId { get; set; }
        public int? TypeId2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
        public string? Details3 { get; set; }
        public int? ContractType { get; set; }
        public bool? HasDownpayment { get; set; }
        public int? DownpaymentType { get; set; }
        public decimal? DownpaymentRate { get; set; }
        public decimal? DownpaymentAmount { get; set; }
        public string? RequestCode { get; set; }
        public string? ContractualPaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PeriodBillsDay { get; set; }
        public long? EmpId { get; set; }
        public long? TenderType { get; set; }
        public bool? SendtoSupplier { get; set; }
        public string? LastSubmissionDate { get; set; }
        public string? OpeningOffersDate { get; set; }
        public string? CheckingOffersDate { get; set; }
        public decimal? TenderValue { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PeriodExecution { get; set; }
        public string? Staff { get; set; }
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? ActivityFieldId { get; set; }
        public long? CommitteeId { get; set; }
        public int? RfqStutesId { get; set; }
        public string? Scope { get; set; }
        public string? LastInquiriesDate { get; set; }
        public int? QuotationId { get; set; }
        public string? QuotationCode { get; set; }
        public long? OrId { get; set; }
        public string? OrCode { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? ComparisonType { get; set; }
        public long? PoId { get; set; }
        public string? PoCode { get; set; }
        public string? EstimatedPrice { get; set; }
        public int? AgreementId { get; set; }
        public string? ProjectStartDate { get; set; }
        public string? ProjectEndDate { get; set; }
        public int? BillType { get; set; }
        public string? DueDate { get; set; }
        public long? ContractId { get; set; }
        public long? FinancYearId { get; set; }
        public int? MonthId { get; set; }
        public List<PurTransactionsProductDto> Products { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionEditQDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        public int? BranchId { get; set; }
        public long? VendorId { get; set; }
        public string? VendorCode { get; set; }
        public int? VendorType { get; set; }
        public long? RecipientId { get; set; }
        public string? RecipientName { get; set; }
        public string? Address { get; set; }
        public string? RefNumber { get; set; }
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        public string? DeliveryDate { get; set; }
        public string? ExpirationDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? ProjectCode { get; set; }
        public long? ProjectId { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        public long? RefranceId { get; set; }
        public int? InventoriesId { get; set; }
        public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? AppId { get; set; }
        public int? TypeId2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
        public string? Details3 { get; set; }
        public int? ContractType { get; set; }
        public bool? HasDownpayment { get; set; }
        public int? DownpaymentType { get; set; }
        public decimal? DownpaymentRate { get; set; }
        public decimal? DownpaymentAmount { get; set; }
        public string? RequestCode { get; set; }
        public string? ContractualPaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PeriodBillsDay { get; set; }
        public long? EmpId { get; set; }
        public long? TenderType { get; set; }
        public bool? SendtoSupplier { get; set; }
        public string? LastSubmissionDate { get; set; }
        public string? OpeningOffersDate { get; set; }
        public string? CheckingOffersDate { get; set; }
        public decimal? TenderValue { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PeriodExecution { get; set; }
        public string? Staff { get; set; }
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? ActivityFieldId { get; set; }
        public long? CommitteeId { get; set; }
        public int? RfqStutesId { get; set; }
        public string? Scope { get; set; }
        public string? LastInquiriesDate { get; set; }
        public int? QuotationId { get; set; }
        public string? QuotationCode { get; set; }
        public long? OrId { get; set; }
        public string? OrCode { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? ComparisonType { get; set; }
        public long? PoId { get; set; }
        public string? PoCode { get; set; }
        public string? EstimatedPrice { get; set; }
        public int? AgreementId { get; set; }
        public string? ProjectStartDate { get; set; }
        public string? ProjectEndDate { get; set; }
        public int? BillType { get; set; }
        public string? DueDate { get; set; }
        public long? ContractId { get; set; }
        public long? FinancYearId { get; set; }
        public int? MonthId { get; set; }
        public List<PurTransactionsProductDto>? Products { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionFilterDto
    {
        public string? Code { get; set; }
        //public int? TransTypeId { get; set; }
        public long? FacilityId { get; set; }
        public int? BranchId { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? ItemCode { get; set; }
        public string? ProductName { get; set; }
        public int? ConvertStatus { get; set; }
        public int? RequestStatus { get; set; }
        public int? InventoryId { get; set; }
        public string? EmpCode { get; set; }
        //  حقول غير موجودة في الشاشة
        public int? CusTypeId { get; set; }
        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }
        public long? PaymentTermsId { get; set; }
        public decimal? Subtotal { get; set; }
        public string? RefNumber { get; set; }
        //public int? IsConverted { get; set; }
        public int? RefranceId { get; set; }
        public long? ProjectId { get; set; }
        public string? RequestCode { get; set; }
        ///// <summary>
        ///// رقم المرجع لعرض الاسعار او اوامر الشراء
        ///// </summary>
        //public long? FacilityId { get; set; }
        //public string? RequestCode { get; set; }
        //public int? PaymentTypeId { get; set; }
        //public List<PurTransactionsProductDto> Products { get; set; }
        //public List<WhItemDto> items { get; set; }

        //public string? SupplyStartDate { get; set; }
        //public string? SupplyEndDate { get; set; }
        //public string? ProjectStartDate { get; set; }
        //public string? ProjectEndDate { get; set; }
        public string? Date1 { get; set; }
    }
    public class PurTransactionPODto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        [Required]
        public int? BranchId { get; set; }
        [Required]
        public string? VendorCode { get; set; }
        //[Required]
        public string? VendorName { get; set; }
        public long? VendorId { get; set; }
        public int? VendorType { get; set; }
        public long? RecipientId { get; set; }
        public string? RecipientName { get; set; }
        public string? Address { get; set; }
        //[Required]
        public string? RefNumber { get; set; }
        [Required]
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        public string? DeliveryDate { get; set; }
        //[Required]
        public string? ExpirationDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public decimal? Net { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        public long? RefranceId { get; set; }
        public int? InventoriesId { get; set; }
        public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? AppId { get; set; }
        public int? AppTypeId { get; set; }
        public int? TypeId2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
        public string? Details3 { get; set; }
        public int? ContractType { get; set; }
        public bool? HasDownpayment { get; set; }
        public int? DownpaymentType { get; set; }
        public decimal? DownpaymentRate { get; set; }
        public decimal? DownpaymentAmount { get; set; }
        public string? RequestCode { get; set; }
        public string? ContractualPaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PeriodBillsDay { get; set; }
        public long? EmpId { get; set; }
        public long? TenderType { get; set; }
        public bool? SendtoSupplier { get; set; }
        public string? LastSubmissionDate { get; set; }
        public string? OpeningOffersDate { get; set; }
        public string? CheckingOffersDate { get; set; }
        public decimal? TenderValue { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PeriodExecution { get; set; }
        public string? Staff { get; set; }
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? ActivityFieldId { get; set; }
        public long? CommitteeId { get; set; }
        public int? RfqStutesId { get; set; }
        public string? Scope { get; set; }
        public string? LastInquiriesDate { get; set; }
        public int? QuotationId { get; set; }
        public string? QuotationCode { get; set; }
        public long? OrId { get; set; }
        public string? OrCode { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? ComparisonType { get; set; }
        public long? PoId { get; set; }
        public string? PoCode { get; set; }
        public string? EstimatedPrice { get; set; }
        public int? AgreementId { get; set; }
        public string? ProjectStartDate { get; set; }
        public string? ProjectEndDate { get; set; }
        public int? BillType { get; set; }
        public string? DueDate { get; set; }
        public long? ContractId { get; set; }
        public long? FinancYearId { get; set; }
        public int? MonthId { get; set; }
        public List<PurTransactionsProductPODto>? Products { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionEditPODto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        [Required]
        public int? BranchId { get; set; }
        [Required]
        public string? VendorCode { get; set; }
        //[Required]
        public string? VendorName { get; set; }
        public long? VendorId { get; set; }
        public int? VendorType { get; set; }
        public long? RecipientId { get; set; }
        public string? RecipientName { get; set; }
        public string? Address { get; set; }
        //[Required]
        public string? RefNumber { get; set; }
        [Required]
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        public string? DeliveryDate { get; set; }
        [Required]
        public string? ExpirationDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public decimal? Net { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        public long? RefranceId { get; set; }
        public int? InventoriesId { get; set; }
        public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? AppId { get; set; }
        public int? AppTypeId { get; set; }
        public int? TypeId2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
        public string? Details3 { get; set; }
        public int? ContractType { get; set; }
        public bool? HasDownpayment { get; set; }
        public int? DownpaymentType { get; set; }
        public decimal? DownpaymentRate { get; set; }
        public decimal? DownpaymentAmount { get; set; }
        public string? RequestCode { get; set; }
        public string? ContractualPaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PeriodBillsDay { get; set; }
        public long? EmpId { get; set; }
        public long? TenderType { get; set; }
        public bool? SendtoSupplier { get; set; }
        public string? LastSubmissionDate { get; set; }
        public string? OpeningOffersDate { get; set; }
        public string? CheckingOffersDate { get; set; }
        public decimal? TenderValue { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PeriodExecution { get; set; }
        public string? Staff { get; set; }
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? ActivityFieldId { get; set; }
        public long? CommitteeId { get; set; }
        public int? RfqStutesId { get; set; }
        public string? Scope { get; set; }
        public string? LastInquiriesDate { get; set; }
        public int? QuotationId { get; set; }
        public string? QuotationCode { get; set; }
        public long? OrId { get; set; }
        public string? OrCode { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? ComparisonType { get; set; }
        public long? PoId { get; set; }
        public string? PoCode { get; set; }
        public string? EstimatedPrice { get; set; }
        public int? AgreementId { get; set; }
        public string? ProjectStartDate { get; set; }
        public string? ProjectEndDate { get; set; }
        public int? BillType { get; set; }
        public string? DueDate { get; set; }
        public long? ContractId { get; set; }
        public long? FinancYearId { get; set; }
        public int? MonthId { get; set; }
        public List<PurTransactionsProductPODto>? Products { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionPOVWDto
    {
        public PurTransactionPOVWDto()
        {
            Products = new List<PurTransactionsProductPODto>();
        }
        public PurTransactionsVw PurTransactions { get; set; }
        public List<PurTransactionsProductPODto> Products { get; set; }
    }
    public class PurTransactionPOFilterDto
    {
        public int? TransTypeId { get; set; } // Maps to obj.Trans_Type_ID
        public long? FacilityId { get; set; } // Maps to obj.Facility_ID
        public int? BranchId { get; set; } // Maps to obj.Branch_ID
        public long? BranchsId { get; set; } // Maps to obj.Branchs_ID (alternative branch logic)
        public string? Code { get; set; } // Maps to obj.Code
        //public string? CodeTo { get; set; } // Maps to obj.Code_To (for code range filters)
        public string? RefNumber { get; set; } // Maps to obj.Ref_Number
        public string? StartDate { get; set; } // Maps to obj.StartDate
        public string? EndDate { get; set; } // Maps to obj.EndDate
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? CusTypeId { get; set; } // Maps to obj.Cus_Type_Id (vendor type)
        public string? SupplierCode { get; set; } // Maps to obj.Supplier_Code
        public string? SupplierName { get; set; } // Maps to obj.Supplier_Name
        public long? ProjectCode { get; set; } // Maps to obj.Project_Code
        public string? ProjectName { get; set; } // Maps to obj.Project_Name
        public int? PaymentTermsId { get; set; } // Maps to obj.Payment_Terms_ID
        public decimal? Subtotal { get; set; } // Maps to obj.Subtotal
        public int? InventoriesId { get; set; } // Maps to obj.Inventories_ID
        public int? IsConverted { get; set; } // Maps to obj.IsConverted
        public long? CreatedBy { get; set; } // Maps to obj.CreatedBy
    }
    public class PurTransactionBillDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        [Required]
        public int? BranchId { get; set; }
        [Required]
        public string? VendorCode { get; set; }
        public string? AccAccountCode { get; set; }
        //[Required]
        public string? VendorName { get; set; }
        public long? VendorId { get; set; }
        public int? VendorType { get; set; }
        public int? CashOnhand { get; set; }
        public long? RecipientId { get; set; }
        public string? RecipientName { get; set; }
        public string? Address { get; set; }
        //[Required]
        public string? RefNumber { get; set; }
        [Required]
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        public string? DeliveryDate { get; set; }
        //[Required]
        public string? ExpirationDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public int? BillInventroy { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public decimal? Net { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر الشراء
        /// </summary>
        public long? RefranceId { get; set; }
        public int? InventoriesId { get; set; }
        public long? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? AppId { get; set; }
        public int? AppTypeId { get; set; }
        public int? TypeId2 { get; set; }
        public string? Details1 { get; set; }
        public string? Details2 { get; set; }
        public string? Details3 { get; set; }
        public int? ContractType { get; set; }
        public bool? HasDownpayment { get; set; }
        public int? DownpaymentType { get; set; }
        public decimal? DownpaymentRate { get; set; }
        public decimal? DownpaymentAmount { get; set; }
        public string? RequestCode { get; set; }
        public string? ContractualPaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PeriodBillsDay { get; set; }
        public long? EmpId { get; set; }
        public long? TenderType { get; set; }
        public bool? SendtoSupplier { get; set; }
        public string? LastSubmissionDate { get; set; }
        public string? OpeningOffersDate { get; set; }
        public string? CheckingOffersDate { get; set; }
        public decimal? TenderValue { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PeriodExecution { get; set; }
        public string? Staff { get; set; }
        public string? SupplyStartDate { get; set; }
        public string? SupplyEndDate { get; set; }
        public int? ActivityFieldId { get; set; }
        public long? CommitteeId { get; set; }
        public int? RfqStutesId { get; set; }
        public string? Scope { get; set; }
        public string? LastInquiriesDate { get; set; }
        public int? QuotationId { get; set; }
        public string? QuotationCode { get; set; }
        public long? OrId { get; set; }
        public string? OrCode { get; set; }
        public int? DurationType { get; set; }
        public string? Duration { get; set; }
        public int? ComparisonType { get; set; }
        public long? PoId { get; set; }
        public string? PoCode { get; set; }
        public string? EstimatedPrice { get; set; }
        public int? AgreementId { get; set; }
        public string? ProjectStartDate { get; set; }
        public string? ProjectEndDate { get; set; }
        public int? BillType { get; set; }
        public int? BankId { get; set; }
        public string? DueDate { get; set; }
        public string? ChequNo { get; set; }
        public string? DateChequ { get; set; }
        public long? ContractId { get; set; }
        public long? FinancYearId { get; set; }
        public long? PeriodId { get; set; }
        public int? MonthId { get; set; }
        public List<PurTransactionsProductBillDto>? Products { get; set; }
        public WhTransactionsMasterPurBillDto? whTranMaster { get; set; }
        public WhTransactionsDetailePurBillDto? whTranDetails { get; set; }
        //public PurTransactionsPaymentBillDto? TranPayment { get; set; }
        //public AccJournalMasterPurBillDto? AccJournalMaster { get; set; }
        public List<SaveFileDto>? FileDtos { get; set; }
    }
    public class PurTransactionBillFilterDto
    {
        public int? TransTypeId { get; set; } // Maps to obj.Trans_Type_ID
        public long? FacilityId { get; set; } // Maps to obj.Facility_ID
        public int? BranchId { get; set; } // Maps to obj.Branch_ID
        public long? BranchsId { get; set; } // Maps to obj.Branchs_ID (alternative branch logic)
        public string? Code { get; set; } // Maps to obj.Code
        public string? CodeTo { get; set; } // Maps to obj.Code_To (for code range filters)
        public string? RefNumber { get; set; } // Maps to obj.Ref_Number
        public string? StartDate { get; set; } // Maps to obj.StartDate
        public string? EndDate { get; set; } // Maps to obj.EndDate
        public int? CusTypeId { get; set; } // Maps to obj.Cus_Type_Id (vendor type)
        public string? SupplierCode { get; set; } // Maps to obj.Supplier_Code
        public string? SupplierName { get; set; } // Maps to obj.Supplier_Name
        public long? ProjectCode { get; set; } // Maps to obj.Project_Code
        public string? ProjectName { get; set; } // Maps to obj.Project_Name
        public string? ProductCode { get; set; } // Maps to obj.Project_Name
        public string? RecipientName { get; set; } // Maps to obj.Project_Name
        public int? PaymentTermsId { get; set; } // Maps to obj.Payment_Terms_ID
        public int? BillType { get; set; } // Maps to obj.Payment_Terms_ID
        public decimal? Subtotal { get; set; } // Maps to obj.Subtotal
        public int? InventoriesId { get; set; } // Maps to obj.Inventories_ID
        public long? CreatedBy { get; set; } // Maps to obj.CreatedBy
    }
    public class PurTransactionNoCodeDto
    {
        public int? No { get; set; }
        public string? Code { get; set; }
    }

}
