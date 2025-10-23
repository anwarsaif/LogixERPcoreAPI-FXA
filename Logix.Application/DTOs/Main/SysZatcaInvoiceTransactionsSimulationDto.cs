using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysZatcaInvoiceTransactionsSimulationDto
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
        public long? FacilityId { get; set; }
        public long? InvoiceAccordingTypeId { get; set; }
        public string? InvoiceOrder { get; set; }
        public string? SignedXmlPath { get; set; }
        public int? BranchId { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
