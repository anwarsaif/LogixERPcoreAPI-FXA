using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsInstallmentPaymentDto
    {
        public long Id { get; set; }
        public long? InstallmentId { get; set; }
        [StringLength(10)]
        public string? DateG { get; set; }
        [StringLength(10)]
        public string? DateH { get; set; }
   
        public decimal? Amount { get; set; }

        public int? PaymentId { get; set; }

        public int? BankId { get; set; }
      
        [StringLength(50)]
        public string? BankReference { get; set; }
        public long? AccountId { get; set; }
        public long? Jid { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int? CurrencyId { get; set; }
  
        public decimal? ExchangeRate { get; set; }
   
        public long? TransactionId { get; set; }
    }
    
    
    public class PmProjectsInstallmentPaymentEditDto
    {
        public long Id { get; set; }
        public long? InstallmentId { get; set; }
        [StringLength(10)]
        public string? DateG { get; set; }
        [StringLength(10)]
        public string? DateH { get; set; }

        public decimal? Amount { get; set; }

        public int? PaymentId { get; set; }

        public int? BankId { get; set; }

        [StringLength(50)]
        public string? BankReference { get; set; }
        public long? AccountId { get; set; }
        public long? Jid { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? TransactionId { get; set; }
    }
}
