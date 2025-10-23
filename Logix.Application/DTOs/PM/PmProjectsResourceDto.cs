using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsResourceDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public string? ResourceType { get; set; }
        public int? InternalOrExternal { get; set; }
        public long? DeptId { get; set; }
        public long? ManagerId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AppId { get; set; }
        public int? AppTypeId { get; set; }
        //  متغير جديد للتخصيص في السيرفس هل تتم الاضافه مع الارسال الى الخدمة الذاتية ام لا اذا كانت قيمته 1 يتم الارسال
        public int? SendToWorkFlow { get; set; }
        public List<SaveFileDto>? fileDtos { get; set; }

    }
    public class PmProjectsResourceEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string? ResourceType { get; set; }
        public int? InternalOrExternal { get; set; }
        public long? DeptId { get; set; }
        public long? ManagerId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AppId { get; set; }
    }


    public class PmProjectsResourceFilterDto
    {
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public long? Id { get; set; }
        public long? DeptId { get; set; }

    }
}
