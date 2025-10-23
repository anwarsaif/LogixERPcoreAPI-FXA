using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.WF
{
    public class WfStepsNotificationDto
    {
        public long Id { get; set; }
        public long? StepId { get; set; }
        [Range(1, int.MaxValue)]
        public int? TypeId { get; set; }
        public string? GroupsId { get; set; }
        public string? UsersId { get; set; }
        public string? Emails { get; set; }
        public string? SysMessage { get; set; }
        public string? EmailMessage { get; set; }
        public string? SmsMessage { get; set; }
        public string? Note { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class WfStepsNotificationEditDto
    {
        public long Id { get; set; }
        public long? StepId { get; set; }
        [Range(1, int.MaxValue)]
        public int? TypeId { get; set; }
        public string? GroupsId { get; set; }
        public string? UsersId { get; set; }
        public string? Emails { get; set; }
        public string? SysMessage { get; set; }
        public string? EmailMessage { get; set; }
        public string? SmsMessage { get; set; }
        public string? Note { get; set; }
    }
}
