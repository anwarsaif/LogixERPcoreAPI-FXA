using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.WF
{
    public class StepViewModel
    {
        public string StepName { get; set; }
        public bool IsEnabled { get; set; }
    }
    public class WFStepVM
    {
        public long ID { get; set; }
        public string From_Step_Name { get; set; }
        public int Cnt { get; set; }
    }


    public class WfStepFilterDto
    {
        public string? StepName { get; set; }
        public string? StepName2 { get; set; }
        public int? AppTypeId { get; set; }
    }

    public class WfStepDto
    {
        public int Id { get; set; }
        [Range(1,int.MaxValue)]
        public int? AppTypeId { get; set; }
        [Required]
        public string? StepName { get; set; }
        [Required]
        public string? StepName2 { get; set; }
        [Range(1, int.MaxValue)]
        public int? StepTypeId { get; set; }
        [Required]
        public int? DurationDays { get; set; }
        [Required]
        public string? DurationTime { get; set; }
        public bool IsCouncil { get; set; }
        public int? CommitteeType { get; set; }
        public long? CommitteeId { get; set; }
        public bool CommitteeSelection { get; set; }
        public bool AllowAttach { get; set; }
        public bool SendOnly { get; set; }
        public bool Isdecision { get; set; }
        public long? DecisionsType { get; set; }
        public bool ChkEmpId { get; set; }
        public bool ChkUserId { get; set; }
        public bool ChkManagerId { get; set; }
        public bool ChkDepId { get; set; }
        public bool? ChkLocationId { get; set; }
        public bool ChkAlternativeEmpId { get; set; }
        public bool ChkManager1Id { get; set; }
        public bool ChkManager2Id { get; set; }
        public bool ChkDepManagerId { get; set; }
        public bool ChkLocationManagerId { get; set; }
        public bool ChkProjectManagerId { get; set; }
        public bool ChkCustomerId { get; set; }
        public bool ChkSignDecision { get; set; }
        public bool ChkFacility { get; set; }
        public bool ChkBranchs { get; set; }
        public bool ChkBranch { get; set; }

        public int? LevelNo { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class WfStepEditDto
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue)]
        public int? AppTypeId { get; set; }
        [Required]
        public string? StepName { get; set; }
        [Required]
        public string? StepName2 { get; set; }
        [Range(1, int.MaxValue)]
        public int? StepTypeId { get; set; }
        [Required]
        public int? DurationDays { get; set; }
        [Required]
        public string? DurationTime { get; set; }
        public bool IsCouncil { get; set; }
        public int? CommitteeType { get; set; }
        public long? CommitteeId { get; set; }
        public bool CommitteeSelection { get; set; }
        public bool AllowAttach { get; set; }
        public bool SendOnly { get; set; }
        public bool Isdecision { get; set; }
        public long? DecisionsType { get; set; }
        public bool ChkEmpId { get; set; }
        public bool ChkUserId { get; set; }
        public bool ChkManagerId { get; set; }
        public bool ChkDepId { get; set; }
        public bool? ChkLocationId { get; set; }
        public bool ChkAlternativeEmpId { get; set; }
        public bool ChkManager1Id { get; set; }
        public bool ChkManager2Id { get; set; }
        public bool ChkDepManagerId { get; set; }
        public bool ChkLocationManagerId { get; set; }
        public bool ChkProjectManagerId { get; set; }
        public bool ChkCustomerId { get; set; }
        public bool ChkSignDecision { get; set; }
        public bool ChkFacility { get; set; }
        public bool ChkBranchs { get; set; }
        public bool ChkBranch { get; set; }

        public int? LevelNo { get; set; }
    }
}