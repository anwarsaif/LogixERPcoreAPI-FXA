using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.PM
{
    public partial class PmProjectsGuaranteeDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public int? GuaranteeType { get; set; }
        public decimal? Amount { get; set; }
        public long? BankId { get; set; }
        public string? ExpiryDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Date { get; set; }
        public string? GuaranteeNo { get; set; }
        public int? FacilityId { get; set; }
        public long? SupId { get; set; }
        public int SupType { get; set; } = 0;
        public decimal? Rate { get; set; }
        public string? BankMobil { get; set; }
        public string? IssueDate { get; set; }
        public string? Note { get; set; }
        public int? StatusId { get; set; }
        public string? ProjectName { get; set; }
        public string? SupCode { get; set; }
        public string? SupName { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }

    }

    public partial class PmProjectsGuaranteeEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }

        public int? GuaranteeType { get; set; }
        public decimal? Amount { get; set; }
        public long? BankId { get; set; }
        public string? ExpiryDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Date { get; set; }
        public string? GuaranteeNo { get; set; }
        public int? FacilityId { get; set; }
        public long? SupId { get; set; }
        public decimal? Rate { get; set; }
        public string? BankMobil { get; set; }
        public string? IssueDate { get; set; }
        public string? Note { get; set; }
        public int? StatusId { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }
        public int SupType { get; set; } = 0;
        public string? SupCode { get; set; }


    }

    public class PmProjectsGuaranteeFilterDto
    {
        public string? GuaranteeNo { get; set; }
        public int? StatusId { get; set; }
        public int? FacilityId { get; set; }
        public int? BankId { get; set; }
        public int? GuaranteeType { get; set; }
        public string? SupCode { get; set; }
        public string? SupName { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
    }
}
