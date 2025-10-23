using System.ComponentModel.DataAnnotations;


namespace Logix.Application.DTOs.Main
{
    public class SysLookupCategoryDto
    {
        public long CatagoriesId { get; set; }

        [StringLength(250)]
        public string? CatagoriesName { get; set; }

        [StringLength(250)]
        public string? CatagoriesName2 { get; set; }

        [StringLength(500)]
        public string? SystemId { get; set; }

        public bool? Isdel { get; set; }

        public long? UserId { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsDeletable { get; set; }
    }

    public class SysLookupCategoryEditDto
    {
        [Required]
        public long CatagoriesId { get; set; }

        [Required]
        [StringLength(250)]
        public string CatagoriesName { get; set; }
        public bool? IsEditable { get; set; }
    }
}
