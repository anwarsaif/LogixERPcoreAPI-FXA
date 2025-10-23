
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class OpmTransactionsItemDto
    {
        public long Id { get; set; }
        public int IncreasId { get; set; }
        public long? TransactionId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public int? JobCatagoriesId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public int? NationalityId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public int? GenderId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "*")]

        [Required(ErrorMessage = "*")]
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        //[Range(1, int.MaxValue, ErrorMessage = "*")]
        [Required(ErrorMessage = "*")]
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salary { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        public decimal? Total { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        public int? CurrencyId { get; set; }
        [Column(TypeName = "decimal(18, 10)")]
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        public decimal? ExchangeRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public decimal? WorkHours { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public int? WorkDays { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public int? OverTimePolicy { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public int? AbsencePolicy { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public int? LatePolicy { get; set; }

        
        public string? Description { get; set; }

        public long? AccountId { get; set; }

        public long? CcId { get; set; }

        public long? SalTId { get; set; }

        public long? SalPId { get; set; }
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string? GenderName { get; set; }
        public string? JobCatagoriesName { get; set; }
        public string? NationalityName { get; set; }
    }

    public class OpmTransactionsItemEditDto
    {
        public long Id { get; set; }

        public long? TransactionId { get; set; }

        public long? JobCatagoriesId { get; set; }

        public long? NationalityId { get; set; }

        public long? GenderId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salary { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }

        public int? CurrencyId { get; set; }
        [Column(TypeName = "decimal(18, 10)")]
        public decimal? ExchangeRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WorkHours { get; set; }
        public int? WorkDays { get; set; }
        public int? OverTimePolicy { get; set; }
        public int? AbsencePolicy { get; set; }
        public string? Description { get; set; }

        public long? AccountId { get; set; }

        public long? CcId { get; set; }

        public long? SalTId { get; set; }

        public long? SalPId { get; set; }

        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
    }
}
