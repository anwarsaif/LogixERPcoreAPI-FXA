using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Keyless]
public partial class FxaTransactionsRevaluationVw
{
    [Column("ID")]
    public long Id { get; set; }

    public long? No { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("Trans_Type_ID")]
    public int? TransTypeId { get; set; }

    [Column("Facility_ID")]
    public long? FacilityId { get; set; }

    [Column("Branch_ID")]
    public int? BranchId { get; set; }

    [Column("Trans_Date")]
    [StringLength(10)]
    public string? TransDate { get; set; }

    [Column("Start_Date")]
    [StringLength(10)]
    public string? StartDate { get; set; }

    [Column("End_Date")]
    [StringLength(10)]
    public string? EndDate { get; set; }

    [Column("Status_ID")]
    public int? StatusId { get; set; }

    [Column("Payment_Terms_ID")]
    public int? PaymentTermsId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Subtotal { get; set; }

    [Column("Discount_Rate", TypeName = "decimal(18, 2)")]
    public decimal? DiscountRate { get; set; }

    [Column("Discount_Amount", TypeName = "decimal(18, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column("VAT", TypeName = "decimal(18, 2)")]
    public decimal? Vat { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    public long? Expr2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Expr3 { get; set; }

    public long? Expr4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Expr5 { get; set; }

    public bool? Expr6 { get; set; }

    [Column("Purchase_Order")]
    [StringLength(50)]
    public string? PurchaseOrder { get; set; }

    [Column("Purchase_Date")]
    [StringLength(10)]
    public string? PurchaseDate { get; set; }

    [Column("Supplier_ID")]
    public long? SupplierId { get; set; }

    [Column("Trans_Type_Name")]
    [StringLength(50)]
    public string? TransTypeName { get; set; }

    [Column("Supplier_Code")]
    [StringLength(250)]
    public string? SupplierCode { get; set; }

    [Column("Supplier_Name")]
    [StringLength(2500)]
    public string? SupplierName { get; set; }

    [Column("Account_ID")]
    public long? AccountId { get; set; }

    [Column("Ref_Number")]
    [StringLength(250)]
    public string? RefNumber { get; set; }

    [Column("BRA_NAME")]
    public string? BraName { get; set; }

    [Column("VAT_Amount", TypeName = "decimal(18, 2)")]
    public decimal? VatAmount { get; set; }

    [Column("Location_ID")]
    public long? LocationId { get; set; }

    [Column("CC_ID")]
    public long? CcId { get; set; }

    [Column("CC_ID2")]
    public long? CcId2 { get; set; }

    [Column("CC_ID3")]
    public long? CcId3 { get; set; }

    [Column("CC_ID4")]
    public long? CcId4 { get; set; }

    [Column("CC_ID5")]
    public long? CcId5 { get; set; }

    [Column("Acc_Account_Name")]
    [StringLength(255)]
    public string? AccAccountName { get; set; }

    [Column("Acc_Account_Code")]
    [StringLength(50)]
    public string? AccAccountCode { get; set; }

    [Column("Transaction_ID")]
    public long? TransactionId { get; set; }

    [Column("FixedAsset_ID")]
    public long? FixedAssetId { get; set; }

    [Column("Amount_Old", TypeName = "decimal(18, 2)")]
    public decimal? AmountOld { get; set; }

    [Column("Amount_New", TypeName = "decimal(18, 2)")]
    public decimal? AmountNew { get; set; }

    [Column("Amount_Depreciation", TypeName = "decimal(18, 2)")]
    public decimal? AmountDepreciation { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Balance { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    public string? Date { get; set; }

    [Column("Profit_and_loss", TypeName = "decimal(18, 2)")]
    public decimal? ProfitAndLoss { get; set; }

    [Column("Fx_No")]
    public long? FxNo { get; set; }

    [Column("Fx_Code")]
    [StringLength(50)]
    public string? FxCode { get; set; }

    [Column("Fx_Name")]
    [StringLength(4000)]
    public string? FxName { get; set; }

    [StringLength(50)]
    public string? Expr1 { get; set; }

    [StringLength(255)]
    public string? Expr7 { get; set; }

    [Column("Acc_Account_Name2")]
    [StringLength(255)]
    public string? AccAccountName2 { get; set; }

    [Column("Acc_Account_Code2")]
    [StringLength(50)]
    public string? AccAccountCode2 { get; set; }

    [Column("Acc_Account_Name3")]
    [StringLength(255)]
    public string? AccAccountName3 { get; set; }

    [Column("Acc_Account_Code3")]
    [StringLength(50)]
    public string? AccAccountCode3 { get; set; }
}
