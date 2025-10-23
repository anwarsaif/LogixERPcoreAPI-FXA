using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurDiscountByAmountDto
    {
        public long? Id { get; set; }
        public long? DisCatalogId { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public int? Type { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PurDiscountByAmountEditDto
    {
        public long Id { get; set; }
        public long? DisCatalogId { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public int? Type { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Qty { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? Amount { get; set; }
    }
}
