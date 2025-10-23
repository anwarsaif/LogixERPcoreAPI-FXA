using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.WF
{
    public class WfStepsTransactionFilterDto
    {
        public int? AppTypeId { get; set; }
    }

    public class WfStepsTransactionDto
    {
        public long Id { get; set; }
        [Range(1, int.MaxValue)]
        public int? AppTypeId { get; set; }
        [Required]
        public string? FromStepId { get; set; }
        [Required]
        public string? ToStepId { get; set; }
        public int? SortNo { get; set; }
        public string? GroupsId { get; set; }
        public string? StatusId { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public bool IsDeleted { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
    }

    public class WfStepsTransactionEditDto
    {
        public long Id { get; set; }
        [Range(1, int.MaxValue)]
        public int? AppTypeId { get; set; }
        [Required]
        public string? FromStepId { get; set; }
        [Required]
        public string? ToStepId { get; set; }
        //public int? SortNo { get; set; }
        public string? GroupsId { get; set; }
        public string? StatusId { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }

        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }

    public class SendEmailDto
    {
        public string? Email { get; set; }
        public string? Subject { get; set; }
    }
}
