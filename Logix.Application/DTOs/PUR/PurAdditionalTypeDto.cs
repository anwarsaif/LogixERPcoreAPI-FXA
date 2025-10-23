using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurAdditionalTypeDto
    {
        public long? Id { get; set; }
        public long? Code { get; set; }
        public int? TypeId { get; set; }
        public string? TypeName { get; set; }
        public int? CreditOrDebit { get; set; }
        public int? RateOrAmount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public long? AccountId { get; set; }
        public string? AccAccountCode { get; set; }
        public bool? IsDeleted { get; set; }
        public int? TotalOrNet { get; set; }
        public int? EncludRate { get; set; }
        public int? AccRefTypeId { get; set; }
        public int? FacilityId { get; set; }
    }
    public class PurAdditionalTypeEditDto
    {
        public long? Id { get; set; }
        public long? Code { get; set; }
        public int? TypeId { get; set; }
        public string? TypeName { get; set; }
        public int? CreditOrDebit { get; set; }
        public int? RateOrAmount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public long? AccountId { get; set; }
        public string? AccAccountCode { get; set; }
        public int? TotalOrNet { get; set; }
        public int? EncludRate { get; set; }
        public int? AccRefTypeId { get; set; }
        public int? FacilityId { get; set; }
    }
    public class PurAdditionalTypeFilterDto
    {
        public long? Code { get; set; }
        public int? TypeId { get; set; }
        public string? TypeName { get; set; }
        public int? CreditOrDebit { get; set; }
        public int? RateOrAmount { get; set; }
        public int? AccRefTypeId { get; set; }
        public int? FacilityId { get; set; }
    }
}
