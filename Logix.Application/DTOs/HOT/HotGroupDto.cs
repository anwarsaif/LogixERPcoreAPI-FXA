using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.HOT
{
    public class HotGroupDto
    {
        public long Id { get; set; }

        public long? Code { get; set; }

        public string? GroupName { get; set; }
        public string? GroupName2 { get; set; }

        public int? StatusId { get; set; }

        public long? FacilityId { get; set; }

        public long? RevenueAccountId { get; set; }

        public long? ExpenseAccountId { get; set; }

        public long? DiscountAccountId { get; set; }

        public long? DiscountCreditAccountId { get; set; }

        public long? SalesReturnsAccountId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
    }
    public class HotGroupEditDto
    {
        public long Id { get; set; }

        public long? Code { get; set; }

        public string? GroupName { get; set; }
        public string? GroupName2 { get; set; }

        public int? StatusId { get; set; }


        public long? RevenueAccountId { get; set; }

        public long? ExpenseAccountId { get; set; }

        public long? DiscountAccountId { get; set; }

        public long? DiscountCreditAccountId { get; set; }

        public long? SalesReturnsAccountId { get; set; }


        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

    }
}
