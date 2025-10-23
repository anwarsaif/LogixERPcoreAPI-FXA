
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsInstallmentActionDto
    {
        public long Id { get; set; }
        [StringLength(10)]
        public string? InstallmentId { get; set; }
        [StringLength(10)]
        public string? FollowDate { get; set; }
        public string? FollowAction { get; set; }

        public int? FollowTypeId { get; set; }

        [StringLength(10)]
        public string? NextDate { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class PmProjectsInstallmentActionEditDto
    {
        public long Id { get; set; }
        [StringLength(10)]
        public string? InstallmentId { get; set; }
        [StringLength(10)]
        public string? FollowDate { get; set; }
        public string? FollowAction { get; set; }

        public int? FollowTypeId { get; set; }

        [StringLength(10)]
        public string? NextDate { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class AddCommentDto
    {
        public long? Id { get; set; }
        [Required]
        public List<long> InstallmentIds { get; set; }
        public string? FollowDate { get; set; }
        public string? FollowAction { get; set; }

        public int? FollowTypeId { get; set; }

        public string? NextDate { get; set; }
        public bool Ispaid{ get; set; }

    }
}
