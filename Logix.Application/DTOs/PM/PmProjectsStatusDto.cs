namespace Logix.Application.DTOs.PM
{
    public class PmProjectsStatusDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public string? SDate { get; set; }
        public long? StatusId { get; set; }
        public decimal? CompletionRate { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public long? StepId { get; set; }
        public int TenderStatus { get; set; }
    }
    public class PmProjectsStatusEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string? SDate { get; set; }
        public long? StatusId { get; set; }
        public decimal? CompletionRate { get; set; }
        public string? Note { get; set; }
        public long? StepId { get; set; }
        public int TenderStatus { get; set; }
    }

    public class PmProjectsStatusChangeStatusDto
    {
        public List<long> Ids { get; set; }
        public int StatusId { get; set; }
        public decimal? CompletionRate { get; set; }
        public long? StepId { get; set; }
        public int? TenderStatus { get; set; }
        public string? Note { get; set; }

    }
}
