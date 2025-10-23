using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM
{
    public class PmExtractTransactionsPaymentDto
    {
       
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
     
        public int? BranchId { get; set; }
    
        public long? TransactionId { get; set; }
    
        [StringLength(10)]
        public string? PaymentDate { get; set; }
    
        [StringLength(10)]
        public string? PaymentDate2 { get; set; }
    
        public decimal? AmountReceived { get; set; }
      
        public int? PaymentMethodId { get; set; }
    
        public int? BankId { get; set; }
     
        [StringLength(50)]
        public string? BankReference { get; set; }
       
        public int? DaysLate { get; set; }

      
        public long? AccountId { get; set; }
   
        public long? JId { get; set; }
    }
    public class PmExtractTransactionsPaymentEditDto
    {
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }

        public int? BranchId { get; set; }

        public long? TransactionId { get; set; }

        [StringLength(10)]
        public string? PaymentDate { get; set; }

        [StringLength(10)]
        public string? PaymentDate2 { get; set; }

        public decimal? AmountReceived { get; set; }

        public int? PaymentMethodId { get; set; }

        public int? BankId { get; set; }

        [StringLength(50)]
        public string? BankReference { get; set; }

        public int? DaysLate { get; set; }




        public long? AccountId { get; set; }

        public long? JId { get; set; }
    }
}
