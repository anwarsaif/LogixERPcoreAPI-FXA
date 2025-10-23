using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logix.Domain.TS;
using Logix.Application.DTOs.Main;
using Logix.Domain.PM;

namespace Logix.Application.DTOs.TS
{
    public class TsTaskDto
    {
        public long? Id { get; set; }

        public string? Subject { get; set; }

        public string? Message { get; set; }

        public int? WorkFlowType { get; set; }

        public string? AssigneeToUserId { get; set; }

        public string? AssigneeToGroupId { get; set; }

        public string? DueDate { get; set; }
        public string? FileUrl { get; set; }

        public decimal? RequiredApprovalPercentage { get; set; }

        public bool? SendEmailNotifications { get; set; }
        public bool? SendSMSNotifications { get; set; }
        public bool? FollowUp { get; set; }

        public int? Priority { get; set; }

        public long? ParentId { get; set; }

        public bool? Isdel { get; set; }

        public long? UserId { get; set; }

        public DateTime? CreatedIn { get; set; }
        public string? EndDateApponitment { get; set; }
        public string? SendDateApponitment { get; set; }

        public int? StatusId { get; set; }

        public string? ReferenceCode { get; set; }

        public long? ModifiedBy { get; set; }

        public string? Comment { get; set; }

        public int? DeptId { get; set; }

        public string? SendDate { get; set; }

        public long? ProjectId { get; set; }

        /// <summary>
        /// تاريخ اغلاق المهمة
        /// </summary>
        public string? DoneOn { get; set; }

        public TimeSpan? Duration { get; set; }
        public string? DurationString { get; set; }

        public decimal? PercentageOfProject { get; set; }

        public decimal? CompletionRate { get; set; }

        public string? Depend { get; set; }

        public int? DurationType { get; set; }

        public long? ProjectPlansId { get; set; }

        public string? Durations { get; set; }

        public long? FacilityId { get; set; }

        public int? TypeId { get; set; }

        public long? DeliverableId { get; set; }

        public string? Wbs { get; set; }

        public string? ActualStartDate { get; set; }

        public string? ActualEndDate { get; set; }

        public string? Type { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitPriceTotal { get; set; }

        public long? ActivityId { get; set; }

        public long? ClassificationId { get; set; }

        public string? ExpectedTime { get; set; }

        public string? RealTime { get; set; }
        public long? ExpectedMinutes { get; set; }
        public long? RealMinutes { get; set; }
    }

    public class TsTaskRep1FilterDto
    {
        public string? Subject { get; set; }
        public int? StatusId { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? DueFrom { get; set; }
        public string? DueTo { get; set; }
        public string? EmpName { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        //public string? SendDate { get; set; }
        //public string? DueDate { get; set; }


    }
    
    public class TsTaskRep2FilterDto
    {
        public string? EmpName { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
    }

    #region =====================================  تقرير الانجاز        
    public class TsTaskRep2Dto
    {
        public string? UserFulname { get; set; }
        public int? All { get; set; }
        public int? Completed { get; set; }
        public int? Open { get; set; }
        public int? CompletedBef { get; set; }
        public int? CompletedOn { get; set; }
        public int? CompletedLate { get; set; }
        public int? Points { get; set; }
    }

    #endregion

    #region =====================================  تقرير بالمهام حسب الحالة        
    public class TsTaskRep3Dto
    {
        public string? UserFulname { get; set; }
        public int? Status_1 { get; set; }
        public int? Status_2 { get; set; }
        public int? Status_3 { get; set; }
        public int? Status_5 { get; set; }
        public int? Status_10 { get; set; }
        //public int? SumStatus_1 { get; set; }
        //public int? SumStatus_2 { get; set; }
        //public int? SumStatus_3 { get; set; }
        //public int? SumStatus_5 { get; set; }
        //public int? SumStatus_10 { get; set; }
    }
    #endregion

    public class TsTaskEditDto
    {
        public long Id { get; set; }

        public string? Subject { get; set; }

        public string? Message { get; set; }

        public int? WorkFlowType { get; set; }

        public string? AssigneeToUserId { get; set; }

        public string? AssigneeToGroupId { get; set; }

        public string? DueDate { get; set; }
        public string? FileUrl { get; set; }

        public decimal? RequiredApprovalPercentage { get; set; }

        public bool? SendEmailNotifications { get; set; }
        public bool? SendSMSNotifications { get; set; }
        public bool? FollowUp { get; set; }

        public int? Priority { get; set; }

        public long? ParentId { get; set; }

        public bool? Isdel { get; set; }

        public long? UserId { get; set; }

        public DateTime? CreatedIn { get; set; }

        public int? StatusId { get; set; }

        public string? ReferenceCode { get; set; }

        public long? ModifiedBy { get; set; }

        public string? Comment { get; set; }

        public int? DeptId { get; set; }

        public string? SendDate { get; set; }

        public long? ProjectId { get; set; }

        /// <summary>
        /// تاريخ اغلاق المهمة
        /// </summary>
        public string? DoneOn { get; set; }

        public TimeOnly? Duration { get; set; }
        public string? DurationString { get; set; }

        public decimal? PercentageOfProject { get; set; }

        public decimal? CompletionRate { get; set; }

        public string? Depend { get; set; }

        public int? DurationType { get; set; }

        public long? ProjectPlansId { get; set; }

        public string? Durations { get; set; }

        public long? FacilityId { get; set; }

        public int? TypeId { get; set; }

        public long? DeliverableId { get; set; }

        public string? Wbs { get; set; }

        public string? ActualStartDate { get; set; }

        public string? ActualEndDate { get; set; }

        public string? Type { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitPriceTotal { get; set; }

        public long? ActivityId { get; set; }

        public long? ClassificationId { get; set; }

        public string? ExpectedTime { get; set; }

        public string? RealTime { get; set; }
    }


    //public class TsTaskEditDto
    //{
    //    public long Id { get; set; }

    //    public string? Subject { get; set; }

    //    public string? Message { get; set; }

    //    public int? WorkFlowType { get; set; }

    //    public string? AssigneeToUserId { get; set; }

    //    public string? AssigneeToGroupId { get; set; }

    //    [StringLength(10)]
    //    public string? DueDate { get; set; }

    //    public decimal? RequiredApprovalPercentage { get; set; }

    //    public bool? SendEmailNotifications { get; set; }

    //    public int? Priority { get; set; }

    //    public long? ParentId { get; set; }

    //    public bool? IsDeleted { get; set; }

    //    public long? UserId { get; set; }



    //    public int? StatusId { get; set; }

    //    [StringLength(50)]
    //    public string? ReferenceCode { get; set; }

    //    public long? ModifiedBy { get; set; }

    //    public string? Comment { get; set; }

    //    public int? DeptId { get; set; }

    //    [StringLength(10)]
    //    public string? SendDate { get; set; }

    //    public long? ProjectId { get; set; }

    //    [StringLength(10)]
    //    public string? DoneOn { get; set; }


    //    public string? Duration { get; set; }
    //    //    Duration  بدلا عن 
    //    public string? DurationString { get; set; }

    //    public decimal? PercentageOfProject { get; set; }
    //    public decimal? CompletionRate { get; set; }
    //    public string? Depend { get; set; }

    //    public int? DurationType { get; set; }

    //    public long? ProjectPlansId { get; set; }

    //    [StringLength(50)]
    //    public string? Durations { get; set; }

    //    public long? FacilityId { get; set; }

    //    public int? TypeId { get; set; }

    //    public long? DeliverableId { get; set; }

    //    [StringLength(50)]
    //    public string? Wbs { get; set; }

    //    [StringLength(10)]
    //    public string? ActualStartDate { get; set; }

    //    [StringLength(10)]
    //    public string? ActualEndDate { get; set; }

    //    [StringLength(250)]
    //    public string? Type { get; set; }

    //    public decimal? Qty { get; set; }

    //    public decimal? UnitPrice { get; set; }

    //    public decimal? UnitPriceTotal { get; set; }

    //    public long? ActivityId { get; set; }

    //    public long? ClassificationId { get; set; }

    //}

    public class TsMainTaskEditDto
    {
        public long Id { get; set; }
        public string? StartDate { get; set; }
        public string? Date { get; set; }
        public string? AssigneeToUserId { get; set; }
        public string? AssigneeToGroupId { get; set; }
        public string? DueDate { get; set; }
        public string? SendDate { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public int? Priority { get; set; }
        public long? UserId { get; set; }
        public long? ProjectId { get; set; }
        public long? ParentId { get; set; }
        public decimal? PercentageOfProject { get; set; }
        public string? Depend { get; set; }
        public long? ClassificationId { get; set; }
    }
    
    public class TsCompeletedTaskDto
    {
        public long Id { get; set; }

        public string? Subject { get; set; }

        public string? Message { get; set; }
        public string? FileUrl { get; set; }

        public int? WorkFlowType { get; set; }

        public string? AssigneeToUserId { get; set; }

        public string? AssigneeToGroupId { get; set; }

        [StringLength(10)]
        public string? DueDate { get; set; }

        public decimal? RequiredApprovalPercentage { get; set; }

        public bool? SendEmailNotifications { get; set; }

        public int? Priority { get; set; }

        public long? ParentId { get; set; }

        public bool? IsDeleted { get; set; }

        public long? UserId { get; set; }


        public DateTime? CreatedIn { get; set; }

        public int? StatusId { get; set; }

        [StringLength(50)]
        public string? ReferenceCode { get; set; }

        public long? ModifiedBy { get; set; }

        public string? Comment { get; set; }

        public int? DeptId { get; set; }

        [StringLength(10)]
        public string? SendDate { get; set; }

        public long? ProjectId { get; set; }
        public string? ProjectCode { get; set; }

        [StringLength(10)]
        public string? DoneOn { get; set; }

        [Precision(5)]
        public TimeSpan? Duration { get; set; }
        //    Duration  بدلا عن 
        public string? DurationString { get; set; }

        public decimal? PercentageOfProject { get; set; }
        public decimal? CompletionRate { get; set; }
        public string? Depend { get; set; }

        public int? DurationType { get; set; }

        public long? ProjectPlansId { get; set; }

        [StringLength(50)]
        public string? Durations { get; set; }

        public long? FacilityId { get; set; }

        public int? TypeId { get; set; }

        public long? DeliverableId { get; set; }

        [StringLength(50)]
        public string? Wbs { get; set; }

        [StringLength(10)]
        public string? ActualStartDate { get; set; }

        [StringLength(10)]
        public string? ActualEndDate { get; set; }

        [StringLength(250)]
        public string? Type { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitPriceTotal { get; set; }

        public long? ActivityId { get; set; }

        public long? ClassificationId { get; set; }
        public List<TsTasksResponse>? TaskResponses { get; set; }
    }

    public class TsTaskDetailsVwDto
    {
        public TsTasksVw? Task { get; set; }
        public List<TsTasksResponseVw>? TaskResponses { get; set; }
        public List<SysGroupIdNameDto>? AssigneeToGroupId { get; set; }
        public List<UserIdNameDto>? AssigneeToUserId { get; set; }
        public List<PmProjectsFilesVw>? Files { get; set; }
    }

    public class TsTaskDetailsEditDto
    {
        public long Id { get; set; }

       

        public string? AssigneeToUserId { get; set; }

      
        public bool? IsDeleted { get; set; }

        public long? UserId { get; set; }


  

        public int? StatusId { get; set; }

      

        public long? ModifiedBy { get; set; }

        public string? Comment { get; set; }

       


        public string? Duration { get; set; }
       
        public decimal? CompletionRate { get; set; }
       

        [StringLength(50)]
        public string? Durations { get; set; }


    }

    public class TsStatisticsDto
    {
        public int Count { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string StatusName2 { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }

    public class TsMyTsBoardStatisticsDto
    {
        public long? StatusId { get; set; }
        public int Count { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string StatusName2 { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public List<TsTaskDto>? tasks { get; set; }
    }

    public class TsTaskIdAndStatusDto
    {
        public long TaskId { get; set; }
        public int StatusId { get; set; }
    }

    public class TsCompeletedTaskAddDto
    {

        public string Subject { get; set; } = null!;
        public string DueDate { get; set; } = null!;

        public string? Message { get; set; } = null!;
        public string? FileUrl { get; set; }
        public long? ProjectCode { get; set; }

    }
}