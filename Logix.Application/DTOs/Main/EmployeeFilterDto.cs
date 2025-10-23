
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class EmployeeFilterDto
    {
        public int? BranchId { get; set; }
        [StringLength(250)]
        public string? EmpName { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        public int? JobType { get; set; }
        public int? JobCatagoriesId { get; set; }
        public int? Status { get; set; }
        public int? NationalityId { get; set; }
        [Column("Dept_ID")]
        public int? DeptId { get; set; }
        [StringLength(50)]
        public string? IdNo { get; set; }
        public string? PassId { get; set; }
        public string? EntryNo { get; set; }
        public int? Location { get; set; }
        public int? SponsorsID { get; set; }
        public int? FacilityId { get; set; }
        public int? Level { get; set; }
        public int? Degree { get; set; }
        public int? ContractType { get; set; }
        public int? Protection { get; set; }
        public string? EmpCode2 { get; set; }
        //
        public string? BraName { get; set; }
        public long? Id { get; set; }
    }
    public class HrEmployeeBendingVM
    {
        public long Id { get; set; }
        //رقم الموظف
        public string EmpId { get; set; }
        // رقم الهوية 
        public string? IdNo { get; set; }

        //اسم الموظف عربي
        public string? EmpName { get; set; }

        //اسم الموظف انجليزي
        public string? EmpName2 { get; set; }

        // الفرع
        public string? BraName { get; set; }
        // الادارة / القسم 
        public string? DepName { get; set; }

        // الموقع / المشروع
        public string? LocationName { get; set; }

        //حالة الموظف 
        public string? StatusName { get; set; }

        // تاريخ العقد 
        public string? ContractDate { get; set; }

        //  تاريخ انتهاء العقد 
        public string? ContractExpiryDate { get; set; }

        // بواسطة 
        public string? ByName { get; set; }

        // التفاصيل 
        public string? ReasonStatus { get; set; }

        // التاريخ

        public string? theDate { get; set; }
        public long? ActivityLogId { get; set; }

    }
    public class HrEmployeeBendingFilterVM
    {
        public long Id { get; set; }
        //رقم الموظف
        public string EmpId { get; set; }
        //اسم الموظف عربي
        public string? EmpName { get; set; }
        public int? BranchId { get; set; }
        public int? JobTypeId { get; set; }
        public int? FacilityId { get; set; }
        public int? NationalityId { get; set; }
        //public int? JobNameId { get; set; }
        public int? DeptId { get; set; }
        public string? BorderID { get; set; }
        public int? LocationProjectId { get; set; }
        public int? SponsorsID { get; set; }
        public string? PassportID { get; set; }
        public int? JobCatagoriesId { get; set; }
        public string? IdNo { get; set; }

    }
}
