using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.FXA
{
    public class FxaTransactionDto_Revaluation
    {
        public long? Id { get; set; } // id of fxaTransactions table
        public int? TransTypeId { get; set; }
        public long? FacilityId { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        public string? JCode { get; set; }
        public long? JId { get; set; }
        [Range(1, long.MaxValue)]
        public long? PeriodId { get; set; }

        [Required]
        [StringLength(10)]
        public string? TransDate { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }

        //public int? AccountType { get; set; }
        //[Required]
        //public string? DebAccCode { get; set; }

        [Required]
        public string? ProfitLossAccCode { get; set; }

        public string? CcCode { get; set; }
        public string? CcCode2 { get; set; }
        public string? CcCode3 { get; set; }
        public string? CcCode4 { get; set; }
        public string? CcCode5 { get; set; }
        [Required]
        public long? FxNo { get; set; }
        [Required]
        public string? AccCode { get; set; }
        [Required]
        public string? AccCode2 { get; set; }
        [Required]
        public string? AccCode3 { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        public decimal? DeprecAmount { get; set; }

        public decimal? Balance { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }
        [Required]
        public decimal? SaleAmount { get; set; } //new value for asset
        
        //public string? Note { get; set; }
        //public List<SaveFileDto>? FileDtos { get; set; }
    }
}