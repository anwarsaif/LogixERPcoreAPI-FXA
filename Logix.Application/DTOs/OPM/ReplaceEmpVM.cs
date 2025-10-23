using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class ReplaceEmpVM
    {
        //this from OpmContractEmp
        //public long? EmpId { get; set; }
        public string? EmpId { get; set; }
        public string? EmpName { get; set; }
        public long ContractId { get; set; }
        public int? LocationId { get; set; }

        //this from OpmContractVw
        public string? ContractName { get; set; }
        public long? CustomerId { get; set; }
        public string? CustomerName { get; set; }

        //
        public string? ContractCode { get; set; }
        public string? CustomerCode { get; set; }
    }
}
