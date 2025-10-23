using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.FXA
{
    public class FxaTransactionsRevaluationDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public long? FixedAssetId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountOld { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountNew { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountDepreciation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Balance { get; set; }
        
        //public long? CreatedBy { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
        [StringLength(10)]
        public string? Date { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ProfitAndLoss { get; set; }
    }
    public class FxaTransactionsRevaluationEditDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public long? FixedAssetId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountOld { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountNew { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountDepreciation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Balance { get; set; }
        
        //public long? CreatedBy { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime? ModifiedOn { get; set; }

        //public bool? IsDeleted { get; set; }
        [StringLength(10)]
        public string? Date { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ProfitAndLoss { get; set; }
    }
}
