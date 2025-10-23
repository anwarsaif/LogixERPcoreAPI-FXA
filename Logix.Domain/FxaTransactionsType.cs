using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_Transactions_Type")]
public partial class FxaTransactionsType
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("Screen_ID")]
    public long? ScreenId { get; set; }
}
