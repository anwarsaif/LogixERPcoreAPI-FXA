using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_Transactions_Revaluation")]
public partial class FxaTransactionsRevaluation
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

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
}
