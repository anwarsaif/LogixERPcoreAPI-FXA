using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysSettingExportFilterDto
    {
        public int? FacilityId { get; set; }
        public long? SystemId { get; set; }
        public long? ScreenId { get; set; }
    }

    public class SysSettingExportDto
    {
        public long Id { get; set; }

        public int? FacilityId { get; set; }

        [Range(1, long.MaxValue)]
        public long? SystemId { get; set; }

        [Range(1, long.MaxValue)]
        public long? ScreenId { get; set; }

        [StringLength(250)]
        [Required]
        public string? Name { get; set; }
        [StringLength(250)]
        public string? Name2 { get; set; }
        public int? Type { get; set; }

        [Required]
        public string? Query { get; set; }
        public bool? IsDeleted { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }
}