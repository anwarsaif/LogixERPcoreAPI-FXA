namespace Logix.Application.DTOs.PM
{
    public class PmExtractTransactionsDiscountDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? BranchId { get; set; }
        public long? TransactionId { get; set; }
        public string? DiscountDate { get; set; }
        public string? DiscountDate2 { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PmExtractTransactionsDiscountEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public int? BranchId { get; set; }
        public long? TransactionId { get; set; }
        public string? DiscountDate { get; set; }
        public string? DiscountDate2 { get; set; }
        public decimal? DiscountAmount { get; set; }
    }
}
