using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_AdditionsExclusion_Type")]
public partial class FxaAdditionsExclusionType
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    [Column("Type_ID")]
    public int? TypeId { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }
}
