using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.PM
{
    public class PmExtractTransactionsAdditionalDto
    {

      
        public long Id { get; set; }

        public long? TransactionId { get; set; } = 0;

        public int? TypeId { get; set; } = 0;
        public string? AdditionalName { get; set; } = "";// فقط  لعرض  اسم لاضافات او الحسميات

        public long? AccountId { get; set; } = 0;

        public decimal? Rate { get; set; } = 0;

        public decimal? Credit { get; set; } = 0;

        public decimal? Debit { get; set; } = 0;
        public string? Description { get; set; } = "";

        public int? CurrencyId { get; set; } = 0;

        public decimal? ExchangeRate { get; set; } = 0;
        public string? Note { get; set; } = "";

        public long? AdditionalId { get; set; } = 0;
        public bool? IsDeleted { get; set; }= false;

    }
    public class PmExtractTransactionsAdditionalEditDto
    {


        public long Id { get; set; }

        public long? TransactionId { get; set; }

        public int? TypeId { get; set; }
      
        public long? AccountId { get; set; }

        public decimal? Rate { get; set; }

        public decimal? Credit { get; set; }

        public decimal? Debit { get; set; }
        public string? Description { get; set; }

        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }
        public string? Note { get; set; }

        public long? AdditionalId { get; set; }
        public bool? IsDeleted { get; set; }=false;

    }

}
