namespace Logix.Application.DTOs.HOT
{
    public class HotTransactionsTypeDto
    {
        public long Id { get; set; }

        public string? TransactionType { get; set; }
        public string? Code { get; set; }

        public string? Name { get; set; }

        public string? Name2 { get; set; }

        public long? ScreenId { get; set; }
    }
    public class HotTransactionsTypeEditDto
    {
        public long Id { get; set; }

        public string? TransactionType { get; set; }
        public string? Code { get; set; }

        public string? Name { get; set; }

        public string? Name2 { get; set; }

        public long? ScreenId { get; set; }
    }
}
