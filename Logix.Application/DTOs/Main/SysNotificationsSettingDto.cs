using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysNotificationsSettingDto
    {
        public long Id { get; set; }
        public long? ScreenId { get; set; }
        public int? ActionTypeId { get; set; }
        public string? Users { get; set; }
        public string? MsgTxt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class SysNotificationsSettingEditDto
    {
        public long Id { get; set; }
        public long? ScreenId { get; set; }
        public int? ActionTypeId { get; set; }
        public string? Users { get; set; }
        public string? MsgTxt { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
