using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurTransactionsSupplierDto
    {
        public long? Id { get; set; }
        public long? TransactionId { get; set; }
        public long? CusTypeId { get; set; }
        public long? SupplierId { get; set; }
        public string? SupplierCode { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public int? Accept { get; set; }
        public long? AcceptBy { get; set; }
        //public DateTime? AcceptOn { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class PurTransactionsSupplierEditDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public long? SupplierId { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public int? Accept { get; set; }
        public long? AcceptBy { get; set; }
        public DateTime? AcceptOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
