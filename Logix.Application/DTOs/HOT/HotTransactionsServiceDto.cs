namespace Logix.Application.DTOs.HOT
{
    public class HotTransactionsServiceDto
    {
        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public long? ServicesId { get; set; }

        public decimal? Amount { get; set; }

        public string? Note { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public decimal? Qty { get; set; }

        public decimal? VatRate { get; set; }
        public decimal? VatAmount { get; set; }

        public long? AccountId { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }
    }
    public class HotTransactionsServiceEditDto
    {
        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public long? ServicesId { get; set; }

        public decimal? Amount { get; set; }

        public string? Note { get; set; }


        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public decimal? Qty { get; set; }

        public decimal? VatRate { get; set; }
        public decimal? VatAmount { get; set; }

        public long? AccountId { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }
    }
}
