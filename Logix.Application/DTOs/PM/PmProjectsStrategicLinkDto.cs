namespace Logix.Application.DTOs.PM
{
    public class PmProjectsStrategicLinkDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public int? StrategicObjective { get; set; }
        public decimal? Rate { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PmProjectsStrategicLinkEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public int? StrategicObjective { get; set; }
        public decimal? Rate { get; set; }
        public string? Note { get; set; }
    }
}
