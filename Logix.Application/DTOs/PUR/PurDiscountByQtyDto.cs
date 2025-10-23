using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurDiscountByQtyDto
    {
        public long? Id { get; set; }
        public long? DisCatalogId { get; set; }
        public decimal? MinQty { get; set; }
        public decimal? MaxQty { get; set; }
        public int? Type { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Qty { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? Amount { get; set; }
    }
    public class PurDiscountByQtyEditDto
    {
        public long Id { get; set; }
        public long? DisCatalogId { get; set; }
        public decimal? MinQty { get; set; }
        public decimal? MaxQty { get; set; }
        public int? Type { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Amount { get; set; }
    }
}
