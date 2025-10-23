namespace Logix.Application.DTOs.PM
{
    public class PmProjectsGovernanceDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Team1 { get; set; }
        public string? Team2 { get; set; }
        public string? MeetingPeriodicity { get; set; }
        public string? Tasks { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PmProjectsGovernanceEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Team1 { get; set; }
        public string? Team2 { get; set; }
        public string? MeetingPeriodicity { get; set; }
        public string? Tasks { get; set; }
        public string? Note { get; set; }
    }
}
