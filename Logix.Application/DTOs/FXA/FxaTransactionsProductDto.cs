using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.FXA
{
    public class FxaTransactionsProductDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public long? TypeId { get; set; }
        public long? ItemId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }
        public long? CcId { get; set; }
        public string? Description { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        // DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class FxaTransactionsProductEditDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public long? TypeId { get; set; }
        public long? ItemId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }
        public long? CcId { get; set; }
        public string? Description { get; set; }
    }
}