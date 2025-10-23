

namespace Logix.Application.DTOs.Main
{
    public class SysScreenPermissionDto
    {
        public long PriveId { get; set; }

        public long? UserId { get; set; }

        public long? ScreenId { get; set; }

        public bool? ScreenShow { get; set; }

        public bool? ScreenAdd { get; set; }

        public bool? ScreenEdit { get; set; }

        public bool? ScreenDelete { get; set; }

        public bool? ScreenPrint { get; set; }
        public int? GroupId { get; set; }

        public bool? ScreenExport { get; set; }
        public bool? ScreenImport { get; set; }
        public bool? ScreenApproval { get; set; }
        public bool? ScreenReject { get; set; }
        public bool? ScreenView { get; set; }

        //for display only
        public string? ScreenName { get; set; }
    }

    public class SysScreenPermissionDtoVM
    {
        //نستخدم هذا الكلاس في التعديل على صلاحية الشاشات
        public long PriveId { get; set; }

        public long? UserId { get; set; }

        public long? ScreenId { get; set; }

        public bool ScreenShow { get; set; }

        public bool ScreenAdd { get; set; }

        public bool ScreenEdit { get; set; }

        public bool ScreenDelete { get; set; }

        public bool ScreenPrint { get; set; }

        public int? GroupId { get; set; }

        public bool? ScreenExport { get; set; }
        public bool? ScreenImport { get; set; }
        public bool? ScreenApproval { get; set; }
        public bool? ScreenReject { get; set; }
        public bool? ScreenView { get; set; }

        //for display only
        public string? ScreenName { get; set; }
        public string? ScreenName2 { get; set; }
        public int? ParentId { get; set; }
    }

    public class FormsPermissionDtoVM
    {
        //نستخدم هذا الكلاس في التعديل على صلاحية نماذج الأتمته
        //public long PriveId { get; set; }
        public int? GroupId { get; set; }
        public int FormId { get; set; }
        public bool FormSend { get; set; }
        public bool FormQery { get; set; }

        //for display only
        public string? FormName { get; set; }
        public string? FormName2 { get; set; }
    }

    public class SysScreenGrouopPermissionWM
    {
        //هل يملك نظام الأتمته
        public bool HasAutomationSys { get; set; }

        //for SysGroup
        public SysGroupEditDto SysGroupDto { get; set; }

        //for dropdown list, that change table according to these two variables
        public int? SystemIdDdl { get; set; }
        public long[] ParentScreenIdDdl { get; set; }

        //to show data of screen in table
        public List<SysScreenPermissionDtoVM>? SysScreenPermissionDtos { get; set; }
        public List<FormsPermissionDtoVM>? FormsPermissionDtos { get; set; }
        public SysScreenGrouopPermissionWM()
        {
            HasAutomationSys = false;
            SysGroupDto = new SysGroupEditDto();
            SysScreenPermissionDtos = new List<SysScreenPermissionDtoVM>();
            FormsPermissionDtos = new List<FormsPermissionDtoVM>();
            ParentScreenIdDdl = Array.Empty<long>();
        }
    }
}