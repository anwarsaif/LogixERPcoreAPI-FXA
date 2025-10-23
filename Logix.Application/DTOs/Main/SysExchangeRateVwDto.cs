using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysExchangeRateVwDto
    {
        public long Id { get; set; }
        public long? CurrencyFromId { get; set; }
        public long? CurrencyToId { get; set; }
        [StringLength(103)]
        public string? NameFrom { get; set; }
        [StringLength(103)]
        public string? NameTo { get; set; }
        [StringLength(10)]
        public string? ExchangeDate { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
