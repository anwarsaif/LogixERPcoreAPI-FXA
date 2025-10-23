using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Keyless]
public partial class FxaFixedAssetVw2
{
    [Column("ID")]
    public long Id { get; set; }

    public long? No { get; set; }

    [StringLength(4000)]
    public string? Name { get; set; }

    [Column("Type_ID")]
    public int? TypeId { get; set; }

    [Column("Type_Name")]
    [StringLength(250)]
    public string? TypeName { get; set; }

    [Column("Facility_ID")]
    public long? FacilityId { get; set; }

    public string? Location { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [Column("Purchase_Date")]
    [StringLength(10)]
    public string? PurchaseDate { get; set; }

    [Column("Type_ID2")]
    public long? TypeId2 { get; set; }

    [Column("Type_Name2")]
    [StringLength(250)]
    public string? TypeName2 { get; set; }

    [Column("Type_ID3")]
    public long? TypeId3 { get; set; }

    [Column("Type_Name3")]
    [StringLength(250)]
    public string? TypeName3 { get; set; }

    [Column("Classification_Name")]
    [StringLength(250)]
    public string? ClassificationName { get; set; }

    [Column("Classification_ID")]
    public long? ClassificationId { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("Status_ID")]
    public int? StatusId { get; set; }

    public bool? IsDeleted { get; set; }

    [Column("Start_date")]
    [StringLength(10)]
    public string? StartDate { get; set; }

    [Column("End_Date")]
    [StringLength(10)]
    public string? EndDate { get; set; }

    public string? Description { get; set; }

    [Column("Parent_ID")]
    public long? ParentId { get; set; }

    [Column("Parent_ID2")]
    public long? ParentId2 { get; set; }

    [Column("Parent_ID3")]
    public long? ParentId3 { get; set; }

    [Column("BRA_NAME")]
    public string? BraName { get; set; }

    [Column("Branch_ID")]
    public int? BranchId { get; set; }


    [Column("Location_Id")]
    public long? LocationId { get; set; }
    public string? LocationName { get; set; }
    public string? LocationName2 { get; set; }
}