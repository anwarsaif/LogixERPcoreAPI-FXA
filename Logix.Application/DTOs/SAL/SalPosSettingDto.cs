using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.SAL
{
    public class SalPosSettingDto
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        
        public int? BranchId { get; set; }
        
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? CustomerName { get; set; }
        
        public int? InventoryId { get; set; }
        
        public int? FacilityId { get; set; }
        
        public int? CurrencyId { get; set; }
        [Column(TypeName = "decimal(18, 10)")]
        public decimal? ExchangeRate { get; set; }
        
        public string? PrinterName { get; set; }
        
        public long? CashAccountId { get; set; }
        
        public long? BankAccountId { get; set; }
        
        public bool? LnkInventory { get; set; }
        
        [StringLength(50)]
        public string? DrawerPortNo { get; set; }
       
        [StringLength(50)]
        public string? DrawerCode { get; set; }
        public long? CreatedBy { get; set; }
        
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? No { get; set; }
        
        public long? BankId { get; set; }
        public string? Header { get; set; }
        public string? Footer { get; set; }
        public int? CountPrinter { get; set; }
        public bool? Online { get; set; }
        
        public long? CcId { get; set; }
        public bool? IncrementQty { get; set; }
        public long? LnkAccounting { get; set; }

        public int? PosType { get; set; }
    }
}
