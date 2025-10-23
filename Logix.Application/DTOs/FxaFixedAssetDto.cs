using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logix.Application.DTOs.FXA
{
    public class FxaFixedAssetFilterDto
    {
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Name { get; set; }
        public long? LocationId { get; set; }
        public int? StatusId { get; set; }
        public int? TypeId { get; set; }
        public int? ClassificationId { get; set; }
        public int? BranchId { get; set; }
        [StringLength(50)]
        public string? OhdaEmpCode { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public int? AdditionTypeFilter { get; set; }

        public string? Description { get; set; }
    }

    public class FxaFixedAssetPopUpDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Name { get; set; }
    }

    public class FxaFixedAssetDto
    {
        public long Id { get; set; }
        //public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        public long? JId { get; set; }
        public string? JCode { get; set; }
        [Range(1, long.MaxValue)]
        public long? PeriodId { get; set; }
        [Required]
        [StringLength(10)]
        public string? PurchaseDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        
        [Required]
        public string? TypeCode { get; set; }
        public int? ClassificationId { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DeprecAmount { get; set; } //additional property
        [Required]
        [StringLength(10)]
        public string? LastDepreciationDate { get; set; }
        [Required]
        [StringLength(4000)]
        public string? Name { get; set; }
        [Required]
        public bool? AdditionType { get; set; }
        public long? MainAssetNo { get; set; } // required if addition type is SubAsset
        [Range(1, long.MaxValue)]
        public int? StatusId { get; set; }
        public decimal? ScrapValue { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        [Range(1, long.MaxValue)]
        public long? LocationId { get; set; }
        public string? EmpCode { get; set; }
        [Required]
        [StringLength(10)]
        public string? StartDate { get; set; }
        [Required]
        [StringLength(10)]
        public string? EndDate { get; set; }
        [Range(1, long.MaxValue)]
        public int? DeprecMethod { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DeprecYearlyRate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Annuity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DeprecMonthlyRate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? InstallmentValue { get; set; }
        [StringLength(4000)]
        public string? ImgUrl { get; set; }

        [Required]
        public string? AccountCode { get; set; }
        [Required]
        public string? AccountCode2 { get; set; }
        [Required]
        public string? AccountCode3 { get; set; }


        public bool? ChkLinkWithAcc { get; set; } // add journal entry?

        //public long? PurchaseAccountId { get; set; } // credit account id
        [Required]
        public string? PurchaseAccountCode { get; set; } // credit account code

        [Required]
        public string? CcCode { get; set; }
        public string? CcCode2 { get; set; }
        public string? CcCode3 { get; set; }
        public string? CcCode4 { get; set; }
        public string? CcCode5 { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        public decimal? InitialBalance { get; set; }
        public bool? IsDeleted { get; set; }
    }


    public class FxaFixedAssetEditDto
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Code { get; set; } // save No inside it
        public string? FxCode { get; set; } // save Code inside it
        [Range(1, long.MaxValue)]
        public long? PeriodId { get; set; }
        [StringLength(4000)]
        public string? ImgUrl { get; set; }

        [Required]
        public string? TypeCode { get; set; }
        public string? TypeName { get; set; }
        public int? ClassificationId { get; set; }
        [Required]
        [StringLength(4000)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Required]
        [StringLength(10)]
        public string? StartDate { get; set; }
        [Required]
        [StringLength(10)]
        public string? EndDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DeprecMonthlyRate { get; set; }
        [Range(1, long.MaxValue)]
        public int? DeprecMethod { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? InstallmentValue { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
        [Range(1, long.MaxValue)]
        public int? StatusId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? InitialBalance { get; set; }

        [Required]
        public string? AccountCode { get; set; }
        [Required]
        public string? AccountCode2 { get; set; }
        [Required]
        public string? AccountCode3 { get; set; }

        public string? AccountName { get; set; }
        public string? AccountName2 { get; set; }
        public string? AccountName3 { get; set; }

        public bool? ChkLinkWithAcc { get; set; } // add journal entry?

        [Range(1, long.MaxValue)]
        public long? LocationId { get; set; }
        [StringLength(10)]
        public string? PurchaseDate { get; set; }
        [StringLength(50)]
        public string? PurchaseOrder { get; set; }

        public string? PurchaseAccountCode { get; set; } // credit account code
        public string? PurchaseAccountName { get; set; } // credit account name

        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }

        public string? CcCode { get; set; }
        public string? CcName { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Annuity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DeprecYearlyRate { get; set; }
        [Required]
        [StringLength(10)]
        public string? LastDepreciationDate { get; set; }

        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public decimal? ScrapValue { get; set; }

        public string? CcCode2 { get; set; }
        public string? CcName2 { get; set; }

        public string? CcCode3 { get; set; }
        public string? CcName3 { get; set; }

        public string? CcCode4 { get; set; }
        public string? CcName4 { get; set; }

        public string? CcCode5 { get; set; }
        public string? CcName5 { get; set; }

        [Required]
        public bool? AdditionType { get; set; }

        public long? MainAssetNo { get; set; }

        public bool EnableSave { get; set; } = true;
    }
}