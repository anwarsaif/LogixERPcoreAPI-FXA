
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsTypeDto
    {
        public long Id { get; set; }
        [Required]
        [StringLength(250)]
        public string? TypeName { get; set; }
        public int? ParentId { get; set; }
        public long? CreatedBy { get; set; }
       
        public DateTime? CreatedOn { get; set; }

        public bool? IsDeleted { get; set; }=false;
        
        public long? FacilityId { get; set; }
        public long? SystemId { get; set; }
        public bool? Iscase { get; set; }=false ;
    }
    
    
    public class PmProjectsTypeEditDto
    {
        public long Id { get; set; }
        [StringLength(250)]
        public string? TypeName { get; set; }
        public int? ParentId { get; set; }

      /*  public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; } = false;*/

    }
}
