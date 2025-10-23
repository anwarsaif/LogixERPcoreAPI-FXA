using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_FixedAsset_Transfer")]
public partial class FxaFixedAssetTransfer
{
    [Key]
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

    public long CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    [Column("From_CC_ID")]
    public long? FromCcId { get; set; }

    [Column("TO_CC_ID")]
    public long? ToCcId { get; set; }

    [Column("From_Emp_ID")]
    public long? FromEmpId { get; set; }

    [Column("To_Emp_ID")]
    public long? ToEmpId { get; set; }

    [Column("From_Location_ID")]
    public long? FromLocationId { get; set; }

    [Column("To_Location_ID")]
    public long? ToLocationId { get; set; }
}
