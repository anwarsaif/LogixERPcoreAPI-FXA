using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Logix.Application.DTOs.Main
{

    public class SysUserLogTimeDto
    {
        public long LogTimeId { get; set; }
        public long? UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LoginTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LogoutTime { get; set; }

        public bool? Offline { get; set; }

        [StringLength(250)]
        public string? IpAddress { get; set; }
    }
    public class SysUserLogTimeSearchVm
    {
        public string? LoginTime { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        public string? LogoutTime { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        public int? UserTypeId { get; set; }
    }
    public class SysUserLogTimeVm
    {
        public string? UserFullName { get; set; }
        public int NumOfEntries { get; set; }
    }
}
