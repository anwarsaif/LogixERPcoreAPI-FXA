using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.TS
{
    public partial class TsTasksResponseVwDto
    {
        public int? CatagoriesId { get; set; }
        public string? Name { get; set; }
        public long Id { get; set; }
        public long? TaskId { get; set; }
        public string? Comment { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedIn { get; set; }
        public long? UserId { get; set; }
        public bool? Isdel { get; set; }
        public string? DoneOn { get; set; }
        public TimeSpan? HoursSpent { get; set; }
        public string? Subject { get; set; }
        public string? ProjectName { get; set; }
        public long? ProjectCode { get; set; }
        public long? ProjectId { get; set; }
        public TimeSpan? DoneTime { get; set; }
        public bool? ExractReport { get; set; }
        public string? SendToCustomerDate { get; set; }
        public string? ExractReportDate { get; set; }
        public string? UserFullname { get; set; }
        public string? EmpPhoto { get; set; }
        public int? EmpId { get; set; }
        public string? CustomerName { get; set; }
        public string? DefendantName { get; set; }
        public string? JudicialAuthority { get; set; }
        public int? RecipeId { get; set; }
        public decimal? CompletionRate { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? CustomerCode { get; set; }
        public string? DateG { get; set; }
        public int? ProjectType { get; set; }
        public long? ProjectParentId { get; set; }
        public string? Duration { get; set; }
    }
}
