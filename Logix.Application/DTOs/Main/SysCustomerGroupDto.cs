using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysCustomerGroupFilterDto
    {
        public int? CusTypeId { get; set; }
        public string? Name { get; set; }
    }

    public class SysCustomerGroupDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Range(1, long.MaxValue)]
        public int? CusTypeId { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; } = false;

        public long? ParentId { get; set; }

        public int? FacilityId { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }

        //for display
        public string? CusTypeName { get; set; }
    }

    public class SysCustomerGroupEditDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Range(1, long.MaxValue)]
        public int? CusTypeId { get; set; }

        //public long? ModifiedBy { get; set; }

        //public DateTime? ModifiedOn { get; set; }
        //public int? FacilityId { get; set; }

        public long? ParentId { get; set; }

        [StringLength(50)]
        public string? Code { get; set; }
    }
}
