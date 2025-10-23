using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.HOT
{
    public class HotTransactionDto
    {
        public long Id { get; set; }

        public string? Code { get; set; }
        public string? ReservationsDate { get; set; }

        public int? TransTypeId { get; set; }

        public int? StatusId { get; set; }

        public int? SourceId { get; set; }
        public int? ReasonTravelId { get; set; }

        public long? FacilityId { get; set; }

        public long? BranchId { get; set; }

        public long? CustomerId { get; set; }

        public int? SoothingTypeId { get; set; }

        public TimeSpan? TimeIn { get; set; }

        public TimeSpan? TimeOut { get; set; }
        public string? StartDateAg { get; set; }

        public string? EndDateAg { get; set; }
        public string? StartDateAh { get; set; }

        public string? EndDateAh { get; set; }
        public int? PaymentTermsId { get; set; }

        public int CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? VatRate { get; set; }

        public decimal? VatAmount { get; set; }
        public decimal? Total { get; set; }

        public decimal? Subtotal { get; set; }

        public string? Note { get; set; }

        public string? Description { get; set; }
        public long? RefranceId { get; set; }

        public long? EmpId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public decimal? CashAmount { get; set; }

        public decimal? BankAmount { get; set; }

        public long? AccAccountCash { get; set; }

        public long? AccAccountBank { get; set; }

        public long? No { get; set; }
    }


    public class HotTransactionEditDto
    {
        public long Id { get; set; }

        public string? Code { get; set; }
        public string? ReservationsDate { get; set; }

        public int? TransTypeId { get; set; }

        public int? StatusId { get; set; }

        public int? SourceId { get; set; }
        public int? ReasonTravelId { get; set; }
        public long? CustomerId { get; set; }

        public int? SoothingTypeId { get; set; }

        public TimeSpan? TimeIn { get; set; }

        public TimeSpan? TimeOut { get; set; }
        public string? StartDateAg { get; set; }

        public string? EndDateAg { get; set; }
        public string? StartDateAh { get; set; }

        public string? EndDateAh { get; set; }
        public int? PaymentTermsId { get; set; }

        public int CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? VatRate { get; set; }

        public decimal? VatAmount { get; set; }
        public decimal? Total { get; set; }

        public decimal? Subtotal { get; set; }

        public string? Note { get; set; }

        public string? Description { get; set; }
        public long? RefranceId { get; set; }

        public long? EmpId { get; set; }

        public decimal? CashAmount { get; set; }

        public decimal? BankAmount { get; set; }

        public long? AccAccountCash { get; set; }

        public long? AccAccountBank { get; set; }

        public long? No { get; set; }
    }
}
