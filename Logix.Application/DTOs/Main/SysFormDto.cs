using System.ComponentModel.DataAnnotations;


namespace Logix.Application.DTOs.Main
{
    public class SysFormFilterDto
    {
        public string? Name { get; set; }
        public long? SystemId { get; set; }
    }

    public class SysFormDto
    {
        public long? Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name1 { get; set; }

        [StringLength(50)]
        public string? Name2 { get; set; }

        [Range(1, long.MaxValue)]
        public long? SystemId { get; set; }

        [StringLength(150)]
        public string? Url { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class SysFormEditDto
    {
        public long? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name1 { get; set; }

        [StringLength(50)]
        public string? Name2 { get; set; }

        [Range(1, long.MaxValue)]
        public long? SystemId { get; set; }

        [StringLength(150)]
        public string? Url { get; set; }
    }
}
