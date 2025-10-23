using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Logix.Application.DTOs.Main
{
    public class SysActivityLogDto
    {
        public long ActivityLogId { get; set; }

        [StringLength(50)]
        public string? UserId { get; set; }

        public DateTime? ActivityDate { get; set; }

        public int? TableId { get; set; }

        public long? TablePrimarykey { get; set; }

        public int? ActivityTypeId { get; set; }

        public long? ScreenId { get; set; }
    }

    public class SysActivityLogFilterDto
    {
        public long? ScreenId { get; set; }
        public string? ActivityDateFrom { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        public string? ActivityDateTo { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        public int? ActivityTypeId { get; set; }
        public string? UserId { get; set; }
        public long? TablePrimarykey { get; set; }
        public string? UserFullname { get; set; }
    }

    public class SysActivityLogVM
    {
        public string? ScreenName { get; set; }
        public string? ScreenName2 { get; set; }
        public int? TranscationCount { get; set; }

        public string? ActivityType { get; set; }
        public string? UserFullname { get; set; }
        public string? ActivityDate { get; set; }
        public long? TablePrimarykey { get; set; }
    }
}