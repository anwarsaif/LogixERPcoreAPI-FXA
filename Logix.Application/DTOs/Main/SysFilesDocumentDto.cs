using System.ComponentModel.DataAnnotations;


namespace Logix.Application.DTOs.Main
{
    public class SysFilesDocumentFilterDto
    {
        public int? FacilityId { get; set; }
        public long? SystemId { get; set; }
        public long? ScreenId { get; set; }
    }

    public class SysFilesDocumentDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        public int? FacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public long? SystemId { get; set; }
        [Range(1, long.MaxValue)]
        public long? ScreenId { get; set; }
        [Required]
        [StringLength(250)]
        public string? FileName { get; set; }
        [Required]
        public int? FileType { get; set; }
        public bool? Mandatory { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AppTypeId { get; set; }
    }
}