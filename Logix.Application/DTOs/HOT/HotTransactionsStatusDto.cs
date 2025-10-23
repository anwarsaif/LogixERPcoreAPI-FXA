namespace Logix.Application.DTOs.HOT
{
    public class HotTransactionsStatusDto
    {

        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public string? Date { get; set; }

        public long? StatusId { get; set; }

        public string? Note { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
    public class HotTransactionsStatusEditDto
    {

        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public string? Date { get; set; }

        public long? StatusId { get; set; }

        public string? Note { get; set; }
    }
}
