using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logix.Application.DTOs.FXA
{
    public class FxaAdditionsExclusionFilterDto
    {
        public long? Id { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public long? FixedAssetNo { get; set; }
        public string? FixedAssetName { get; set; }

        //
        public string? Date1 { get; set; }
        public string? TypeName { get; set; }
        public string? Description { get; set; }
        public decimal? CreditOrDebit { get; set; }
        public bool? AffectAge { get; set; }
        public bool? AffectPriceAsset { get; set; }
        public bool? AffectInstallment { get; set; }

    }

    public class FxaAdditionsExclusionDto
    {
        public long? Id { get; set; }
        public long? JId { get; set; }
        public string? JCode { get; set; }
        [Range(1, long.MaxValue)]
        public long? PeriodId { get; set; }
        [Required]
        [StringLength(10)]
        public string? Date1 { get; set; }
        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }

        [Required]
        public long? FxNo { get; set; }
        public decimal? FxAmount { get; set; }
        public decimal? DeprecAmount { get; set; }
        public decimal? Balance { get; set; }

        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        [Required]
        [StringLength(250)]
        public string? Description { get; set; }
        [Required]
        public decimal? Amount { get; set; }
        [Required]
        public decimal? VatRate { get; set; }
        public decimal? VatAmount { get; set; }

        [Required]
        public string? AccountCode { get; set; }
        [Range(1, long.MaxValue)]
        public int? AccountTypeId { get; set; }
        public string? CrdAccountCode { get; set; }

        public bool AffectAge { get; set; } = false;
        [StringLength(10)]
        public string? AffectAgeDate { get; set; }
        public bool AffectPriceAsset { get; set; } = false;
        public decimal? AssetPrice { get; set; }
        public bool AffectInstallment { get; set; } = false;
        public decimal? InstallmentValue { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int OperationType { get; set; } // type of add (addition = 1, exclusion = 2)
    }

    public class FxaAdditionsExclusionEditDto
    {
        public long? Id { get; set; }
        public long? JId { get; set; }
        public string? JCode { get; set; }
        [Range(1, long.MaxValue)]
        public long? PeriodId { get; set; }
        [Required]
        [StringLength(10)]
        public string? Date1 { get; set; }
        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }

        [Required]
        public long? FxNo { get; set; }
        public decimal? FxAmount { get; set; }
        public decimal? DeprecAmount { get; set; }
        public decimal? Balance { get; set; }

        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        [Required]
        [StringLength(250)]
        public string? Description { get; set; }
        [Required]
        public decimal? Amount { get; set; }
        [Required]
        public decimal? VatRate { get; set; }
        public decimal? VatAmount { get; set; }

        [Required]
        public string? AccountCode { get; set; }
        [Range(1, long.MaxValue)]
        public int? AccountTypeId { get; set; }
        public string? CrdAccountCode { get; set; }

        public bool AffectAge { get; set; } = false;
        [StringLength(10)]
        public string? AffectAgeDate { get; set; }
        public bool AffectPriceAsset { get; set; } = false;
        public decimal? AssetPrice { get; set; }
        public bool AffectInstallment { get; set; } = false;
        public decimal? InstallmentValue { get; set; }
        public int OperationType { get; set; } // type of add (addition = 1, exclusion = 2)
    }
}