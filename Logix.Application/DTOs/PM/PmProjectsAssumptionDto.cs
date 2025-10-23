namespace Logix.Application.DTOs.PM
{
    public class PmProjectsAssumptionDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Assumption { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PmProjectsAssumptionEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Assumption { get; set; }
        public string? Note { get; set; }
    }
}
