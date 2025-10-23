using Logix.Domain.OPM;
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.OPM
{
    public class OpmContractAssignmentWithEmployeVM 
    {
        public OpmContarctAssignVM Assignment { get; set; }
        public List<OpmContarctEmpVw> Employees { get; set; }
    }
    public class OpmContarctAssignVM
    {
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string? AssignDate { get; set; }

        public long? ContractId { get; set; }
        public string? ContractName { get; set; }
        public string? ContractCode { get; set; }

        public bool? IsActive { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
       
    }
    public class OpmContarctAssignDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string? AssignDate { get; set; }

        public long? ContractId { get; set; }      

        public bool? IsActive { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
       
    }
    public class OpmContarctAssignEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string? AssignDate { get; set; }

        public long? ContractId { get; set; }      

        public bool? IsActive { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
       
    }
}
