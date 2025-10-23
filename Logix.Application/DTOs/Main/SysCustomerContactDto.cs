using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysCustomerContactDto
    {
        public long Id { get; set; }
        public int? CusId { get; set; }

        [StringLength(50)]
        //[Required]
        public string? IdNo { get; set; }
        [StringLength(1500)]

        [Required]
        public string? Name { get; set; }

        [StringLength(1500)]

        [Required]
        public string? JobName { get; set; }

        [StringLength(2500)]

        public string? JobAddress { get; set; }
        [StringLength(50)]
        [Required]
        public string? Mobile { get; set; }
        [StringLength(50)]

        public string? Phone { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
        ErrorMessage = "Invalid email address")]
        public string? Email2 { get; set; }
        [StringLength(50)]

        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
        ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? AcademicDegree { get; set; }
        public string? Experiences { get; set; }
    }
}
