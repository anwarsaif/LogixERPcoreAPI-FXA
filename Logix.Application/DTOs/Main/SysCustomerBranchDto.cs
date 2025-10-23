using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysCustomerBranchDto
    {
        public long Id { get; set; }
        
        public int? CusId { get; set; }
        [StringLength(1500)]
        public string? Name { get; set; }
        
        [StringLength(50)]
        public string? IdNo { get; set; }
        
        [StringLength(1500)]
        public string? JobName { get; set; }
        
        [StringLength(2500)]
        public string? JobAddress { get; set; }
        [StringLength(10)]
        public string? Mobile { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        
        public bool? IsDeleted { get; set; }
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
    }

    public class SysCustomerBranchEditDto
    {
        public long Id { get; set; }
        
        public int? CusId { get; set; }
        [StringLength(1500)]
        public string? Name { get; set; }
        
        [StringLength(50)]
        public string? IdNo { get; set; }
        
        [StringLength(1500)]
        public string? JobName { get; set; }
        
        [StringLength(2500)]
        public string? JobAddress { get; set; }
        [StringLength(10)]
        public string? Mobile { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
    }
}
