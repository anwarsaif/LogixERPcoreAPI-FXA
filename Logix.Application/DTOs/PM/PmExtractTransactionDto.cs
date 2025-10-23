using Logix.Application.DTOs.Main;
using Logix.Application.DTOs.PM.PmProjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM
{
    public class PmExtractTransactionPoPDto
    {
 
        public string? Code { get; set; }

        [StringLength(10)]
        public string? Date1 { get; set; }
    }

    public class PmExtractTransactionFilterDto
    {
        public int? TransTypeId { get; set; }
        public int? BranchId { get; set; }
        public string? BranchsId { get; set; }
        public string? Code { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public int? PaymentTermsId { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public long? ProjectId { get; set; }
        public decimal? Total { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? ParentProjectCode { get; set; }
        public string? ProjectManagerCode { get; set; }
        public string? ProjectManagerName { get; set; }
        public int? UserType { get; set; }
        public long? EmpId { get; set; }
        public string? InvCode { get; set; }
        public int? StatusId { get; set; }
        public string? ItemCode { get; set; }
        [StringLength(10)]
        public string? Date1 { get; set; }
    }

    public class PmExtractTransactionDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        public int? BranchId { get; set; }
        public long? CustomerId { get; set; }
        public long? RecipientId { get; set; }
        [StringLength(50)]
        public string? RecipientName { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? PoNumber { get; set; }
        [StringLength(10)]
        public string? Date1 { get; set; }
        [StringLength(10)]
        public string? Date2 { get; set; }
        [StringLength(10)]
        public string? DeliveryDate { get; set; }
        [StringLength(10)]
        public string? ExpirationDate { get; set; }
        [StringLength(10)]
        public string? DueDate { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; }
        public string? PrivateNote { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }

        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر البيع
        /// </summary>
        public long? RefranceId { get; set; }

        [StringLength(50)]
        public string? NoIncoming { get; set; }
        [StringLength(10)]
        public string? DateIncoming { get; set; }
        [StringLength(50)]
        public string? NoLimited { get; set; }
        [StringLength(10)]
        public string? DateLimited { get; set; }
        [StringLength(50)]
        public string? NoUploadCmd { get; set; }
        [StringLength(10)]
        public string? DateUploadCmd { get; set; }
        [StringLength(50)]
        public string? NoConvert { get; set; }
        [StringLength(10)]
        public string? DateConvert { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? PrevAmount { get; set; }
        public int? PrevCnt { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? RemainingAmount { get; set; }
        public long? AppId { get; set; }
        public decimal? PrePaidRate { get; set; }
        public decimal? PrePaidAmount { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public long? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? SubtotalWrite { get; set; }
        public long? PaymentInstallmentId { get; set; }
        [StringLength(10)]
        public string? DateStatus { get; set; }
        public string? DescriptionStatus { get; set; }
        [StringLength(10)]
        public string? DatePaymentActual { get; set; }
        public decimal? DeductionDownPayment { get; set; }
        public decimal? AdditionalVat { get; set; }
        public decimal? DeductionRetention { get; set; }
        public decimal? AddtionalOthers { get; set; }
        public decimal? DeductionOthers { get; set; }
        public int? InvNo { get; set; }
        [StringLength(250)]
        public string? InvCode { get; set; }
        [StringLength(10)]
        public string? InvDate { get; set; }
        [StringLength(50)]
        public string? RefranceCode { get; set; }
        public decimal? InvTotal { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public bool? IsReportedToZatca { get; set; }
        public int? ZatcaCreditDebitNotesId { get; set; }
        [StringLength(50)]
        public string? SupplierInvoiceCode { get; set; }
        public long? DraftId { get; set; }
        [StringLength(50)]
        public string? DraftCode { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? ProjectName { get; set; }
        public decimal? Paid { get; set; }
        public string? ParentCCCode { get; set; }
        public string? ParentCCName { get; set; }
        public long? CusTypeId { get; set; }

    }
      public class PmExtractTransactionAddDto
    {
        public long Id { get; set; }
        public long? No { get; set; } = 0;
        [StringLength(50)]
        public string? Code { get; set; }
        public int? TransTypeId { get; set; } = 0;
        public int? BranchId { get; set; } = 0;
        public long? CustomerId { get; set; } = 0;
        public long? RecipientId { get; set; } = 0;
        [StringLength(50)]
        public string? RecipientName { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? PoNumber { get; set; }
        [StringLength(10)]
        public string? Date1 { get; set; }
        [StringLength(10)]
        public string? Date2 { get; set; }
        [StringLength(10)]
        public string? DeliveryDate { get; set; }
        [StringLength(10)]
        public string? ExpirationDate { get; set; }
        [StringLength(10)]
        public string? DueDate { get; set; }
        public int? PaymentTermsId { get; set; } = 0;
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; } = 0;//  صافي  القيمه  net
        public decimal? DiscountRate { get; set; } = 0;
        public decimal? DiscountAmount { get; set; } = 0; // اجمالي الحسميات 
        public decimal? Vat { get; set; } = 0; // اجمالي الاضافات 
        public decimal? Total { get; set; } = 0;   //  اجمالي البنود 
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; } = 0;
        public long? ProjectCode { get; set; } = 0;// فقط  وقت  التعديل 

        public string? PrivateNote { get; set; }
        public int? StatusId { get; set; } = 0;

        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر البيع
        /// </summary>
        public long? RefranceId { get; set; } = 0;

        [StringLength(50)]
        public string? NoIncoming { get; set; }
        [StringLength(10)]
        public string? DateIncoming { get; set; }
        [StringLength(50)]
        public string? NoLimited { get; set; }
        [StringLength(10)]
        public string? DateLimited { get; set; }
        [StringLength(50)]
        public string? NoUploadCmd { get; set; }
        [StringLength(10)]
        public string? DateUploadCmd { get; set; }
        [StringLength(50)]
        public string? NoConvert { get; set; }
        [StringLength(10)]
        public string? DateConvert { get; set; }
        public decimal? VatRate { get; set; } = 0;
        public decimal? PrevAmount { get; set; } = 0;
        public int? PrevCnt { get; set; } = 0;
        public decimal? ContractAmount { get; set; } = 0;
        public decimal? AmountPaid { get; set; } = 0;
        public decimal? RemainingAmount { get; set; } = 0;
        public long? AppId { get; set; } = 0;
        public decimal? PrePaidRate { get; set; } = 0;
        public decimal? PrePaidAmount { get; set; } = 0;
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public long? CurrencyId { get; set; } = 0;
        public decimal? ExchangeRate { get; set; } = 0;
        public string? SubtotalWrite { get; set; }
        public long? PaymentInstallmentId { get; set; } = 0;
        [StringLength(10)]
        public string? DateStatus { get; set; }
        public string? DescriptionStatus { get; set; }
        [StringLength(10)]
        public string? DatePaymentActual { get; set; }
        public decimal? DeductionDownPayment { get; set; } = 0;
        public decimal? AdditionalVat { get; set; } = 0;
        public decimal? DeductionRetention { get; set; } = 0;
        public decimal? AddtionalOthers { get; set; } = 0;
        public decimal? DeductionOthers { get; set; } = 0;
        public int? InvNo { get; set; } = 0;
        [StringLength(250)]
        public string? InvCode { get; set; }
        [StringLength(10)]
        public string? InvDate { get; set; }
        [StringLength(50)]
        public string? RefranceCode { get; set; }
        public decimal? InvTotal { get; set; } = 0;
        public DateTime? SubmissionDate { get; set; }
        public bool? IsReportedToZatca { get; set; }
        public int? ZatcaCreditDebitNotesId { get; set; } = 0;
        [StringLength(50)]
        public string? SupplierInvoiceCode { get; set; }
        public long? DraftId { get; set; } = 0;
        [StringLength(50)]
        public string? DraftCode { get; set; }
        public int? AppTypeID { get; set; } = 0;
        public List<PmExtractTransactionsAdditionalDto> PmExtractTransactionsAdditionalDtos { get; set; } = new List<PmExtractTransactionsAdditionalDto>();
        public List<PmExtractTransactionsProductDto> PmExtractTransactionsProductDtos { get; set; } = new List<PmExtractTransactionsProductDto>();
        // يستخدم عملية الحفظ الملفات  الداله العامة 
        public List<SaveFileDto> FileList { get; set; } = new List<SaveFileDto>();

    }

 

    public class PmExtractTransactionEditPostDto
    {
        public long Id { get; set; }
        public int? BranchId { get; set; } = 0;
        public long? CurrencyId { get; set; } = 0;
        public decimal? ExchangeRate { get; set; } = 0;
        [StringLength(10)]
        public string? Date1 { get; set; }
        public int? TransTypeId { get; set; } = 0;
        [StringLength(10)]
        public string? DueDate { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public int? PaymentTermsId { get; set; } = 0;
        public decimal? Total { get; set; } = 0;   //  اجمالي البنود 
        public decimal? DiscountAmount { get; set; } = 0; // اجمالي الحسميات 
        public decimal? Vat { get; set; } = 0; // اجمالي الاضافات 
        public decimal? Subtotal { get; set; } = 0;//  صافي  القيمه  net
        public string? SupplierInvoiceCode { get; set; }
        public PMProjectExtractInfoDto? PmProjectExtractInfoDto { get; set; }
        public List<PmExtractTransactionsAdditionalDto> PmExtractTransactionsAdditionalDtos { get; set; } = new List<PmExtractTransactionsAdditionalDto>();
        public List<PmExtractTransactionsProductEditOnExtractDto> PmExtractTransactionsProductDtos { get; set; } = new List<PmExtractTransactionsProductEditOnExtractDto>();
        // يستخدم عملية الحفظ الملفات  الداله العامة 
        public List<SaveFileDto> FileList { get; set; } = new List<SaveFileDto>();

    }
    
    public class PmExtractTransactionEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; } = 0;
        [StringLength(50)]
        public string? Code { get; set; }
        public int? TransTypeId { get; set; } = 0;
        public int? BranchId { get; set; } = 0;
        public long? CustomerId { get; set; } = 0;
        public long? RecipientId { get; set; } = 0;
        [StringLength(50)]
        public string? RecipientName { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? PoNumber { get; set; }
        [StringLength(10)]
        public string? Date1 { get; set; }
        [StringLength(10)]
        public string? Date2 { get; set; }
        [StringLength(10)]
        public string? DeliveryDate { get; set; }
        [StringLength(10)]
        public string? ExpirationDate { get; set; }
        [StringLength(10)]
        public string? DueDate { get; set; }
        public int? PaymentTermsId { get; set; } = 0;
        public string? DocumentNote { get; set; }
        public decimal? Subtotal { get; set; } = 0;//  صافي  القيمه  net
        public decimal? DiscountRate { get; set; } = 0;
        public decimal? DiscountAmount { get; set; } = 0; // اجمالي الحسميات 
        public decimal? Vat { get; set; } = 0; // اجمالي الاضافات 
        public decimal? Total { get; set; } = 0;   //  اجمالي البنود 
        public string? DeliveryContact { get; set; }
        public string? DeliveryAddress { get; set; }
        public long? ProjectId { get; set; } = 0;
        public long? ProjectCode { get; set; } = 0;// فقط  وقت  التعديل 

        public string? PrivateNote { get; set; }
        public int? StatusId { get; set; } = 0;

        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر البيع
        /// </summary>
        public long? RefranceId { get; set; } = 0;

        [StringLength(50)]
        public string? NoIncoming { get; set; } = "";
        [StringLength(10)]
        public string? DateIncoming { get; set; } = "";
        [StringLength(50)]
        public string? NoLimited { get; set; } ="";
        [StringLength(10)]
        public string? DateLimited { get; set; }= "";
        [StringLength(50)]
        public string? NoUploadCmd { get; set; } = "";
        [StringLength(10)]
        public string? DateUploadCmd { get; set; } = "";
        [StringLength(50)]
        public string? NoConvert { get; set; } = "";
        [StringLength(10)]
        public string? DateConvert { get; set; } = "";
        public decimal? VatRate { get; set; } = 0;
        public decimal? PrevAmount { get; set; } = 0;
        public int? PrevCnt { get; set; } = 0;
        public decimal? ContractAmount { get; set; } = 0;
        public decimal? AmountPaid { get; set; } = 0;
        public decimal? RemainingAmount { get; set; } = 0;
        public long? AppId { get; set; } = 0;
        public decimal? PrePaidRate { get; set; } = 0;
        public decimal? PrePaidAmount { get; set; } = 0;
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public long? CurrencyId { get; set; } = 0;
        public decimal? ExchangeRate { get; set; } = 0;
        public string? SubtotalWrite { get; set; }
        public long? PaymentInstallmentId { get; set; } = 0;
        [StringLength(10)]
        public string? DateStatus { get; set; }
        public string? DescriptionStatus { get; set; }
        [StringLength(10)]
        public string? DatePaymentActual { get; set; }
        public decimal? DeductionDownPayment { get; set; } = 0;
        public decimal? AdditionalVat { get; set; } = 0;
        public decimal? DeductionRetention { get; set; } = 0;
        public decimal? AddtionalOthers { get; set; } = 0;
        public decimal? DeductionOthers { get; set; } = 0;
        public int? InvNo { get; set; } = 0;
        [StringLength(250)]
        public string? InvCode { get; set; }
        [StringLength(10)]
        public string? InvDate { get; set; }
        [StringLength(50)]
        public string? RefranceCode { get; set; }
        public decimal? InvTotal { get; set; } = 0;
        public DateTime? SubmissionDate { get; set; }
        public bool? IsReportedToZatca { get; set; }
        public int? ZatcaCreditDebitNotesId { get; set; } = 0;
        [StringLength(50)]
        public string? SupplierInvoiceCode { get; set; }
        public long? DraftId { get; set; } = 0;
        [StringLength(50)]
        public string? DraftCode { get; set; }
        
        public string? JCode { get; set; }// فقط في التعديل مجرد عرض يستخدم لعرض رقم القيد
        public string? JDateGregorian { get; set; }

        public PMProjectExtractInfoDto? PmProjectExtractInfoDto { get; set; }
        public List<PmExtractTransactionsAdditionalDto> PmExtractTransactionsAdditionalDtos { get; set; } = new List<PmExtractTransactionsAdditionalDto>();
        public List<PmExtractTransactionsProductEditOnExtractDto> PmExtractTransactionsProductDtos { get; set; } = new List<PmExtractTransactionsProductEditOnExtractDto>();
        public List<SaveFileDto> FileList { get; set; } = new List<SaveFileDto>();


    }


    public class PmExtractTransactionInvoiceCreateDto
    {
        // يستخدم عند طلب اشاء فاتوره لمستخلص
        public long Id { get; set; }// ExtractTransaction id 
        public int? InvNo { get; set; }
        [StringLength(250)]
        public string? InvCode { get; set; }
        [StringLength(10)]
        public string? InvDate { get; set; }
    }   
    public class PmExtractTransactionACCCreateDto
    {
        // يستخدم عند طلب اشاء فاتوره لمستخلص
        public long Id { get; set; }// ExtractTransaction id 
        public string? JCode { get; set; }
        public string? JDateHijri { get; set; }
        public string? JDateGregorian { get; set; }

    }
    // الفلترة في شاشة    ربط المستخلصات في الاوراق المالية
    public class PaymentFinancialPaperDto
    {
        public long? Id { get; set; }
        public int? PaymentTermsId { get; set; }
        public int? TransTypeId { get; set; }
        public int? BranchId { get; set; }
        public string? Code { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string Date1 { get; set; }
        public decimal? Total { get; set; }
        public decimal? VAT { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Remaining { get; set; }
    }

    //  جلب مدفوعات العميل في سداد مستخلصات 
    public class CustomerPaymentWithExtractTransactionDto
    {
        public long JId { get; set; }
        public long? ReferenceNo { get; set; }
        public string? JDateGregorian { get; set; }
        public string? JDescription { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountRemaining { get; set; }
        public decimal? AmountUsed { get; set; }

        //  المراد سداده
        public decimal? AmountTopaid { get; set; }
    }

    //  تسديد
    public class CustomerPayment
    {
        // رقم الحركة

        public long TransactionId { get; set; }
        public long JId { get; set; }

        //  المراد سداده
        public decimal Amount { get; set; }
        public string JDateGregorian { get; set; }

    }

    public class ZatcaPmExtractVm
    {
        public string? InvCode { get; set; }
        public string? CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string? InvDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long ProjectId { get; set; }
        public long Id { get; set; }
        public decimal AdditionalVat { get; set; }
        public string? Code { get; set; }
        //public long CustomerId { get; set; }
        public int ZatcaCreditDebitNotesId { get; set; }
        public long RefranceId { get; set; }
        public string? Date1 { get; set; }
    }
}
