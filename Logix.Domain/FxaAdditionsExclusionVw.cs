using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Keyless]
public partial class FxaAdditionsExclusionVw
{
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(10)]
    public string? Date1 { get; set; }

    [Column("Facility_ID")]
    public int? FacilityId { get; set; }

    [Column("FixedAsset_ID")]
    public long? FixedAssetId { get; set; }

    [Column("FixedAsset_Code")]
    [StringLength(50)]
    public string? FixedAssetCode { get; set; }

    [Column("FixedAsset_Name")]
    [StringLength(4000)]
    public string? FixedAssetName { get; set; }

    [Column("Type_ID")]
    public int? TypeId { get; set; }

    [Column("Type_Name")]
    [StringLength(200)]
    public string? TypeName { get; set; }

    [Column("AdditionsExclusionType_ID")]
    public int? AdditionsExclusionTypeId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Debit { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Credit { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [Column("Affect_Installment")]
    public bool? AffectInstallment { get; set; }

    [Column("Installment_Value", TypeName = "decimal(18, 2)")]
    public decimal? InstallmentValue { get; set; }

    [Column("Affect_Age")]
    public bool? AffectAge { get; set; }

    [StringLength(10)]
    public string? EndDate { get; set; }

    [Column("Affect_PriceAsset")]
    public bool? AffectPriceAsset { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AssetPrice { get; set; }

    public bool? IsDeleted { get; set; }

    [Column("FixedAsset_No")]
    public long? FixedAssetNo { get; set; }

    [Column("Account_ID")]
    public long? AccountId { get; set; }

    [Column("CrdAccount_ID")]
    public long? CrdAccountId { get; set; }

    [Column("Account_Type_Id")]
    public int? AccountTypeId { get; set; }

    [Column("VAT_Rate", TypeName = "decimal(18, 2)")]
    public decimal? VatRate { get; set; }

    [Column("VAT_Amount", TypeName = "decimal(18, 2)")]
    public decimal? VatAmount { get; set; }

    [Column("Account_Code")]
    [StringLength(50)]
    public string? AccountCode { get; set; }

    [Column("Account_Name")]
    [StringLength(255)]
    public string? AccountName { get; set; }

    [Column("CrdAccount_Code")]
    [StringLength(50)]
    public string? CrdAccountCode { get; set; }

    [Column("CrdAccount_Name")]
    [StringLength(4000)]
    public string? CrdAccountName { get; set; }

    [Column("CrdAccount_Refrance_No")]
    public long? CrdAccountRefranceNo { get; set; }

    [Column("CrdAccount_Code1")]
    [StringLength(50)]
    public string? CrdAccountCode1 { get; set; }

    [Column("CrdAccount_Name1")]
    [StringLength(255)]
    public string? CrdAccountName1 { get; set; }
}
