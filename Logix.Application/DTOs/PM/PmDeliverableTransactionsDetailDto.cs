namespace Logix.Application.DTOs.PM
{
    public class PmDeliverableTransactionsDetailDto
    {
        public long? Id { get; set; }
        public long? DeliverableId { get; set; }
        public long? TransId { get; set; }
        public string? DetailsNote { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyApprove { get; set; }
        public decimal? QtyPrevious { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PmDeliverableTransactionsDetailEditDto
    {
        public long Id { get; set; }
        public long? DeliverableId { get; set; }
        public long? TransId { get; set; }
        public string? DetailsNote { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyApprove { get; set; }
        public decimal? QtyPrevious { get; set; }
    }
}
