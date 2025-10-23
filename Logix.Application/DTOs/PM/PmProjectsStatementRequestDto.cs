namespace Logix.Application.DTOs.PM
{
    public class PmProjectsStatementRequestDto
    {
        public long? Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }

        public long? FacilityId { get; set; }
        public string? DateRequest { get; set; }
        public long? AppId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? Description { get; set; }
        public int? ClassiFicationType { get; set; }
        public bool? IsArchived { get; set; }
        public long? Reasonsrequest { get; set; }
        public int? AppTypeId { get; set; }
        public List<long> ProjectsId { get; set; }

    }
    public class PmProjectsStatementRequestEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public long? FacilityId { get; set; }
        public string? DateRequest { get; set; }
        public long? AppId { get; set; }
        public string? Note { get; set; }
        public int? StatusId { get; set; }
        public string? Description { get; set; }
        public int? ClassiFicationType { get; set; }
        public bool? IsArchived { get; set; }
        public long? Reasonsrequest { get; set; }
    }

    public class PmProjectsStatementRequestFilterDto
    {
        public string? Code { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }

    }
}
