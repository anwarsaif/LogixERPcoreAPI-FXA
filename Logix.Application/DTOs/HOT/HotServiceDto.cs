using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.HOT
{
    public class HotServiceDto
    {
        public long Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]
        public decimal? Amount { get; set; }

        public string? Note { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
        [Required]
        public long? GroupId { get; set; }

        public bool? VatEnable { get; set; }
        [Required]
        public long? VatId { get; set; }
    }
    public class HotServiceEditDto
    {

        public long Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal? Amount { get; set; }

        public string? Note { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Required]
        public long? GroupId { get; set; }

        public bool? VatEnable { get; set; }
        [Required]
        public long? VatId { get; set; }
    }
}
