using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.SAL.SALTransactionsCommission
{
    public class SalTransactionsCommissionAddDto
    {
       
        public long Id { get; set; }
       
        public long? TransactionId { get; set; }
      
        public int? TypeId { get; set; }
      
        public long? EmpId { get; set; }
      
        public long? ProjectId { get; set; }
  
        public decimal? Rate { get; set; }
      
        public decimal? Amount { get; set; }
        public string? Note { get; set; }
        //custom not  in table
        public long? CalculationType { get; set; }
        [Required]
        public string? EmpCode { get; set; }

        public long? ProjectCode { get; set; }

    }  
}
