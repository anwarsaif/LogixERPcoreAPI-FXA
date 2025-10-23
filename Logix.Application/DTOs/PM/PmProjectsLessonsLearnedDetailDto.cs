namespace Logix.Application.DTOs.PM
{
    public class PmProjectsLessonsLearnedDetailDto
    {
        public long? Id { get; set; }
        public long? MasterId { get; set; }
        public long? ProjectId { get; set; }
        public string? Description { get; set; }
        public string? ProjectImpact { get; set; }
        public string? ProjectEffect { get; set; }
        public int? ImpactType { get; set; }
        public string? Solutions { get; set; }
        public int? ProcedureType { get; set; }
        public int? FollowApplyType { get; set; }
        public string? LessonLeaned { get; set; }
        public int? LessonLearnedCats { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class PmProjectsLessonsLearnedDetailEditDto
    {
        public long Id { get; set; }
        public long? MasterId { get; set; }
        public long? ProjectId { get; set; }
        public string? Description { get; set; }
        public string? ProjectImpact { get; set; }
        public string? ProjectEffect { get; set; }
        public int? ImpactType { get; set; }
        public string? Solutions { get; set; }
        public int? ProcedureType { get; set; }
        public int? FollowApplyType { get; set; }
        public string? LessonLeaned { get; set; }
        public int? LessonLearnedCats { get; set; }
        public string? Note { get; set; }
    }
}
