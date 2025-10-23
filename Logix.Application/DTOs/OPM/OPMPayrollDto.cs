
using Logix.Domain.OPM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Logix.Application.DTOs.OPM
{
    public class OPMPayrollDto
    {

        public long MsId { get; set; }
        public long? MsCode { get; set; }
        public string? MsDate { get; set; }
        public string? MsTitle { get; set; }

        public string? MsMonth { get; set; }
        public string? MsMothTxt { get; set; }
        [Required]
        public int? FinancelYear { get; set; }

        public int? State { get; set; }

        public string? AuditBy { get; set; }

        public DateTime? AuditOn { get; set; }

        public string? ApproveBy { get; set; }

        public DateTime? ApproveOn { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int? FacilityId { get; set; }
        public int? PayrollTypeId { get; set; }


        public string? PaymentDate { get; set; }

        public string? DueDate { get; set; }
        public long? AppId { get; set; }

        public bool? Posted { get; set; }

        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? EmpName2 { get; set; }
        [Required(ErrorMessage = "*")]
        public string? ContractCode { get; set; }
        public string? LocationName { get; set; }

        public string? LocationName2 { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Attendance { get; set; }
        public decimal? AbsenceCoun { get; set; }
        public decimal? Absence { get; set; }
        public decimal? Delay { get; set; }

        //[Range(1, int.MaxValue, ErrorMessage = "*")]
        public bool EnableBranch { get; set; } = false;

        public long? BranchId { get; set; }

        public int? JobType { get; set; }
        [Required]
        [Column("Job_Catagories_ID")]
        public int? JobCatagoriesId { get; set; }
        [Column("Dept_ID")]
        public int? DeptId { get; set; }

        [StringLength(10)]
        public string StartDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        //public string StartDate { get; set; } 

        [StringLength(10)]
        public string? EndDate { get; set; }

        public OPMPayrollDto()
        {
            EndDate = GetEndOfMonthDate(DateTime.Now);
        }

        private string GetEndOfMonthDate(DateTime currentDate)
        {
            DateTime endOfMonth = new DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month));
            return endOfMonth.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        }

        public bool IsSelected { get; set; }
        public int? LocationId { get; set; }
        //[Required(ErrorMessage = "*")]
        public string? ContractName { get; set; }
        public string? ContractCodeS { get; set; }

    }
    public class PayrollResultDto
    {
        public int MSID { get; set; }
        public long? MSCode { get; set; }
        public string MSDate { get; set; }
        public string MSMonth { get; set; }
        public string MSMothTxt { get; set; }
        public string FinancelYear { get; set; }
        public decimal? TotalNet { get; set; }
    }
    public class OPMPayrollVm
    {
        public OPMPayrollDto OPMPayrollDto { get; set; }

        public List<OPMPayrollDDto> Children { get; set; }
        public List<OPMPayrollDVW> Children2 { get; set; }
        public OPMPayrollVm()
        {
            OPMPayrollDto = new OPMPayrollDto();
            Children = new List<OPMPayrollDDto>();
            Children2 = new List<OPMPayrollDVW>();
        }
    }


    public class PrintPayrollVM
    {
        public string? FacilityName { get; set; }
        public string? FacilityLogo { get; set; }
        public string? FacilityName2 { get; set; }
        public string? FacilityAddress { get; set; }
        public string? FacilityMobile { get; set; }
        public string? FacilityLogoPrint { get; set; }
        public string? UserName { get; set; }
        public long MsId { get; set; }




        public List<OPMPayrollDVW> Children2 { get; set; }
        public PrintPayrollVM()
        {
            Children2 = new List<OPMPayrollDVW>();
        }
    }
}
