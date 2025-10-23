
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurExpenseFilterDto
    {
        public int? TypeId { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public int? MethodCalculation { get; set; }
        //public decimal? CalculationValue { get; set; }
        //public decimal? CalculationRate { get; set; }
        public int? MethodDistribution { get; set; }
    }

    public class PurExpenseDto
    {
        public long? Id { get; set; }
        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        [Required]
        public int? MethodCalculation { get; set; }
        [Required]
        public decimal? CalculationValue { get; set; }
        public decimal? CalculationRate { get; set; }
        [Required]
        public int? MethodDistribution { get; set; }
        public bool? LinkAccounting { get; set; }
        //public long? AccAccountId { get; set; } = 0;
        public string? AccAccountCode { get; set; } 
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Iscost { get; set; }
    }

    public class PurExpenseEditDto
    {
        public long Id { get; set; }
        public int? TypeId { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public int? MethodCalculation { get; set; }
        public decimal? CalculationValue { get; set; }
        public decimal? CalculationRate { get; set; }
        public int? MethodDistribution { get; set; }
        public bool? LinkAccounting { get; set; }
        //public long? AccAccountId { get; set; }
        public string? AccAccountCode { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        //public bool? IsDeleted { get; set; }
        public bool? Iscost { get; set; }
    }
}
