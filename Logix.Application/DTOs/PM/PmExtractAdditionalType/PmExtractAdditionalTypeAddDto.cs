using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM.PmExtractAdditionalType
{
    public class PmExtractAdditionalTypeAddDto
    {

        public long Id { get; set; }
        [Required]
        public long? Code { get; set; }
        [Required]
        public int? TypeId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? CreditOrDebit { get; set; }
        [Required]
        public int? RateOrAmount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public long? AccountId { get; set; }
        /*        public long? CreatedBy { get; set; }
                public DateTime? CreatedOn { get; set; }

                public bool? IsDeleted { get; set; }=false;*/
        [Required]
        public int? TotalOrNet { get; set; }
        public int? FacilityId { get; set; }

        public int? EncludRate { get; set; }

        public long? AccRefTypeId { get; set; }
        public string? AccAccountCode { get; set; }//  فقط  وقت الاضافة 
    }
}
