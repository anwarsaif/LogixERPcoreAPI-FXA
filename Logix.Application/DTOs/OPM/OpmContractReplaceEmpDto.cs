using Logix.Domain.OPM;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Logix.Application.DTOs.OPM
{
    public class PrintOpmContractReplaceEmpDto
    {


        public List<OpmContractReplaceEmpVw> Details { get; set; }
        public string? FacilityLogo { get; set; }
        public string? FacilityName { get; set; }
        public string? FacilityName2 { get; set; }
        public string? PrintDate { get; set; } = DateTime.Now.ToString("HH:mm:fff yyyy-MM-dd", CultureInfo.InvariantCulture);
        public PrintOpmContractReplaceEmpDto()
        {
            Details = new List<OpmContractReplaceEmpVw>();
        }


    }
    public class OpmContractReplaceEmpDto
    {
        public long? Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Date1 { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        [Required]
        public long? EmpId { get; set; }

        [Range(1, long.MaxValue)]
        public int TypeId { get; set; }

        [Range(1, long.MaxValue)]
        public int ReasonId { get; set; }

        [Required]
        public long? EmpId2 { get; set; }
        public long? ContractId { get; set; }
        public long? ContractId2 { get; set; }
        //مواقع العقد الجديد(الذي سيتم نقل الموظف اليه
        public int? NewContractLocationId { get; set; }
        public long? NewContractitemsId { get; set; }
        public int? LocationId { get; set; }

        public int? LocationId2 { get; set; }

        public string? ReasonsNotes { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        //this for display only
        public string? ContractName { get; set; }
        public long? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? EmpName { get; set; }
        public string? NewEmpName { get; set; }

        //display
        public string? ContractCode { get; set; }
        public string? CustomerCode { get; set; }

        public string? ContractCode2 { get; set; }
        public string? ContractName2 { get; set; }

    }

    public class OpmContractReplaceEmpEditDto
    {
        public long Id { get; set; }

        [StringLength(10)]
        public string? Date1 { get; set; }

        public int? TypeId { get; set; }

        public long? ContractId { get; set; }

        public int? LocationId { get; set; }

        public long? EmpId { get; set; }

        public long? EmpId2 { get; set; }

        public int? LocationId2 { get; set; }

        public int? ReasonId { get; set; }

        public string? ReasonsNotes { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
