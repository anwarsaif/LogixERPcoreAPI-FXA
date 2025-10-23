namespace Logix.Application.DTOs.PM
{
    public class PmProjectsInterconnectionDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public long? LinkProjectId { get; set; }
        public string? OtherProjectName { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PmProjectsInterconnectionEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public long? LinkProjectId { get; set; }
        public string? OtherProjectName { get; set; }
        public string? Note { get; set; }
    }

}
