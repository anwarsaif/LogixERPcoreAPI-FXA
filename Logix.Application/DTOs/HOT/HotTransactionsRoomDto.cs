namespace Logix.Application.DTOs.HOT
{
    public class HotTransactionsRoomDto
    {

        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public long? RoomId { get; set; }

        public long? Qty { get; set; }

        public decimal? UnitPrice { get; set; }
        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? VatRate { get; set; }

        public decimal? VatAmount { get; set; }
        public decimal? Total { get; set; }

        public string? Description { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
        public long? AccountId { get; set; }
    }
    public class HotTransactionsRoomEditDto
    {


        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public long? RoomId { get; set; }

        public long? Qty { get; set; }

        public decimal? UnitPrice { get; set; }
        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? VatRate { get; set; }

        public decimal? VatAmount { get; set; }
        public decimal? Total { get; set; }

        public string? Description { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public long? AccountId { get; set; }
    }
}
