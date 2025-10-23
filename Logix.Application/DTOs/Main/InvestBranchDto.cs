using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class InvestBranchDto
    {
        public int BranchId { get; set; }
        [Required]
        public string? BraName { get; set; }

        [StringLength(50)]
        [Required]
        public string? Telephone { get; set; }

        [StringLength(50)]
        [Required]
        public string? Mobile { get; set; }

        [StringLength(50)]
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }

        public long? UserId { get; set; }

        public bool Isdel { get; set; } = false;
        public bool Auto { get; set; } = true;

        public int CcId { get; set; } = 0;

        //this two field are for display, not found in InvestBranch tbl
        public string? CostCenterCode { get; set; }
        public string? CostCenterName { get; set; }
        //
        [StringLength(50)]
        public string? BranchCode { get; set; }
        [StringLength(150)]
        public string? MapLat { get; set; }
        [StringLength(150)]
        public string? MapLng { get; set; }
        public bool IsActive { get; set; } = true;
        [Range(1, long.MaxValue)]
        public long? FacilityId { get; set; }
        [Required]
        public string? BraName2 { get; set; }

        [StringLength(50)]
        public string? CodeFormat { get; set; }
        [StringLength(250)]
        public string? WebSite { get; set; }
        public long? BranchTypeId { get; set; }
        public long? CategoryId { get; set; }

        public string? IdNumber { get; set; }
        public int? IdentityType { get; set; }
        public string? RegionName { get; set; }
        public string? StreetName { get; set; }
        public string? DistrictName { get; set; }
        public string? CountryCode { get; set; }
        [StringLength(10)]
        public string? BuildingNumber { get; set; }
        public string? PostalCode { get; set; }
        public string? AdditionalStreetAddress { get; set; }
        public string? City { get; set; }
        public string? ShortAddress { get; set; }
    }

    public class InvestBranchFilterDto
    {
        public string? BraName { get; set; }
        public long? FacilityId { get; set; }
    }
}
