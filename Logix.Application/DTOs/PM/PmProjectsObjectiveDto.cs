namespace Logix.Application.DTOs.PM
{
    public class PmProjectsObjectiveDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Objective { get; set; }
        public string? SuccessCriteria { get; set; }
        public string? Responsible { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class PmProjectsObjectiveEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string? Objective { get; set; }
        public string? SuccessCriteria { get; set; }
        public string? Responsible { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
