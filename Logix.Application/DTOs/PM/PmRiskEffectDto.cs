using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.PM
{
    public class PmRiskEffectDto
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
    public class PmRiskEffectEditDto
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
}
