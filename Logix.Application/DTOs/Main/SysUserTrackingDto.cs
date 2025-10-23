using System.Globalization;

namespace Logix.Application.DTOs.Main
{
    public class SysUserTrackingFilterDto
    {
        public string? ActivityDateFrom { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        public string? ActivityDateTo { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        public int? UserId { get; set; }
    }

    public class SysUserTrackingVm
    {
        public string? Url { get; set; }
        public string? UserFullName { get; set; }
        public string? Date { get; set; }
    }

    public class SysUserTrackingDto
    {
        public long Id { get; set; }
        public string? Url { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UserId { get; set; }
        public int? EmpId { get; set; }
    }
}