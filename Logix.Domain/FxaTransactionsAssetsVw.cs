using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Keyless]
public partial class FxaTransactionsAssetsVw
{
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

    [Column("Fx_Code")]
    [StringLength(50)]
    public string? FxCode { get; set; }

    [Column("Fx_Name")]
    [StringLength(4000)]
    public string? FxName { get; set; }

    [Column("Trans_Type_ID")]
    public int? TransTypeId { get; set; }

    [Column("Fx_No")]
    public long? FxNo { get; set; }

    [Column("Transactions_Type_Name")]
    [StringLength(50)]
    public string? TransactionsTypeName { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("Trans_Date")]
    [StringLength(10)]
    public string? TransDate { get; set; }

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

    [Column("Item_Code")]
    [StringLength(250)]
    public string? ItemCode { get; set; }

    [Column("Item_Name")]
    [StringLength(2500)]
    public string? ItemName { get; set; }

    [Column("Type_Name")]
    [StringLength(250)]
    public string? TypeName { get; set; }

    [Column("CC_ID")]
    public long? CcId { get; set; }

    [Column("Asset_Type_ID")]
    public int? AssetTypeId { get; set; }

    [Column("Asset_Amount_Old", TypeName = "decimal(18, 2)")]
    public decimal? AssetAmountOld { get; set; }

    [Column("Create_New_ID")]
    public bool? CreateNewId { get; set; }

    [Column("IsDeleted_FX")]
    public bool? IsDeletedFx { get; set; } // column isdeleted in FXAFixedAsset table


    [Column("End_Date")]
    [StringLength(10)]
    public string? EndDate { get; set; }

    [Column("IsDeleted_Trans")]
    public bool? IsDeletedTrans { get; set; } // column isdeleted in FxaTransaction table
}
