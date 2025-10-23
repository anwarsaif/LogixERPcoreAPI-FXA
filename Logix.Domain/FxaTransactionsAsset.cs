using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_Transactions_Assest")]
public partial class FxaTransactionsAsset
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("Transaction_ID")]
    public long? TransactionId { get; set; }

    [Column("FixedAsset_ID")]
    public long? FixedAssetId { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Credit { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Debet { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    [Column("Item_ID")]
    public long? ItemId { get; set; }

    [Column("Unit_Price", TypeName = "decimal(18, 2)")]
    public decimal? UnitPrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Qty { get; set; }

    [Column("Type_ID")]
    public long? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column("VAT_Rate", TypeName = "decimal(18, 2)")]
    public decimal? VatRate { get; set; }

    [Column("VAT_Amount", TypeName = "decimal(18, 2)")]
    public decimal? VatAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    [Column("Asset_Amount_Old", TypeName = "decimal(18, 2)")]
    public decimal? AssetAmountOld { get; set; }
}
