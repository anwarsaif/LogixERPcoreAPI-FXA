using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_FixedAsset")]
public partial class FxaFixedAsset
{
    [Key]
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

    [Column("Deprec_Method")]
    public int? DeprecMethod { get; set; }

    [Column("Deprec_Monthly_Rate", TypeName = "decimal(18, 2)")]
    public decimal? DeprecMonthlyRate { get; set; }

    [Column("Installment_Value", TypeName = "decimal(18, 2)")]
    public decimal? InstallmentValue { get; set; }

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

    [Column("CC_ID")]
    public long? CcId { get; set; }

    [Column("Ohda_Emp_ID")]
    public long? OhdaEmpId { get; set; }

    [Column("Case_ID")]
    public int? CaseId { get; set; }

    [Column("Location_ID")]
    public long? LocationId { get; set; }

    [Column("Deprec_Yearly_Rate", TypeName = "decimal(18, 2)")]
    public decimal? DeprecYearlyRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Annuity { get; set; }

    [Column("Item_ID")]
    public long? ItemId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Qty { get; set; }

    [Column("Unit_Price", TypeName = "decimal(18, 2)")]
    public decimal? UnitPrice { get; set; }

    [Column("Last_Depreciation_Date")]
    [StringLength(10)]
    public string? LastDepreciationDate { get; set; }

    [Column("CC_ID2")]
    public long? CcId2 { get; set; }

    [Column("CC_ID3")]
    public long? CcId3 { get; set; }

    [Column("CC_ID4")]
    public long? CcId4 { get; set; }

    [Column("CC_ID5")]
    public long? CcId5 { get; set; }

    [Column("Classification_ID")]
    public int? ClassificationId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ScrapValue { get; set; }

    [Column("Main_Asset_Id")]
    public long? MainAssetId { get; set; }

    [Column("Addition_Type")]
    public bool? AdditionType { get; set; }
}
