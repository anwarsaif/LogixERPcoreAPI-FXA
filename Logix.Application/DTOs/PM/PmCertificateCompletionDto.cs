using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.PM
{
    public class PmCertificateCompletionDto
    {

    }




    public class PmPmCertificateCompletionProductDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; } = 0;

        public long? ProductId { get; set; } = 0;
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; } = 0;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Total { get; set; } = 0;
        [Column("VAT", TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; } = 0;
        public int? BranchId { get; set; } = 0;
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public long? AccountId { get; set; } = 0;
        public long? PItemsId { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? QtyApprove { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? UnitPriceApprove { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? QtyPrevious { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? AmountPrevious { get; set; } = 0;
        [Column(TypeName = "decimal(18, 8)")]
        public decimal? Rate { get; set; } = 0;
        [Column(TypeName = "decimal(18, 8)")]
        public decimal? AmountRate { get; set; } = 0;
        // when we add new item to project 
        public string? ItemName { get; set; } = "";
    }
}
