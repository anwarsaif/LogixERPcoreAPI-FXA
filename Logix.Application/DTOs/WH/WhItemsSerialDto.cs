using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
    public partial class WhItemsSerialDto
    {
        public long? Id { get; set; }
        public string? SerialNo { get; set; }
        public long? ItemId { get; set; }
        public string? WarrantySdate { get; set; }
        public string? WarrantyEdate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string? PackageNo { get; set; }
    }
    public partial class WhItemsSerialEditDto
    {
        public long Id { get; set; }
        public string? SerialNo { get; set; }
        public long? ItemId { get; set; }
        public string? WarrantySdate { get; set; }
        public string? WarrantyEdate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string? PackageNo { get; set; }
    }
}
