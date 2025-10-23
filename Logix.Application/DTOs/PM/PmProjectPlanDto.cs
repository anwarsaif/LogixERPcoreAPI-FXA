using Logix.Application.DTOs.Main;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectPlanAddDto
    {
        public long? Id { get; set; }
        [Required]
        public long? ProjectCode { get; set; }
        [Required]
        public string? PlanDate { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Range(1, long.MaxValue)]
        public int? PlanType { get; set; }//ddl
        [Range(1, long.MaxValue)]
        public int? StatusId { get; set; }//ddl
        [Required]
        [StringLength(10)]
        public string? StartDate { get; set; }
        public int? DurationType { get; set; }
        [Required]
        [StringLength(10)]
        public string? EndDate { get; set; }

        [StringLength(250)]
        public int? Duration { get; set; }

        public string? Note { get; set; }
        public int? AppTypeId { get; set; }
       
        public string? Wbs { get; set; }


        public List<PMProjectPlanTaskDto> PMProjectPlanTaskList { get; set; } = new List<PMProjectPlanTaskDto>();
        public List<SaveFileDto>? fileDtos { get; set; }
    }
    public class PmProjectPlanFilterDto
    {
        public long? Id { get; set; }
        public int? PlanType { get; set; }
        public int? StatusId { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public long? ProjectCode { get; set; }

        //in return
        public string? PlanDate { get; set; }
        public string? Subject { get; set; }
        public string? ProjectName { get; set; }
        public string? PlanTypeName { get; set; }
        public string? StatusName { get; set; }
        public string? Note { get; set; }
        public int? TypeId { get; set; }
    }

    public class PmProjectPlanDto
    {
        public long Id { get; set; }
        [StringLength(10)]
        public string? PlanDate { get; set; }
        public long? ProjectId { get; set; }

        public int? PlanType { get; set; }
        public string? Subject { get; set; }

        public int? StatusId { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }

        public int? DurationType { get; set; }
        [StringLength(250)]
        public string? Duration { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public string? Note { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; } = false; // use in search
        public long? AppId { get; set; }
        public int? TypeId { get; set; }
        // not in database
        // public string? AppTypeId { get; set; } 
    }
    public class PmProjectPlanEditDto
    {
        public long Id { get; set; }
        [StringLength(10)]
        public string? PlanDate { get; set; }
        public long? ProjectId { get; set; }

        public int? PlanType { get; set; }
        public string? Subject { get; set; }

        public int? StatusId { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }

        public int? DurationType { get; set; }
        [StringLength(250)]
        public string? Duration { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public string? Note { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AppId { get; set; }
    }
    public class PMProjectPlanTaskDto
    {
        public long? Id { get; set; }
        public long? ProjectPlansId { get; set; } = 0;
        public long? ParentId { get; set; } = 0;
        // معرف من اجل معرفة رقم المهمة الاب لأي مهمة 
        public long? VirtualId { get; set; } = 0;
        [Required]
        public string? Subject { get; set; } //TxtTaskName
        [Required]
        public string? AssigneeToUserId { get; set; }
        [StringLength(10)]
        [Required]
        public string? StartDate { get; set; } //StartDate
        public int? DurationType { get; set; } = 0;
        [StringLength(50)]
        public string? Durations { get; set; }
        [StringLength(10)]
        [Required]
        public string? EndDate { get; set; } //EndDate

        [StringLength(10)]
        public string? ActualStartDate { get; set; }
        [StringLength(10)]
        public string? ActualEndDate { get; set; }

        [Required]
        public decimal? PercentageOfProject { get; set; } = 0;

        // to show in table after add
        [StringLength(50)]
        public string? Wbs { get; set; }
        public decimal? CompletionRate { get; set; } = 0;
        public decimal? ActualCompletionRate { get; set; } = 0;


        public int? StatusId { get; set; } = 0;
        public int? WorkFlowType { get; set; } = 1;
        public long? UserId { get; set; }//session 
        public int? Priority { get; set; } = 1;
        public int? DeptId { get; set; } = 0;
        public bool? IsDeleted { get; set; }
        public string? Depend { get; set; } = "0";
        public long? FacilityId { get; set; } = 0;
    }
}
