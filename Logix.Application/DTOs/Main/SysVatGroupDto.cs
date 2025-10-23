using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{

    public class SysVatGroupFilterDto
    {

        public string? VatName { get; set; }

        public decimal? VatRate { get; set; }

    }
    public class SysVatGroupDto
    {

        public long VatId { get; set; }

        [StringLength(50)]
        [Required]
        public string? VatName { get; set; }
        [Required]
        public decimal? VatRate { get; set; }
        //[Required]
        public long? SalesVatAccountId { get; set; }
        //[Required]
        public long? PurchasesVatAccountId { get; set; }

        public long? FacilityId { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [Required]
        public string? SalesVatAccountCode { get; set; }
        [Required]
        public string? PurchasesVatAccountCode { get; set; }
    }
    public class SysVatGroupEditDto
    {

        public long VatId { get; set; }

        [StringLength(50)]
        [Required]
        public string? VatName { get; set; }
        [Required]
        public decimal? VatRate { get; set; }
        //[Required]
        public long? SalesVatAccountId { get; set; }
        //[Required]
        public long? PurchasesVatAccountId { get; set; }


        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? SalesVatAccountCode { get; set; }
        public string? SalesVatAccountName { get; set; }

        public string? PurchasesVatAccountCode { get; set; }
        public string? PurchasesVatAccountName { get; set; }

    }


}
