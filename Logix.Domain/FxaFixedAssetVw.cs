using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Keyless]
public partial class FxaFixedAssetVw
{
    [Column("ID")]
    public long Id { get; set; }

    public long? No { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("Type_ID")]
    public int? TypeId { get; set; }

    [StringLength(4000)]
    public string? Name { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [Column("Start_date")]
    [StringLength(10)]
    public string? StartDate { get; set; }

    [Column("End_Date")]
    [StringLength(10)]
    public string? EndDate { get; set; }

    [Column("Img_Url")]
    [StringLength(4000)]
    public string? ImgUrl { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    [Column("Status_ID")]
    public int? StatusId { get; set; }

    [Column("Branch_ID")]
    public int? BranchId { get; set; }

    [Column("Initial_Balance", TypeName = "decimal(18, 2)")]
    public decimal? InitialBalance { get; set; }

    [Column("Account_ID")]
    public long? AccountId { get; set; }

    [Column("Account2_ID")]
    public long? Account2Id { get; set; }

    [Column("Account3_ID")]
    public long? Account3Id { get; set; }

    public string? Location { get; set; }

    [Column("Acc_Account_Code")]
    [StringLength(50)]
    public string? AccAccountCode { get; set; }

    [Column("Acc_Account_Name")]
    [StringLength(255)]
    public string? AccAccountName { get; set; }

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

    [Column("Facility_ID")]
    public long? FacilityId { get; set; }

    [Column("Purchase_Order")]
    [StringLength(50)]
    public string? PurchaseOrder { get; set; }

    [Column("Purchase_Date")]
    [StringLength(10)]
    public string? PurchaseDate { get; set; }

    [Column("Purchase_Account_ID")]
    public long? PurchaseAccountId { get; set; }

    [Column("Supplier_ID")]
    public long? SupplierId { get; set; }

    [Column("Supplier_Code")]
    [StringLength(250)]
    public string? SupplierCode { get; set; }

    [Column("Supplier_Name")]
    [StringLength(2500)]
    public string? SupplierName { get; set; }

    [Column("Deprec_Method")]
    public int? DeprecMethod { get; set; }

    [Column("Deprec_Monthly_Rate", TypeName = "decimal(18, 2)")]
    public decimal? DeprecMonthlyRate { get; set; }

    [Column("Installment_Value", TypeName = "decimal(18, 2)")]
    public decimal? InstallmentValue { get; set; }

    [Column("Deprec_Method_Name")]
    [StringLength(50)]
    public string? DeprecMethodName { get; set; }

    [Column("CostCenter_Code")]
    [StringLength(50)]
    public string? CostCenterCode { get; set; }

    [Column("CostCenter_Name")]
    [StringLength(150)]
    public string? CostCenterName { get; set; }

    [Column("CC_ID")]
    public long? CcId { get; set; }

    [Column("Pur_Acc_Account_Name")]
    [StringLength(255)]
    public string? PurAccAccountName { get; set; }

    [Column("Pur_Acc_Account_Code")]
    [StringLength(50)]
    public string? PurAccAccountCode { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Annuity { get; set; }

    [Column("Deprec_Yearly_Rate", TypeName = "decimal(18, 2)")]
    public decimal? DeprecYearlyRate { get; set; }

    [Column("Location_ID")]
    public long? LocationId { get; set; }

    [Column("Case_ID")]
    public int? CaseId { get; set; }

    [Column("Ohda_Emp_ID")]
    public long? OhdaEmpId { get; set; }

    [Column("Item_ID")]
    public long? ItemId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Qty { get; set; }

    [Column("Unit_Price", TypeName = "decimal(18, 2)")]
    public decimal? UnitPrice { get; set; }

    [Column("Last_Depreciation_Date")]
    [StringLength(10)]
    public string? LastDepreciationDate { get; set; }

    [Column("Type_Name")]
    [StringLength(250)]
    public string? TypeName { get; set; }

    [Column("Ohda_Emp_Code")]
    [StringLength(50)]
    public string? OhdaEmpCode { get; set; }

    [Column("Ohda_Emp_Name")]
    [StringLength(250)]
    public string? OhdaEmpName { get; set; }

    [Column("Type_Code")]
    [StringLength(50)]
    public string? TypeCode { get; set; }

    [Column("CostCenter_Code2")]
    [StringLength(50)]
    public string? CostCenterCode2 { get; set; }

    [Column("CostCenter_Name2")]
    [StringLength(150)]
    public string? CostCenterName2 { get; set; }

    [Column("CC_ID2")]
    public long? CcId2 { get; set; }

    [Column("CC_ID3")]
    public long? CcId3 { get; set; }

    [Column("CC_ID4")]
    public long? CcId4 { get; set; }

    [Column("CC_ID5")]
    public long? CcId5 { get; set; }

    [Column("CostCenter_Code3")]
    [StringLength(50)]
    public string? CostCenterCode3 { get; set; }

    [Column("CostCenter_Name3")]
    [StringLength(150)]
    public string? CostCenterName3 { get; set; }

    [Column("CostCenter_Code4")]
    [StringLength(50)]
    public string? CostCenterCode4 { get; set; }

    [Column("CostCenter_Name4")]
    [StringLength(150)]
    public string? CostCenterName4 { get; set; }

    [Column("CostCenter_Code5")]
    [StringLength(50)]
    public string? CostCenterCode5 { get; set; }

    [Column("CostCenter_Name5")]
    [StringLength(150)]
    public string? CostCenterName5 { get; set; }

    [Column("BRA_NAME")]
    public string? BraName { get; set; }

    [Column("Location_Name")]
    [StringLength(200)]
    public string? LocationName { get; set; }

    [Column("Classification_ID")]
    public int? ClassificationId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ScrapValue { get; set; }

    [Column("Addition_Type")]
    public bool? AdditionType { get; set; }

    [Column("Main_Asset_Id")]
    public long? MainAssetId { get; set; }

    [Column("Main_Asset_Name")]
    [StringLength(4000)]
    public string? MainAssetName { get; set; }

    [Column("Main_Asset_No")]
    public long? MainAssetNo { get; set; }

    [Column("Main_Asset_Code")]
    [StringLength(50)]
    public string? MainAssetCode { get; set; }
}
