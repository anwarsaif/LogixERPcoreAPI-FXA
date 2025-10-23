using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM.Shared
{

    public class DeptProjectDetailsDto
    {
        public string? LastUpdateSteps { get; set; }
        public long? StepId { get; set; }
        public long? StatusId { get; set; }
        public string? Duration { get; set; }
        public string? DurationTypeName { get; set; }
        public long? Id { get; set; }
        public string? Name { get; set; }
        public string? EmpName { get; set; }
        public long? TenderStatus { get; set; }
        public string? TenderStatusName { get; set; }
        public string? CustomerName { get; set; }
        public decimal? ProjectValue { get; set; }
        public string? ProjectStart { get; set; }
        public string? ProjectEnd { get; set; }
        public decimal? DelayedRate { get; set; }
        public string? OwnerDeptName { get; set; }
        public string? Beneficiary { get; set; }
        public long? Code { get; set; }
        public decimal? AllowanceRatioBudget { get; set; }
        public string? DateG { get; set; }
        public string? Description { get; set; }
        public decimal? EstimatedCost { get; set; }
        public string? CompletionRate { get; set; }
        public string? VendorName { get; set; } 
        public string? StepName { get; set; } 
        public string? StatusName { get; set; } 
    }
    public class DeptProjectDetailsFilterDto
    {
        public long CharterStatus { get; set; } = 0;
        public long FacilityId { get; set; } = 0;
        public long StatusId { get; set; } = 0;
        public long OwnerDeptId { get; set; } = 0;
        public long EmpId { get; set; } = 0;
        public long ProjectId { get; set; } = 0;
        public DateTime CurrDate { get; set; } = DateTime.Now;
    }
    public class ProjectStatisticsDto
    {
        public int NotStarted { get; set; }
        public int Completed { get; set; }
        public int Plan { get; set; }
        public int Stumbling { get; set; }
        public int Late { get; set; }
        public int Plan3 { get; set; }
        public int Plan6 { get; set; }
        public long OwnerDeptId { get; set; }
        //عدد المشاريع الإجمالي

        public long CountAll { get; set; }
    }

}
