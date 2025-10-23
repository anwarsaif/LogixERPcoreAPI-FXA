using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysLookupDataVwsDto
    {
        public long? Code { get; set; }
        [StringLength(250)]
        public string? Name { get; set; }
        [StringLength(250)]
        public string? Name2 { get; set; }
        
        public long Id { get; set; }
        
        [StringLength(250)]
        public string? CatagoriesName { get; set; }
        
        public bool? Isdel { get; set; }
        
        public long? CatagoriesId { get; set; }
        public string? Note { get; set; }
        
        [StringLength(500)]
        public string? SystemId { get; set; }
        
        [StringLength(250)]
        public string? RefranceNo { get; set; }
       
        public int? ColorId { get; set; }
        [StringLength(250)]
        public string? Icon { get; set; }
        
        public long? AccAccountId { get; set; }
       
        [StringLength(50)]
        public string? AccAccountCode { get; set; }
        
        [StringLength(255)]
        public string? AccAccountName { get; set; }
        
        public long? CcId { get; set; }
        
        [StringLength(50)]
        public string? CostCenterCode { get; set; }
       
        [StringLength(150)]
        public string? CostCenterName { get; set; }
        
        public int? SortNo { get; set; }
        
        public long? UserId { get; set; }
        
        [StringLength(250)]
        public string? CatagoriesName2 { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsDeletable { get; set; }
    }
}
