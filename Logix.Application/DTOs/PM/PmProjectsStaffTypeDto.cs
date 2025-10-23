using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsStaffTypeDto
    {
        public int TypeId { get; set; }
     
        [StringLength(100)]
        public string? TypeName { get; set; }
        public bool? IsDeleted { get; set; }
    }
    
    
    public class PmProjectsStaffTypeEditDto
    {
        public int TypeId { get; set; }

        [StringLength(100)]
        public string? TypeName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
