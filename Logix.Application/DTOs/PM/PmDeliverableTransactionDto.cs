using Logix.Application.DTOs.Main;
using Logix.Domain.PM;

namespace Logix.Application.DTOs.PM
{
    public class PmDeliverableTransactionDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? StatusId { get; set; }
        public long? ProjectId { get; set; }
        public long? BranchId { get; set; }
        public string? Date1 { get; set; }
        public long? EmpId { get; set; }
        public string? DeliveryDate { get; set; }
        public string? Note { get; set; }
        public long? AppId { get; set; }
        public int? AppTypeId { get; set; }
        public bool? IsDeleted { get; set; }
    }



    public class PmDeliverableTransactionEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? StatusId { get; set; }
        public long? ProjectId { get; set; }
        public long? BranchId { get; set; }
        public string? Date1 { get; set; }
        public long? EmpId { get; set; }
        public string? DeliveryDate { get; set; }
        public string? Note { get; set; }
        public long? AppId { get; set; }
    }

    public class PmDeliverableTransactionFilterDto
    {
        public string? Code { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }

    }

    public class PmDeliverableTransactionAddDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? StatusId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public long? BranchId { get; set; }
        public string? Date1 { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public string? DeliveryDate { get; set; }
        public string? Note { get; set; }
        public long? AppId { get; set; }
        public int? AppTypeId { get; set; }
        public bool? IsDeleted { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }
        public List<PmDeliverableTransactionsDetailDto> Detailes { get; set; }
    }
}
