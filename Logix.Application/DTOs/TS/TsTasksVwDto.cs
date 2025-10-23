using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.TS
{
    //public class TsTasksVwDto
    //{
    //    public long Id { get; set; }
    //    public string? Subject { get; set; }
    //    public string? Message { get; set; }
    //    [Column("WorkFlow_Type")]
    //    public int? WorkFlowType { get; set; }
    //    [Column("Assignee_to_User_ID")]
    //    public string AssigneeToUserId { get; set; } = string.Empty;
    //    [Column("Assignee_to_Group_ID")]
    //    public string? AssigneeToGroupId { get; set; }
    //    [Column("Due_Date")]
    //    [StringLength(10)]
    //    public string? DueDate { get; set; }
    //    public string? DueDate1 { get; set; }
    //    public string? DueDate2 { get; set; }
    //    [Column("Required_Approval_Percentage", TypeName = "decimal(18, 2)")]
    //    public decimal? RequiredApprovalPercentage { get; set; }
    //    [Column("Send_Email_Notifications")]
    //    public bool? SendEmailNotifications { get; set; }
    //    public int? Priority { get; set; }
    //    [Column("Parent_ID")]
    //    public long? ParentId { get; set; }
    //    public long? ClassificationId { get; set; }
    //    [Column("ISDEL")]
    //    public bool? Isdel { get; set; }
    //    [Column("USER_ID")]
    //    public long? UserId { get; set; }
    //    [Column(TypeName = "datetime")]
    //    public DateTime? CreatedIn { get; set; }
    //    [Column("Status_ID")]
    //    public int? StatusId { get; set; }
    //    [Column("Reference_Code")]
    //    [StringLength(50)]
    //    public string? ReferenceCode { get; set; }
    //    [Column("Priority_name")]
    //    [StringLength(250)]
    //    public string? PriorityName { get; set; }
    //    public string? ClassificationName { get; set; }
    //    public int? CntDay { get; set; }
    //    [Column("WorkFlow_Type_name")]
    //    [StringLength(250)]
    //    public string? WorkFlowTypeName { get; set; }
    //    [Column("USER_FULLNAME")]
    //    [StringLength(50)]
    //    public string? UserFullname { get; set; }
    //    [Column("Dept_ID")]
    //    public int? DeptId { get; set; }
    //    [Column("Dep_name")]
    //    [StringLength(250)]
    //    public string? DepName { get; set; }
    //    [Column("Send_Date")]
    //    [StringLength(10)]
    //    public string? SendDate { get; set; }
    //    public string? SendDate1 { get; set; }
    //    public string? SendDate2 { get; set; }
    //    [Column("Project_ID")]
    //    public long? ProjectId { get; set; }
    //    [Column("Done_on")]
    //    [StringLength(10)]
    //    public string? DoneOn { get; set; }
    //    [Column(TypeName = "time(5)")]
    //    public TimeSpan? Duration { get; set; }
    //    [Column("Project_Name")]
    //    [StringLength(2500)]
    //    public string? ProjectName { get; set; }
    //    [Column("Project_Code")]
    //    public long? ProjectCode { get; set; }
    //    [Column("Assignee_to_User_Name")]
    //    public string? AssigneeToUserName { get; set; }
    //    [Column("Customer_ID")]
    //    public long? CustomerId { get; set; }
    //    [Column("Issue_NO_File")]
    //    [StringLength(250)]
    //    public string? IssueNoFile { get; set; }
    //    [Column("Recipe_ID")]
    //    public int? RecipeId { get; set; }
    //    [Column("Customer_name")]
    //    [StringLength(2500)]
    //    public string? CustomerName { get; set; }
    //    [Column("Defendant_Name")]
    //    [StringLength(2500)]
    //    public string? DefendantName { get; set; }
    //    [Column("Judicial_Authority")]
    //    [StringLength(250)]
    //    public string? JudicialAuthority { get; set; }
    //    [Column("Status_name")]
    //    [StringLength(250)]
    //    public string? StatusName { get; set; }
    //    [Column("Color_Value")]
    //    [StringLength(250)]
    //    public string? ColorValue { get; set; }
    //    [Column("Customer_Code")]
    //    [StringLength(250)]
    //    public string? CustomerCode { get; set; }
    //    [StringLength(250)]
    //    public string? Color { get; set; }
    //    [StringLength(250)]
    //    public string? Icon { get; set; }
    //    [Column("Percentage_Of_Project", TypeName = "decimal(18, 2)")]
    //    public decimal? PercentageOfProject { get; set; }
    //    [Column("Completion_Rate", TypeName = "decimal(18, 2)")]
    //    public decimal? CompletionRate { get; set; }
    //    public string? Depend { get; set; }
    //    [Column("ISCase")]
    //    public bool? Iscase { get; set; }
    //    [Column("Duration_Type")]
    //    public int? DurationType { get; set; }
    //    [Column("Project_PlansID")]
    //    public long? ProjectPlansId { get; set; }
    //    [StringLength(50)]
    //    public string? Durations { get; set; }
    //    [Column("Facility_ID")]
    //    public long? FacilityId { get; set; }
    //    [StringLength(10)]
    //    public string? DateG { get; set; }
    //    [Column("Project_Type")]
    //    public int? ProjectType { get; set; }
    //    [Column("Project_Parent_ID")]
    //    public long? ProjectParentId { get; set; }
    //    public string? MainSubject { get; set; }
    //    [Column("Type_ID")]
    //    public int? TypeId { get; set; }
    //    [Column("Type_Name")]
    //    [StringLength(250)]
    //    public string? TypeName { get; set; }
    //    [Column("Type_Name2")]
    //    [StringLength(250)]
    //    public string? TypeName2 { get; set; }
    //    [Column("Duration_TypeName")]
    //    [StringLength(250)]
    //    public string? DurationTypeName { get; set; }
    //    [Column("Deliverable_ID")]
    //    public long? DeliverableId { get; set; }
    //    [Column("Deliverable_Name")]
    //    public string? DeliverableName { get; set; }
    //    [Column("WBS")]
    //    [StringLength(50)]
    //    public string? Wbs { get; set; }
    //    [Column("Actual_StartDate")]
    //    [StringLength(10)]
    //    public string? ActualStartDate { get; set; }
    //    [Column("Actual_EndDate")]
    //    [StringLength(10)]
    //    public string? ActualEndDate { get; set; }
    //    [StringLength(250)]
    //    public string? Type { get; set; }

    //    public int CntDays { get; set; }
    //    public int RemainingDays { get; set; }
    //    public int Persent { get; set; }
    //}
    public class TsTasksVwDto
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

        public bool? Isdel { get; set; }

        public long? UserId { get; set; }

        public DateTime? CreatedIn { get; set; }

        public int? StatusId { get; set; }

        public string? ReferenceCode { get; set; }

        public string? PriorityName { get; set; }

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

        public long? CustomerId { get; set; }

        public string? IssueNoFile { get; set; }

        public int? RecipeId { get; set; }

        public string? CustomerName { get; set; }

        public string? DefendantName { get; set; }

        public string? JudicialAuthority { get; set; }

        public string? StatusName { get; set; }

        public string? ColorValue { get; set; }

        public string? CustomerCode { get; set; }

        public string? Color { get; set; }

        public string? Icon { get; set; }

        public decimal? PercentageOfProject { get; set; }

        public decimal? CompletionRate { get; set; }

        public string? Depend { get; set; }

        public bool? Iscase { get; set; }

        public int? DurationType { get; set; }

        public long? ProjectPlansId { get; set; }

        public string? Durations { get; set; }

        public long? FacilityId { get; set; }

        public string? DateG { get; set; }

        public int? ProjectType { get; set; }

        public long? ProjectParentId { get; set; }

        public string? MainSubject { get; set; }

        public int? TypeId { get; set; }

        public string? TypeName { get; set; }

        public string? TypeName2 { get; set; }

        public string? DurationTypeName { get; set; }

        public long? DeliverableId { get; set; }

        public string? DeliverableName { get; set; }

        public string? Wbs { get; set; }

        public string? ActualStartDate { get; set; }

        public string? ActualEndDate { get; set; }

        public string? Type { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitPriceTotal { get; set; }

        public long? ActivityId { get; set; }

        public string? ActivityName { get; set; }

        public long? ClassificationId { get; set; }

        public string? ClassificationName { get; set; }

        public int? PlansTypeId { get; set; }

        public string? ItemCode { get; set; }

        public string? ExpectedTime { get; set; }

        public string? RealTime { get; set; }

        public string? ProjectNo { get; set; }

        public int CntDays { get; set; }
        public int RemainingDays { get; set; }
        public int Persent { get; set; }
    }
    public class TsTasksVwFilterDto
    {
        public string? Subject { get; set; }
        public string? AssigneeToUserId { get; set; } = string.Empty;
        //public long? UserId { get; set; }
        public long? ProjectCode { get; set; }
        public int? StatusId { get; set; }
        public long? ClassificationId { get; set; }
        public long? ParentId { get; set; }
        public string? UserFullname { get; set; }
        public string? ProjectName { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public long? ProjectPlansId { get; set; }
        public string? ItemCode { get; set; }
        public string? SendDate1 { get; set; }
        public string? SendDate2 { get; set; }
        public string? DueDate1 { get; set; }
        public string? DueDate2 { get; set; }
		public string? ReferenceCode { get; set; }
	}

}
