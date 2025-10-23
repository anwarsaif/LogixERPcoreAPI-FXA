using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.TS
{
    public partial class TsTasksSchedulerVwDto
    {
        public long Id { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public int? WorkFlowType { get; set; }
        public string? AssigneeToUserId { get; set; }
        public string? AssigneeToGroupId { get; set; }
        public string? DueDate { get; set; }
        public decimal? RequiredApprovalPercentage { get; set; }
        public bool? SendEmailNotifications { get; set; }
        public int? Priority { get; set; }
        public long? ParentId { get; set; }
        public bool IsDeleted { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? StatusId { get; set; }
        public string? ReferenceCode { get; set; }
        public string? PriorityName { get; set; }
        public int? CatagoriesId { get; set; }
        public string? StatusName { get; set; }
        public string? WorkFlowTypeName { get; set; }
        public string? UserFullname { get; set; }
        public int? DeptId { get; set; }
        public string? DepName { get; set; }
        public string? SendDate { get; set; }
        public long? ProjectId { get; set; }
        public string? DoneOn { get; set; }
        public TimeSpan? Duration { get; set; }
        public string? ProjectName { get; set; }
        public long? ProjectCode { get; set; }
        public string? AssigneeToUserName { get; set; }
        public string? CustomerName { get; set; }
        public long? CustomerId { get; set; }
        public int? Daily { get; set; }
        public string? Day { get; set; }
        public int? Weekly { get; set; }
        public string? DaysWeek { get; set; }
        public int? Monthly { get; set; }
        public string? MonthDay { get; set; }
        public int? Type { get; set; }
        public string? TypeName { get; set; }
    }
}
