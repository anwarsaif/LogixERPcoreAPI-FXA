using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsClosingDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public string? ClosingDate { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public long? BranchId { get; set; }
        public long? AppId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public int? AppTypeId { get; set; }

        public List<SaveFileDto>? fileDtos { get; set; }

    }

    public class PmProjectsClosingEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }

        public string? ClosingDate { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }

        public long? BranchId { get; set; }
        public long? AppId { get; set; }
        public string? Note { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }

    }
}
