namespace Logix.Application.DTOs.WF
{
    public class WfApplicationsStatusDto
    {
        public long Id { get; set; }
        public long? ApplicationsId { get; set; }
        public long? ApplicantsId { get; set; }
        public int? StatusId { get; set; }
        public int? NewStatusId { get; set; }
        public int? StepId { get; set; }
        public int? OldStepId { get; set; }
        public string? DesNo { get; set; }
        public string? CouncilNo { get; set; }
        public string? CouncilDate { get; set; }
        public string? Note { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? DueDate { get; set; }
    }


}
