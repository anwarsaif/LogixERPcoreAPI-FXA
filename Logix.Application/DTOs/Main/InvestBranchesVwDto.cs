using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class InvestBranchesVwDto
    {
        public int BranchId { get; set; }
        
        public string? BraName { get; set; }
        
        public string? BraName2 { get; set; }
        
        [StringLength(50)]
        public string? Telephone { get; set; }
        
        [StringLength(50)]
        public string? Mobile { get; set; }
        
        [StringLength(50)]
        public string? Email { get; set; }
        
        public string? Address { get; set; }
        
        public long? UserId { get; set; }
        
        public bool? Isdel { get; set; }
        
        public int? CcId { get; set; }
        
        [StringLength(50)]
        public string? BranchCode { get; set; }
        [StringLength(150)]
        public string? MapLat { get; set; }
        [StringLength(150)]
        public string? MapLng { get; set; }
        public bool? IsActive { get; set; }
        
        public long? FacilityId { get; set; }
        
        [StringLength(50)]
        public string? CostCenterCode { get; set; }
        
        [StringLength(150)]
        public string? CostCenterName { get; set; }
        
        [StringLength(150)]
        public string? CostCenterName2 { get; set; }
        [StringLength(250)]
        public string? WebSite { get; set; }
        public long? BranchTypeId { get; set; }
        
        public long? CategoryId { get; set; }
    }
}
