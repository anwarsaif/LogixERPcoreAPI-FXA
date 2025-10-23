using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.SAL
{
    public class SalItemsPriceMDto
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        
        public long? FacilityId { get; set; }
        
        public long? BranchId { get; set; }
        public long? CreatedBy { get; set; }
        
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(50)]
        public string? Name2 { get; set; }
    }
    public class SalItemsPriceMEditDto
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        
        public long? FacilityId { get; set; }
        
        public long? BranchId { get; set; }
        public long? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
        [StringLength(50)]
        public string? Name2 { get; set; }
    }
}
