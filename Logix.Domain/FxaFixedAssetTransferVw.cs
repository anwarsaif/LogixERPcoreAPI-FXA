using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Keyless]
public partial class FxaFixedAssetTransferVw
{
    [Column("ID")]
    public long Id { get; set; }

    [Column("FXA_FixedAsset_ID")]
    public long? FxaFixedAssetId { get; set; }

    [Column("From_Branch_ID")]
    public int? FromBranchId { get; set; }

    [Column("From_Facility_ID")]
    public long? FromFacilityId { get; set; }

    [Column("To_Branch_ID")]
    public int? ToBranchId { get; set; }

    [Column("To_Facility_ID")]
    public long? ToFacilityId { get; set; }

    [Column("Date_Transfer")]
    [StringLength(10)]
    public string? DateTransfer { get; set; }

    public string? Note { get; set; }

    public bool IsDeleted { get; set; }

    [Column("From_CC_ID")]
    public long? FromCcId { get; set; }

    [Column("TO_CC_ID")]
    public long? ToCcId { get; set; }

    [Column("CostCenter_Code")]
    [StringLength(50)]
    public string? CostCenterCode { get; set; }

    [Column("CostCenter_Name")]
    [StringLength(150)]
    public string? CostCenterName { get; set; }

    [Column("CostCenter_Code2")]
    [StringLength(50)]
    public string? CostCenterCode2 { get; set; }

    [Column("CostCenter_Name2")]
    [StringLength(150)]
    public string? CostCenterName2 { get; set; }

    public long? No { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(4000)]
    public string? Name { get; set; }

    [Column("From_Emp_ID")]
    public long? FromEmpId { get; set; }

    [Column("To_Emp_ID")]
    public long? ToEmpId { get; set; }

    [Column("From_Location_ID")]
    public long? FromLocationId { get; set; }

    [Column("To_Location_ID")]
    public long? ToLocationId { get; set; }

    [Column("From_Emp_Code")]
    [StringLength(50)]
    public string? FromEmpCode { get; set; }

    [Column("From_Emp_Name")]
    [StringLength(250)]
    public string? FromEmpName { get; set; }

    [Column("To_Emp_Code")]
    [StringLength(50)]
    public string? ToEmpCode { get; set; }

    [Column("To_Emp_Name")]
    [StringLength(250)]
    public string? ToEmpName { get; set; }

    [Column("From_Location_Name")]
    [StringLength(200)]
    public string? FromLocationName { get; set; }

    [Column("To_Location_Name")]
    [StringLength(200)]
    public string? ToLocationName { get; set; }

    [Column("From_BRA_NAME")]
    public string? FromBraName { get; set; }

    [Column("To_BRA_NAME")]
    public string? ToBraName { get; set; }

    [Column("From_Facility_Name")]
    [StringLength(500)]
    public string? FromFacilityName { get; set; }

    [Column("To_Facility_Name")]
    [StringLength(500)]
    public string? ToFacilityName { get; set; }
}
