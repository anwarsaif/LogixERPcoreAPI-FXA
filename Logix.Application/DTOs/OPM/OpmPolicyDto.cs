using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.OPM
{
    public class OpmPolicyDto
    {
        public int Id { get; set; }

        public int? FacilityId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public int? TypeId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public int? AccordingTo { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string? Name2 { get; set; }

        [Required(ErrorMessage = "*")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Value { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class OpmPolicyEditDto
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public int? TypeId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public int? AccordingTo { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string? Name2 { get; set; }

        //[Required]
        [Required(ErrorMessage = "*")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Value { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
