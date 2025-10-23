using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
    public partial class WhActualInventorySerialeDto
    {
        public long? Id { get; set; }
        public long? AInventoryId { get; set; }
        public long? AInventoryDId { get; set; }
        public long? InventoryId { get; set; }
        public long? ItemId { get; set; }
        public long? SerialId { get; set; }
        public decimal? QtyIn { get; set; }
        public decimal? QtyOut { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public partial class WhActualInventorySerialeEditDto
    {
        public long Id { get; set; }
        public long? AInventoryId { get; set; }
        public long? AInventoryDId { get; set; }
        public long? InventoryId { get; set; }
        public long? ItemId { get; set; }
        public long? SerialId { get; set; }
        public decimal? QtyIn { get; set; }
        public decimal? QtyOut { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
