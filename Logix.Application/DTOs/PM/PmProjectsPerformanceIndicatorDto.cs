namespace Logix.Application.DTOs.PM
{
    public class PmProjectsPerformanceIndicatorDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Indicator { get; set; }
        public string? Target { get; set; }
        public string? Baseline { get; set; }
        public string? Responsible { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PmProjectsPerformanceIndicatorEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Indicator { get; set; }
        public string? Target { get; set; }
        public string? Baseline { get; set; }
        public string? Responsible { get; set; }
        public string? Note { get; set; }
    }
}
