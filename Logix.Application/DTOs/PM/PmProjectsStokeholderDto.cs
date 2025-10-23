using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PMProjectsStokeholderDto
    {

        public long Id { get; set; }
        public long? ProjectId { get; set; } = 0;
        [StringLength(500)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Mobile { get; set; }
        [StringLength(500)]
        public string? JobName { get; set; }
        public string? Note { get; set; }

        public bool? IsDeleted { get; set; }


        public int? InternalOrExternal { get; set; } = 0;
        public int? TypeId { get; set; } = 0;
    }
    
    
    public class PmProjectsStokeholderEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; } = 0;
        [StringLength(500)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Mobile { get; set; }
        [StringLength(500)]
        public string? JobName { get; set; }
        public string? Note { get; set; }
        public int? InternalOrExternal { get; set; } = 0;
        public int? TypeId { get; set; } = 0;
    }
}
