
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Logix.Application.DTOs.Main
{
    public class SysExchangeRateForGetByCurrencyFilterDto
    {
        public long? CurrencyFromID { get; set; }

        public decimal? ExchangeRate { get; set; }

    }
    public class SysExchangeRateFilterDto
    {
        public long? CurrencyFromID { get; set; }
        public long? CurrencyToID { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
    }

    public class SysExchangeRateDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        public long CurrencyFromID { get; set; }

        [Range(1, long.MaxValue)]
        public long CurrencyToID { get; set; }

        [Required]
        public string ExchangeDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();

        [Required]
        public decimal? ExchangeRate { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        // for filter
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
    }

    public class SysExchangeRateEditDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        public long CurrencyFromID { get; set; }

        [Range(1, long.MaxValue)]
        public long CurrencyToID { get; set; }

        [Required]
        public string ExchangeDate { get; set; }

        [Required]
        public decimal ExchangeRate { get; set; }
    }
}