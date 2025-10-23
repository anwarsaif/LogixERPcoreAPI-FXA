namespace Logix.Application.DTOs.Main
{
    public class SysCustomersFilesSettingDto
    {
        public long Id { get; set; }
        public int? CustomerTypeId { get; set; }
        public int? FileTypeId { get; set; }
        public bool? IsRequired { get; set; }
        public bool? RequiresAuthorization { get; set; }
        public int? FacilityId { get; set; }
        public bool? IsDeleted { get; set; }

        // display
        public string? FileTypeName { get; set; }
        public string? FileTypeName2 { get; set; }
        public string? CustomerTypeName { get; set; }
    }
}
