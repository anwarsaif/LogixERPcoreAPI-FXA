using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.PM
{
    public class PmKickOffDto
    {
        public long? Id { get; set; }
        public string? Date1 { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }

        public long? AppId { get; set; }
        public string? KickOffPlace { get; set; }
        public string? Members { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }
        public string? ExpiryDate { get; set; }
        public int? AppTypeId { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }

    }
    public class PmKickOffEditDto
    {
        public long Id { get; set; }
        public string? Date1 { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }

        public long? AppId { get; set; }
        public string? KickOffPlace { get; set; }
        public string? Members { get; set; }
        public string? Description { get; set; }
        public string? ExpiryDate { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }

    }
}
