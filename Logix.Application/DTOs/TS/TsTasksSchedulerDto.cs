namespace Logix.Application.DTOs.TS
{
    public partial class TsTasksSchedulerDto
    {
        public long? Id { get; set; }
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
        public int? StatusId { get; set; }
        public string? ReferenceCode { get; set; }
        public string? Comment { get; set; }
        public int? DeptId { get; set; }
        public string? SendDate { get; set; }
        public long? ProjectId { get; set; }
        /// <summary>
        /// تاريخ اغلاق المهمة
        /// </summary>
        public string? DoneOn { get; set; }
        //public TimeSpan? Duration { get; set; }
        public string? DurationString { get; set; }
        public bool IsDeleted { get; set; }
        public int? Daily { get; set; }
        public string? Day { get; set; }
        public int? Weekly { get; set; }
        public string? DaysWeek { get; set; }
        public int? Monthly { get; set; }
        public string? MonthDay { get; set; }
        public int? Type { get; set; }
    }
    public partial class TsTasksSchedulerEditDto
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
        public int? StatusId { get; set; }
        public string? ReferenceCode { get; set; }
        public string? Comment { get; set; }
        public int? DeptId { get; set; }
        public string? SendDate { get; set; }
        public long? ProjectId { get; set; }
        /// <summary>
        /// تاريخ اغلاق المهمة
        /// </summary>
        public string? DoneOn { get; set; }
        //public TimeSpan? Duration { get; set; }
        public string? DurationString { get; set; }
        public int? Daily { get; set; }
        public string? Day { get; set; }
        public int? Weekly { get; set; }
        public string? DaysWeek { get; set; }
        public int? Monthly { get; set; }
        public string? MonthDay { get; set; }
        public int? Type { get; set; }
    }
    public partial class TsTasksSchedulerFilterDto
    {
        public string? Subject { get; set; }
        public string? AssigneeToUserId { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public int? StatusId { get; set; }
        public string? SendDate { get; set; }
        public int? Type { get; set; }
        public string? EmpName { get; set; }
    }
}
