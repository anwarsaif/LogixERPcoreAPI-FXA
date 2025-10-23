using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.OPM
{
    public class OpmPURTransactionsDetailsDto
    {

        public long Id { get; set; }

        public long? TransactionId { get; set; }
        public long? itemsID { get; set; }

        public decimal DiscRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        public decimal? Total { get; set; }

        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public decimal? Net { get; set; }
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public int IncreasId { get; set; }

        public long? ContractId { get; set; }

        public string? ContractCode { get; set; }

        public string? ContractName { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "decimal(18, 2)")]

        public decimal? Salary { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal? WorkHours { get; set; }
    }

}
