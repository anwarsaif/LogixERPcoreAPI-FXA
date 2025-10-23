namespace Logix.Application.DTOs.PM
{
    public class PmProjectsDeliverableAcceptCriterionDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public string? OutputDescription { get; set; }
        public string? Criteria { get; set; }
        public string? Responsible { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public string? OutputFormat { get; set; }
        public long? DeliverableId { get; set; }
    }
    public class PmProjectsDeliverableAcceptCriterionEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string? OutputDescription { get; set; }
        public string? Criteria { get; set; }
        public string? Responsible { get; set; }
        public string? Note { get; set; }
        public string? OutputFormat { get; set; }
        public long? DeliverableId { get; set; }
    }
}
