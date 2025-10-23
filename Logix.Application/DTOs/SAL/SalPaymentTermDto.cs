using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.SAL
{
    public class SalPaymentTermDto
    {
        
        public long Id { get; set; }
    
        public string? PaymentTerms { get; set; }
        public bool? IsDeleted { get; set; }
      
        public string? PaymentTerms2 { get; set; }
    }
}
