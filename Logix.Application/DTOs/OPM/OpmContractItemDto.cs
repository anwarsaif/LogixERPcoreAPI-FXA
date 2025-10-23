
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.OPM
{
    public class OpmContractItemDto
    {
        public long Id { get; set; }
        public int IncreasId { get; set; }

        public long? ContractId { get; set; }
        [Range(1, long.MaxValue)]
        public int? JobCatagoriesId { get; set; }
        [Range(1, long.MaxValue)]
        public int? NationalityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? GenderId { get; set; }
        [Range(1, long.MaxValue)]
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salary { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, long.MaxValue)]
        public decimal? Total { get; set; }
        [Range(1, long.MaxValue)]
        public int? CurrencyId { get; set; }
        [Range(1, long.MaxValue)]

        [Column(TypeName = "decimal(18, 10)")]
        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, long.MaxValue)]
        public decimal? WorkHours { get; set; }
        [Range(1, long.MaxValue)]
        public int? WorkDays { get; set; }
        [Range(1, long.MaxValue)]
        public int? OverTimePolicy { get; set; }
        [Range(1, long.MaxValue)]
        public int? AbsencePolicy { get; set; }
        public string? Description { get; set; }

        public long? AccountId { get; set; }

        public long? CcId { get; set; }

        public long? SalTId { get; set; }

        public long? SalPId { get; set; }

        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string? GenderName { get; set; }
        public string? JobCatagoriesName { get; set; }
        public string? NationalityName { get; set; }
        public string? ContractCode { get; set; }
        public string? ContractName { get; set; }
        public decimal? Net { get; set; }

        [Range(1, long.MaxValue)]
        public int? LatePolicy { get; set; }
    }
    public class OpmContractItemEditDto
    {
        public long Id { get; set; }

        public long? ContractId { get; set; }

        public int? JobCatagoriesId { get; set; }

        public int? NationalityId { get; set; }

        public int? GenderId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salary { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }

        public int? CurrencyId { get; set; }

        [Column(TypeName = "decimal(18, 10)")]
        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WorkHours { get; set; }

        public int? WorkDays { get; set; }

        public int? OverTimePolicy { get; set; }

        public int? AbsencePolicy { get; set; }

        public string? Description { get; set; }

        public long? AccountId { get; set; }

        public long? CcId { get; set; }

        public long? SalTId { get; set; }

        public long? SalPId { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? LatePolicy { get; set; }

    }

}
