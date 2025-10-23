using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysLicenseFilterDto
    {
        public long? FacilityId { get; set; }
        public int? LicenseType { get; set; }
        public int? BranchId { get; set; }
        public string? LicenseNo { get; set; }
        public string? ExpireFrom { get; set; }
        public string? ExpireTo { get; set; }
    }

    public class SysLicenseDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        public long? FacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? JobCat { get; set; }
        [Range(1, long.MaxValue)]
        public int? LicenseType { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }

        [StringLength(50)]
        public string? LicenseNo { get; set; }

        [StringLength(50)]
        public string? LicenseFormerPlace { get; set; }

        [StringLength(10)]
        public string? IssuedDate { get; set; }

        [StringLength(10)]
        public string? ExpiryDate { get; set; }

        [StringLength(10)]
        public string? RenewalDate { get; set; }

        [StringLength(250)]
        public string? FileUrl { get; set; }

        public string? Note { get; set; }
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}