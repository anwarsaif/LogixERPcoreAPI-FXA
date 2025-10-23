using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.FXA
{
    public class FxaTransactionFilterDto
    {
        public int? BranchId { get; set; }
        public long? Code { get; set; }
        public long? Code2 { get; set; }
        [StringLength(250)]
        public string? RefNumber { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public string? SupplierCode { get; set; }
        public int? PaymentTermsId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Subtotal { get; set; }
        public string? FxCode { get; set; }
    }

    public class FxaTransactionDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        public long? FacilityId { get; set; }
        public int? BranchId { get; set; }
        [StringLength(10)]
        public string? TransDate { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public int? StatusId { get; set; }
        public int? PaymentTermsId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Subtotal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(50)]
        public string? PurchaseOrder { get; set; }
        [StringLength(10)]
        public string? PurchaseDate { get; set; }
        public long? AccountId { get; set; }
        public long? SupplierId { get; set; }
        [StringLength(250)]
        public string? RefNumber { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        public long? LocationId { get; set; }
        public long? CcId { get; set; }
        public long? CcId2 { get; set; }
        public long? CcId3 { get; set; }
        public long? CcId4 { get; set; }
        public long? CcId5 { get; set; }
        public string? Note { get; set; }
        public bool? CreateNewId { get; set; }
        public long? AccountId2 { get; set; }
    }

    public class FxaTransactionEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        public int? TransTypeId { get; set; }
        public long? FacilityId { get; set; }
        public int? BranchId { get; set; }
        [StringLength(10)]
        public string? TransDate { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public int? StatusId { get; set; }
        public int? PaymentTermsId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Subtotal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }

        [StringLength(50)]
        public string? PurchaseOrder { get; set; }
        [StringLength(10)]
        public string? PurchaseDate { get; set; }
        public long? AccountId { get; set; }
        public long? SupplierId { get; set; }
        [StringLength(250)]
        public string? RefNumber { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        public long? LocationId { get; set; }
        public long? CcId { get; set; }
        public long? CcId2 { get; set; }
        public long? CcId3 { get; set; }
        public long? CcId4 { get; set; }
        public long? CcId5 { get; set; }
        public string? Note { get; set; }
        public bool? CreateNewId { get; set; }
        public long? AccountId2 { get; set; }
    }


    public class FxaTransactionDto_Sale
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

        public int? AccountType { get; set; }
        [Required]
        public string? DebAccCode { get; set; }
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
        public decimal? SaleAmount { get; set; }
        public string? Note { get; set; }

        public List<SaveFileDto>? FileDtos { get; set; }

    }
}