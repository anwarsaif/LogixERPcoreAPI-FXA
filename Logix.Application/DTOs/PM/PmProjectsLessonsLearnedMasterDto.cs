using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsLessonsLearnedMasterDto
    {
        public long? Id { get; set; }
        public string? CreationDate { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }

        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }

        public long? BranchId { get; set; }
        public long? AppId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Description { get; set; }
        public string? ProjectImpact { get; set; }
        public string? ProjectEffect { get; set; }
        public int? ImpactType { get; set; }
        public string? Solutions { get; set; }
        public int? ProcedureType { get; set; }
        public int? FollowApplyType { get; set; }
        public string? LessonLeaned { get; set; }
        public int? LessonLearnedCats { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }
        public int? AppTypeId { get; set; }
    }

    public class PmProjectsLessonsLearnedMasterEditDto
    {
        public long Id { get; set; }
        public string? CreationDate { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public long? BranchId { get; set; }
        public long? AppId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Description { get; set; }
        public string? ProjectImpact { get; set; }
        public string? ProjectEffect { get; set; }
        public int? ImpactType { get; set; }
        public string? Solutions { get; set; }
        public int? ProcedureType { get; set; }
        public int? FollowApplyType { get; set; }
        public string? LessonLeaned { get; set; }
        public int? LessonLearnedCats { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }
    }

    
}
