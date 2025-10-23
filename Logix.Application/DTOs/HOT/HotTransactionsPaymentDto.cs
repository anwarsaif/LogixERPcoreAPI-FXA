namespace Logix.Application.DTOs.HOT
{
    public class HotTransactionsPaymentDto
    {

        public long Id { get; set; }

        public long? No { get; set; }

        public string? Code { get; set; }

        public int? BranchId { get; set; }

        public long? TransactionId { get; set; }
        public string? PaymentDate { get; set; }
        public string? PaymentDate2 { get; set; }

        public decimal? AmountReceived { get; set; }

        public int? PaymentMethodId { get; set; }

        public int? BankId { get; set; }

        public string? BankReference { get; set; }

        public int? DaysLate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public long? AccountId { get; set; }

        public long? Jid { get; set; }

        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }
    }
    public class HotTransactionsPaymentEditDto
    {
        public long Id { get; set; }

        public long? No { get; set; }

        public string? Code { get; set; }
        public long? TransactionId { get; set; }
        public string? PaymentDate { get; set; }
        public string? PaymentDate2 { get; set; }

        public decimal? AmountReceived { get; set; }

        public int? PaymentMethodId { get; set; }

        public int? BankId { get; set; }

        public string? BankReference { get; set; }

        public int? DaysLate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? AccountId { get; set; }
        public long? Jid { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
