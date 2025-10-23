namespace Logix.Application.DTOs.Main
{
    public class UserPermissionSearchVm
    {
        public long? UserId { get; set; }
        public int? SystemId { get; set; }
        public int? ScreenId { get; set; }

        public string? UserName { get; set; }
        public string? ScreenName { get; set; }
        public string? ScreenName2 { get; set; }
        public string? SystemName { get; set; }
        public bool? ScreenAdd { get; set; }
        public bool? ScreenEdit { get; set; }
        public bool? ScreenDelete { get; set; }
        public bool? ScreenShow { get; set; }
        public bool? ScreenPrint { get; set; }
        public int? GroupId { get; set; }
    }
}