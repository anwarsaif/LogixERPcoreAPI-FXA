using Logix.Domain.WH;

namespace Logix.Application.DTOs.PM.Shared
{
    public class PMSharedFilterDto
    {
        public long? Id { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
    }

    public class BindProjectsDto
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public int? ProjectType { get; set; }
        public int? Type { get; set; }
        public long? Code { get; set; }
        public long? Code2 { get; set; }
        public long? ParentId { get; set; }
        public long? ParentCode { get; set; }
        public long? ParentType { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerCode { get; set; }
        public int? StatusId { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? EndDateFrom { get; set; }
        public string? EndDateTo { get; set; }
        public int? BranchId { get; set; }
        public bool? Isletter { get; set; }
        public long? SystemId { get; set; }
        public bool? IsSubContract { get; set; }
        public decimal? ProjectValue { get; set; }
        public string? CostCenterCode { get; set; }
        public string? CostCenterName { get; set; }
        public int? Iscase { get; set; }
        public int? TenderStatus { get; set; }
        public string? SponsorId { get; set; }
        public string? IdNo { get; set; }

        public long? OwnerDeptId { get; set; }
        public int? PaymentType { get; set; }
        public string? SponsorName { get; set; }
        public string? IssueNoFile { get; set; }
        public decimal? AmountFrom { get; set; }
        public decimal? AmountTo { get; set; }
        public string? Mobile { get; set; }
        public string? ProjectManagerCode { get; set; }
        public string? ProjectManagerName { get; set; }
        public string? Part1Name { get; set; }
        public string? DefendantName { get; set; }
        public long? EmpId{ get; set; }
        public bool? IsActive { get; set; }
        public int? paid { get; set; }
        public string? InstallmentDateFrom { get; set; }
        public string? InstallmentDateTo { get; set; }

    }
    public class CategoryTreeDto
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public List<CategoryTreeDto>? Children { get; set; } = new();
    }

}
