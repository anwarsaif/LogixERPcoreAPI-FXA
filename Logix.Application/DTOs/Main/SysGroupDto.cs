using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysGroupFilterDto
    {
        public int? SystemId { get; set; }
        public string? GroupName { get; set; }
        public string? GroupName2 { get; set; }

        //
        public int? GroupId { get; set; }
        public string? SystemName { get; set; }
        public string? SystemName2 { get; set; }
    }

    public class SysGroupDto
    {
        public int? GroupId { get; set; }
        [Required]
        [StringLength(500)]
        public string? GroupName { get; set; }
        [Range(1, long.MaxValue)]
        public int? SystemId { get; set; }

        //public bool? Isdel { get; set; }

        public long? UserId { get; set; }

        [StringLength(2555)]
        public string? AppStatusFrom { get; set; }

        [StringLength(2555)]
        public string? AppStatusTo { get; set; }

        [StringLength(2555)]
        public string? DashboardWidget { get; set; }

        public long? FacilityId { get; set; }

        public TimeSpan? TimeFrom { get; set; }

        public TimeSpan? TimeTo { get; set; }
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        public string? GroupName2 { get; set; }
    }

    public class SysGroupIdNameDto
    {
        public int? GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? GroupName2 { get; set; }
    }

    public class SysGroupEditDto
    {
        public int GroupId { get; set; }
        [Required]
        [StringLength(500)]
        public string? GroupName { get; set; }
        [Range(1, long.MaxValue)]
        public int? SystemId { get; set; }

        [StringLength(2555)]
        public string? DashboardWidget { get; set; }
        //only for display
        public bool HasAutomationSys { get; set; } = false;

        //public long? ModifiedBy { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime? ModifiedOn { get; set; }

        [Required]
        public string? GroupName2 { get; set; }
    }

    public class CopyGroupVM
    {
        [Range(1, long.MaxValue)]
        public int? GroupId { get; set; }
        [Range(1, long.MaxValue)]
        public int? GroupId2 { get; set; }
    }
}
