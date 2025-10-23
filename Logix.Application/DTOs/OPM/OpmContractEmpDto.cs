using Logix.Application.DTOs.Main;
using Logix.Domain.OPM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Logix.Application.DTOs.OPM
{
    public class OpmContractEmpDto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string? Date1 { get; set; }

        public long? ContractId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public int? LocationId { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string? DateJoin { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        public long? EmpId { get; set; }

        [StringLength(1500)]
        public string? Notes { get; set; }

        public bool? IsActive { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? EmpName2 { get; set; }
        public string? ContractCode { get; set; }
        public string LocationName { get; set; } = null!;

        public string? LocationName2 { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Attendance { get; set; }
        public decimal? AbsenceCoun { get; set; }
        public decimal? Absence { get; set; }
        public decimal? Delay { get; set; }

        public int? BranchId { get; set; }

        public int? JobType { get; set; }

        [Column("Job_Catagories_ID")]
        public int? JobCatagoriesId { get; set; }
        [Column("Dept_ID")]
        public int? DeptId { get; set; }
        public long? FinYear { get; set; }
        [StringLength(10)]
        public string StartDate { get; set; } = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        [StringLength(10)]
        public string? EndDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();

        public bool IsSelected { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public long? ItemsId { get; set; }

        public string? ContractName { get; set; }
        public string? DateofAssign { get; set; }
        public long? ContarctAssignId { get; set; }

        //for check when assigned
        public int? NationalityId { get; set; }
    }
    public class OpmContarctEmpEditDto
    {
        public long Id { get; set; }

        [StringLength(10)]
        public string? Date1 { get; set; }

        public long? ContractId { get; set; }

        public int? LocationId { get; set; }

        [StringLength(10)]
        public string? DateJoin { get; set; }

        public long? EmpId { get; set; }

        [StringLength(1500)]
        public string? Notes { get; set; }

        public bool? IsActive { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public long? ItemsId { get; set; }

    }

    public class OpmContarctEmpVm
    {
        //نستخدم هذا الكلاس في صفحة اسناد موظفين العقد
        public OpmContractDto OpmContractDto { get; set; }
        public OpmContractEmpDto OpmContractEmpDto { get; set; }
        public OpmContarctAssignDto OpmContarctAssignDto { get; set; }

        public List<OpmContractEmpDto> Children { get; set; }
        public List<InvestEmployeeDto> EmpRes { get; set; }
        public InvestEmployeeDto SearchDto { get; set; }
        public OpmContarctEmpVm()
        {
            OpmContractDto = new OpmContractDto();
            OpmContractEmpDto = new OpmContractEmpDto();
            Children = new List<OpmContractEmpDto>();
            EmpRes = new List<InvestEmployeeDto>();
            SearchDto = new InvestEmployeeDto();
            OpmContarctAssignDto = new OpmContarctAssignDto();


        }
    }

    public class OpmContarctEmpPartialVm
    {
        //نستخدم هذا الكلاس في صفحة اسناد موظفين العقد في البارشال فيو
        public List<InvestEmployeeDto> Children { get; set; }
        public InvestEmployeeDto SearchDto { get; set; }
        public OpmContarctEmpPartialVm()
        {
            Children = new List<InvestEmployeeDto>();
            SearchDto = new InvestEmployeeDto();
        }
    }
    public class PrintContractEmpDto
    {


        public List<OpmContarctEmpVw> Details { get; set; }
        public string? FacilityLogo { get; set; }
        public string? FacilityName { get; set; }
        public string? FacilityName2 { get; set; }
        public string? PrintDate { get; set; } = DateTime.Now.ToString("HH:mm:fff yyyy-MM-dd", CultureInfo.InvariantCulture);
        public PrintContractEmpDto()
        {
            Details = new List<OpmContarctEmpVw>();
        }


    }
}
