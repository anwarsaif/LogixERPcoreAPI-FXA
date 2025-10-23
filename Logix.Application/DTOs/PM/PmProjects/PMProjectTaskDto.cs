using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.PM.PmProjects
{

    public class PMProjectTaskDto
    {
        public long Id { get; set; }

        public string? Subject { get; set; }

        public string? Message { get; set; }

        public int? WorkFlowType { get; set; } = 0;

        public string? AssigneeToUserId { get; set; }

        public string? AssigneeToGroupId { get; set; }

        [StringLength(10)]
        public string? DueDate { get; set; }

        public decimal? RequiredApprovalPercentage { get; set; } = 0;

        public bool? SendEmailNotifications { get; set; } = false;

        public int? Priority { get; set; } = 0;

        public long? ParentId { get; set; } = 0;


        public long? UserId { get; set; }




        public int? StatusId { get; set; } = 0;

        [StringLength(50)]
        public string? ReferenceCode { get; set; }


        public string? Comment { get; set; }

        public int? DeptId { get; set; } = 0;

        [StringLength(10)]
        public string? SendDate { get; set; }

        public long? ProjectId { get; set; }

        [StringLength(10)]
        public string? DoneOn { get; set; }

        /* [Precision(5)]
         public TimeSpan? Duration { get; set; }*/

        public decimal? PercentageOfProject { get; set; } = 0;
        public decimal? CompletionRate { get; set; } = 0;
        public string? Depend { get; set; }

        public int? DurationType { get; set; } = 0;

        public long? ProjectPlansId { get; set; } = 0;

        [StringLength(50)]
        public string? Durations { get; set; }

        public long? FacilityId { get; set; } = 0;

        public int? TypeId { get; set; } = 0;

        public long? DeliverableId { get; set; } = 0;

        [StringLength(50)]
        public string? Wbs { get; set; }

        [StringLength(10)]
        public string? ActualStartDate { get; set; }

        [StringLength(10)]
        public string? ActualEndDate { get; set; }

        [StringLength(250)]
        public string? Type { get; set; }

        public decimal? Qty { get; set; } = 0;

        public decimal? UnitPrice { get; set; } = 0;

        public decimal? UnitPriceTotal { get; set; } = 0;

        public long? ActivityId { get; set; } = 0;

        public long? ClassificationId { get; set; } = 0;
        //use  only  in api 
        public bool SendSMSNotifications { get; set; } = false;
        public List<int> AssigneeToUserIdList { get; set; } = new List<int>();
        public string? AssigneeToUserNames { get; set; }//  يستخدم لعرض اسماء المستخدمين 


    }


}