using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class ZatcaInvoiceFilterDto
    {
        //public string? BranchsId { get; set; }
        public string? Code { get; set; }
        [Range(1, long.MaxValue)]
        public long? InvoiceAccordingTypeId { get; set; } // DDInvoiceType => Sys_Invoice_According_Type
        public int? InvoiceStatus { get; set; }
        public int? PaymentTermsId { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public int? BranchId { get; set; }
        public int? InvoiceType { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
    }

    public class SysZatcaInvoiceTransactionDto
    {
        public long Id { get; set; }
        public long? SalTransactionsId { get; set; }
        public string? InvoiceHash { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public bool? IsReportedToZatca { get; set; }
        public string? ReportingResult { get; set; }
        public string? ReportingStatus { get; set; }
        public string? QrCode { get; set; }
        public string? SignedXml { get; set; }
        public long? InvoiceAccordingTypeId { get; set; }
        public string? InvoiceOrder { get; set; }
        public long FacilityId { get; set; }
        public string? SignedXmlPath { get; set; }
        public int? BranchId { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
