using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_FixedAsset_Type")]
public partial class FxaFixedAssetType
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("Type_Name")]
    [StringLength(250)]
    public string? TypeName { get; set; }

    [Column("Facility_ID")]
    public long? FacilityId { get; set; }

    [Column("Deprec_Yearly_Rate", TypeName = "decimal(18, 2)")]
    public decimal? DeprecYearlyRate { get; set; }

    [Column("Account_ID")]
    public long? AccountId { get; set; }

    [Column("Account2_ID")]
    public long? Account2Id { get; set; }

    [Column("Account3_ID")]
    public long? Account3Id { get; set; }

    [Column("Parent_ID")]
    public long? ParentId { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Note { get; set; }

    public int? Age { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }
}
