using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.SAL.SALTransactionsCommission
{
    public class SalTransactionsCommissionEditDto
    {
       
        public long Id { get; set; }
       
        public long? TransactionId { get; set; }
      
        public int? TypeId { get; set; }
      
        public long? EmpId { get; set; }
      
        public long? ProjectId { get; set; }
  
        public decimal? Rate { get; set; }
      
        public decimal? Amount { get; set; }
        public string? Note { get; set; }

     
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [Required]
        public string? EmpCode { get; set; }

        public long? ProjectCode { get; set; }
    }
}
