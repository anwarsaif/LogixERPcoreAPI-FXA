using Castle.MicroKernel.SubSystems.Conversion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class OPMTransactionsDetailsDto
    {


        public long Id { get; set; }

        public long? TransactionId { get; set; }
        public long? Msid { get; set; }
        public long? idForFilter { get; set; }

        public decimal? DiscRate { get; set; } = 0;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; } = 0;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        public decimal? Total { get; set; }

        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }
        public decimal? Net { get; set; }
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long? MsCode { get; set; }
        public string? MsDate { get; set; }
        public string? MsTitle { get; set; }

        public string? MsMonth { get; set; }
        public string? MsMothTxt { get; set; }
        [Required]
        public int? FinancelYear { get; set; } = 0;
        public int IncreasId { get; set; }

        public string? NationalityName { get; set; }
        public string? CatName { get; set; }

        public int? JobCatagoriesId { get; set; }

        public int? NationalityId { get; set; }
        //[Required(ErrorMessage = "*")]
        public string? ContractCode { get; set; }
        public string? ContractName { get; set; }
        public int? Qty { get; set; }
        public int? CountDayWork { get; set; }
        public decimal? DayPrice { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        public long? LocationId { get; set; }
        public decimal? OverTime { get; set; }
        public decimal? HOverPrice { get; set; }

        public decimal? HOvertotal { get; set; }
        public int? DaysAbsence { get; set; }
        public decimal? Absenceprice { get; set; }
      
        public int? OverTimeType { get; set; }
        public long? ItemsId { get; set; }
        public long? ItemId { get; set; }
    
        public long? ContractId { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }

        public int? TransTypeId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public int? BranchId { get; set; }
        //using in search (filter)
        [StringLength(10)]
        public string? FromDate { get; set; }
        [StringLength(10)]
        public string? ToDate { get; set; }
        public long? EmpId { get; set; }
        public long? CustomerId { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? EmpName2 { get; set; }
        [StringLength(250)]
       
        public string? CustomerCode { get; set; }
        [StringLength(2500)]
       
        public string? CustomerName { get; set; }
        public string? ContractCodeS { get; set; }

        public int? SysDepLocationId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Absence { get; set; }

    }
}
