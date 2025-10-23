using Logix.Application.DTOs.Main;
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmChangeRequestDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        /// <summary>
        /// </summary>
        public long? ProjectCode { get; set; }
        public string CrDate { get; set; } = null!;
        public long? RequesterEmpId { get; set; }
        public string? RequesterEmpCode { get; set; }
        public int? Priority { get; set; }
        public int? IsDiscussed { get; set; }
        public string? DueDate { get; set; }
        public string? DueDateDecision { get; set; }
        public int? CrType { get; set; }
        public string? Description { get; set; }
        public int? EffectType { get; set; }
        public string? Effect { get; set; }
        public decimal? CrCost { get; set; }
        public decimal? PrevCrCost { get; set; }
        public decimal? BeforProjectCost { get; set; }
        public decimal? AfterProjectCost { get; set; }
        public string? BeforProjectEndDate { get; set; }
        public string? AfterProjectEndDate { get; set; }
        public int? CrDuration { get; set; }
        public int? CrDurationType { get; set; }
        public string? Importance { get; set; }
        public string? Implications { get; set; }
        public long? AppId { get; set; }
        public long? StatusId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ManagerId { get; set; }
        public string? ManagerCode { get; set; }
        public string? EffectTypeList { get; set; }
        public string? DeliverablesList { get; set; }
        public string? ItemsList { get; set; }
        public string? GoalsEffect { get; set; }
        public string? ProjectStrategicGoalsEffect { get; set; }
        public string? Hreffect { get; set; }
        public string? OtherEffect { get; set; }
        public string? ProjectProgressEffect { get; set; }
        public string? ProgressBasedOnReport { get; set; }
        public string? OtherProjectToChange { get; set; }
        public string? NotChangeEffect { get; set; }
        public long? OwnerId { get; set; }
        public string? OwnerCode { get; set; }
        public bool? ChangeProjectCost { get; set; }
        public bool? ChangeProjectDuration { get; set; }
        public bool? ChangeProjectManager { get; set; }
        public bool? ChangeProjectOwner { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }
        public int? AppTypeId { get; set; }


    }

    public class PmChangeRequestEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        /// <summary>
        /// </summary>
        public long? ProjectCode { get; set; }
        public string CrDate { get; set; } = null!;
        public long? RequesterEmpId { get; set; }
        public string? RequesterEmpCode { get; set; }
        public int? Priority { get; set; }
        public int? IsDiscussed { get; set; }
        public string? DueDate { get; set; }
        public string? DueDateDecision { get; set; }
        public int? CrType { get; set; }
        public string? Description { get; set; }
        public int? EffectType { get; set; }
        public string? Effect { get; set; }
        public decimal? CrCost { get; set; }
        public decimal? PrevCrCost { get; set; }
        public decimal? BeforProjectCost { get; set; }
        public decimal? AfterProjectCost { get; set; }
        public string? BeforProjectEndDate { get; set; }
        public string? AfterProjectEndDate { get; set; }
        public int? CrDuration { get; set; }
        public int? CrDurationType { get; set; }
        public string? Importance { get; set; }
        public string? Implications { get; set; }
        public long? AppId { get; set; }
        public long? StatusId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ManagerId { get; set; }
        public string? ManagerCode { get; set; }
        public string? EffectTypeList { get; set; }
        public string? DeliverablesList { get; set; }
        public string? ItemsList { get; set; }
        public string? GoalsEffect { get; set; }
        public string? ProjectStrategicGoalsEffect { get; set; }
        public string? Hreffect { get; set; }
        public string? OtherEffect { get; set; }
        public string? ProjectProgressEffect { get; set; }
        public string? ProgressBasedOnReport { get; set; }
        public string? OtherProjectToChange { get; set; }
        public string? NotChangeEffect { get; set; }
        public long? OwnerId { get; set; }
        public string? OwnerCode { get; set; }
        public bool? ChangeProjectCost { get; set; }
        public bool? ChangeProjectDuration { get; set; }
        public bool? ChangeProjectManager { get; set; }
        public bool? ChangeProjectOwner { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }

    }

    public class PMChangeRequestFilterDto
    {
        public string? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public int? EffectType { get; set; }
        public int? CrType { get; set; }
        public int? Priority { get; set; }
        public int? IsDiscussed { get; set; }

        public decimal? CrCost { get; set; }

    }


    public class PmChangeRequestAdd2Dto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        /// <summary>
        /// </summary>
        //public long? ProjectCode { get; set; }
        public string CrDate { get; set; } = null!;
        public long? RequesterEmpId { get; set; }
        public string? RequesterEmpCode { get; set; }
        public int? Priority { get; set; }
        public int? IsDiscussed { get; set; }
        public string? DueDate { get; set; }
        public string? DueDateDecision { get; set; }
        public int? CrType { get; set; }
        public string? Description { get; set; }
        public int? EffectType { get; set; }
        public string? Effect { get; set; }
        public decimal? CrCost { get; set; }
        public decimal? PrevCrCost { get; set; }
        public decimal? BeforProjectCost { get; set; }
        public decimal? AfterProjectCost { get; set; }
        public string? BeforProjectEndDate { get; set; }
        public string? AfterProjectEndDate { get; set; }
        public int? CrDuration { get; set; }
        public int? CrDurationType { get; set; }
        public string? Importance { get; set; }
        public string? Implications { get; set; }
        public long? AppId { get; set; }
        public long? StatusId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ManagerId { get; set; }
        public string? ManagerCode { get; set; }
        public string? EffectTypeList { get; set; }
        public string? DeliverablesList { get; set; }
        public string? ItemsList { get; set; }
        public string? GoalsEffect { get; set; }
        public string? ProjectStrategicGoalsEffect { get; set; }
        public string? Hreffect { get; set; }
        public string? OtherEffect { get; set; }
        public string? ProjectProgressEffect { get; set; }
        public string? ProgressBasedOnReport { get; set; }
        public string? OtherProjectToChange { get; set; }
        public string? NotChangeEffect { get; set; }
        public long? OwnerId { get; set; }
        public string? OwnerCode { get; set; }
        public bool? ChangeProjectCost { get; set; }
        public bool? ChangeProjectDuration { get; set; }
        public bool? ChangeProjectManager { get; set; }
        public bool? ChangeProjectOwner { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }
        public int? AppTypeId { get; set; }

        public List<PMProjectsItem2Dto>? ProjectsItem { get; set; }
    }


    public class PmChangeRequestEdit2Dto
    {
        public long Id { get; set; }
        public string CrDate { get; set; } = null!;
        public long? RequesterEmpId { get; set; }
        public string? RequesterEmpCode { get; set; }
        public int? Priority { get; set; }
        public int? IsDiscussed { get; set; }
        public string? DueDate { get; set; }
        public string? DueDateDecision { get; set; }
        public int? CrType { get; set; }
        public string? Description { get; set; }
        public int? EffectType { get; set; }
        public string? Effect { get; set; }
        public decimal? CrCost { get; set; }
        public decimal? PrevCrCost { get; set; }
        public decimal? BeforProjectCost { get; set; }
        public decimal? AfterProjectCost { get; set; }
        public string? BeforProjectEndDate { get; set; }
        public string? AfterProjectEndDate { get; set; }
        public int? CrDuration { get; set; }
        public int? CrDurationType { get; set; }
        public string? Importance { get; set; }
        public string? Implications { get; set; }
        public long? AppId { get; set; }
        public long? StatusId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ManagerId { get; set; }
        public string? ManagerCode { get; set; }
        public string? EffectTypeList { get; set; }
        public string? DeliverablesList { get; set; }
        public string? ItemsList { get; set; }
        public string? GoalsEffect { get; set; }
        public string? ProjectStrategicGoalsEffect { get; set; }
        public string? Hreffect { get; set; }
        public string? OtherEffect { get; set; }
        public string? ProjectProgressEffect { get; set; }
        public string? ProgressBasedOnReport { get; set; }
        public string? OtherProjectToChange { get; set; }
        public string? NotChangeEffect { get; set; }
        public long? OwnerId { get; set; }
        public string? OwnerCode { get; set; }
        public bool? ChangeProjectCost { get; set; }
        public bool? ChangeProjectDuration { get; set; }
        public bool? ChangeProjectManager { get; set; }
        public bool? ChangeProjectOwner { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }
        public int? AppTypeId { get; set; }

        public List<PMChangeRequestProjectsItem2Dto>? ProjectsItem { get; set; }
    }
    //  لاضافة البنود في شاشة طلب تغيير متقدم جديد2 
    public class PMProjectsItem2Dto
    {
        public long? Id { get; set; }

        public string? ItemName { get; set; }

        public long? ProjectId { get; set; } = 0;

        public long? ItemId { get; set; } = 0;
        [StringLength(50)]
        public string? ItemCode { get; set; }

        public int? UnitId { get; set; } = 0;

        [StringLength(50)]
        public string? UnitName { get; set; }
        public decimal? Qty { get; set; } = 0;
        public decimal? UnitPrice { get; set; } = 0;
        public decimal? Total { get; set; } = 0;
        public long? ParentId { get; set; } = 0;
        public string? Note { get; set; }
        public decimal? Difference { get; set; }

    }


    //  لاضافة  وتعديل البنود في شاشة  تعديل طلب تغيير متقدم جديد2 
    public class PMChangeRequestProjectsItem2Dto
    {
        public long? Id { get; set; }

        public string? ItemName { get; set; }
        public long? ItemId { get; set; } = 0;
        public string? ItemCode { get; set; }

        public int? UnitId { get; set; } = 0;
        public string? UnitName { get; set; }
        public decimal? Qty { get; set; } = 0;
        public decimal? Price { get; set; } = 0;
        public long? ParentId { get; set; } = 0;
        public string? Note { get; set; }
    }
}
