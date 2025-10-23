
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.RPT
{
    public class RptCustomReportAddDto
    {
        public long Id { get; set; }

        [StringLength(250)]
        [Required]
        //[CustomDisplay("ar_name", "Common")]
        public string? Name { get; set; }
        [StringLength(250)]
        [Required]
        //[CustomDisplay("en_name", "Common")]
        public string? Name2 { get; set; }
        public bool IsDefault { get; set; }
        public List<string> UsersPermissionEdit { get; set; }
        public List<string> GoupsPermissionEdit { get; set; }
        public List<string> UsersAccess { get; set; }
        public List<string> GoupsAccess { get; set; }

        public int? DDltype { get; set; }
    }

    public class RptCustomReportDto
    {
        public long Id { get; set; }
        [StringLength(250)]
        [Required]
        public string? Name { get; set; }
        [StringLength(250)]
        [Required]
        public string? Name2 { get; set; }
        [Range(1, long.MaxValue)]
        public long? ScreenId { get; set; }
        public string? ReportLink { get; set; }
        public bool IsDeleted { get; set; }
        public bool? Active { get; set; }
        public int? ReportType { get; set; }
        public long? ReportId { get; set; }
        public bool IsDefault { get; set; }
        public string? UsersPermissionEdit { get; set; }
        public string? GoupsPermissionEdit { get; set; }
        public string? UsersAccess { get; set; }
        public string? GoupsAccess { get; set; }
        public int? FacilityId { get; set; }
        public bool IsMain { get; set; }

        // other variables used in add
        [Range(1, long.MaxValue)]
        public int? SystemId { get; set; }
        [Range(1, long.MaxValue)]
        public int? ParentId { get; set; }
        [Required]
        public string? Url { get; set; }

        //variables using only for display
        public string? ScreenName { get; set; }
        public string? ScreenName2 { get; set; }
        public string? ScreenUrl { get; set; }
        public string? SystemName { get; set; }
        public string? SystemName2 { get; set; }
        public string? Folder { get; set; }
    }

    public class RptCustomReportEditDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        //[CustomDisplay("System", "Main")]
        public int? SystemId { get; set; }

        [Range(1, long.MaxValue)]
        //[CustomDisplay("Tab", "Main")]
        public int? ParentId { get; set; }

        [Range(1, long.MaxValue)]
        //[CustomDisplay("Screen", "Main")]
        public long ScreenId { get; set; }
        [StringLength(250)]
        [Required]
        //[CustomDisplay("ar_name", "Common")]
        public string? Name { get; set; }

        [Required]
        //[CustomDisplay("en_name", "Common")]
        [StringLength(250)]
        public string? Name2 { get; set; }

        public string? ReportLink { get; set; }

        public IFormFile? UploadFile { get; set; }
        public bool Active { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public int? ReportType { get; set; }
        public long? ReportId { get; set; }
        public bool IsDefault { get; set; }
        public string? UsersPermissionEdit { get; set; }
        public string? GoupsPermissionEdit { get; set; }
        public string? UsersAccess { get; set; }
        public string? GoupsAccess { get; set; }
        public int? FacilityId { get; set; }
        public bool IsMain { get; set; }
    }

    public class RptCustomReportFilterDto
    {
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public int? SystemId { get; set; }
        public int? ParentId { get; set; }
        public long? ScreenId { get; set; }
    }
}
