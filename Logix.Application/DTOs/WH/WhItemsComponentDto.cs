using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
    public class WhItemsComponentDto
    {
        public long? Id { get; set; }
        public long? ItemMId { get; set; }
        public long? ItemId { get; set; }
        public long? UnitId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? PriceType { get; set; }
        public decimal? PriceRate { get; set; }
        public decimal? CostRate { get; set; }
    }
    public class WhItemsComponentEditDto
    {
        public long Id { get; set; }
        public long? ItemMId { get; set; }
        public long? ItemId { get; set; }
        public long? UnitId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? PriceType { get; set; }
        public decimal? PriceRate { get; set; }
        public decimal? CostRate { get; set; }
    }
}
