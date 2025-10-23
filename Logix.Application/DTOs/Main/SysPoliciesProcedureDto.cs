using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysPoliciesProcedureFilterDto
    {
        public int? TypeId { get; set; }
        public string? Name { get; set; }
    }

    public class SysPoliciesProcedureDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }

        [Required]
        [StringLength(2500)]
        public string? Name { get; set; }

        [Required]
        [StringLength(2500)]
        public string? Name2 { get; set; }
        public string? FileUrl { get; set; }
        public bool IsActive { get; set; }
        public long? FacilityId { get; set; }
        public string? GroupsId { get; set; }

        //public IFormFile? FileUpload { get; set; }
        //public long CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        //public bool IsDeleted { get; set; }

    }

    public class SysPoliciesProcedureEditDto
    {
        public long Id { get; set; }

        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }

        [Required]
        [StringLength(2500)]
        public string? Name { get; set; }

        [Required]
        [StringLength(2500)]
        public string? Name2 { get; set; }
        public string? FileUrl { get; set; }
        public bool IsActive { get; set; }
        public string? GroupsId { get; set; }

        //public IFormFile? FileUpload { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }

    }
}
