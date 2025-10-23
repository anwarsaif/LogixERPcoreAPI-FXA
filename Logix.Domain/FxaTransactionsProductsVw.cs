using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Keyless]
public partial class FxaTransactionsProductsVw
{
    [Column("ID")]
    public long Id { get; set; }

    [Column("Transaction_ID")]
    public long? TransactionId { get; set; }

    [Column("Type_ID")]
    public long? TypeId { get; set; }

    [Column("Item_ID")]
    public long? ItemId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Qty { get; set; }

    [Column("Unit_Price", TypeName = "decimal(18, 2)")]
    public decimal? UnitPrice { get; set; }

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

    [Column("CC_ID")]
    public long? CcId { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    [Column("Item_Code")]
    [StringLength(250)]
    public string? ItemCode { get; set; }

    [Column("Item_Name")]
    [StringLength(2500)]
    public string? ItemName { get; set; }

    [Column("CostCenter_Code")]
    [StringLength(50)]
    public string? CostCenterCode { get; set; }

    [Column("CostCenter_Name")]
    [StringLength(150)]
    public string? CostCenterName { get; set; }

    [Column("Type_Name")]
    [StringLength(250)]
    public string? TypeName { get; set; }

    [Column("Trans_Date")]
    [StringLength(10)]
    public string? TransDate { get; set; }

    [Column("Start_Date")]
    [StringLength(10)]
    public string? StartDate { get; set; }

    [Column("End_Date")]
    [StringLength(10)]
    public string? EndDate { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("Supplier_Name")]
    [StringLength(2500)]
    public string? SupplierName { get; set; }
}
