using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurDiscountProductDto
    {
        public long? Id { get; set; }
        public long? DisCatalogId { get; set; }
        public string? ProductCode { get; set; }
        public long? ProductId { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PurDiscountProductEditDto
    {
        public long Id { get; set; }
        public long? DisCatalogId { get; set; }
        public long? ProductId { get; set; }
    }
}
