
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class OpmContractDto
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(1500)]
        [Required]
        public string? Name { get; set; }
        [StringLength(10)]
        [Required]
        public string? ContractDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        public int? FacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
        public string? BraName { get; set; }
        public string? BraName2 { get; set; }

        public long? CustomerId { get; set; }
        [StringLength(250)]
        public string? CustomerCode { get; set; }
        [StringLength(2500)]
        [Required]
        public string? CustomerName { get; set; }
        [StringLength(10)]
        [Required]
        public string? StartDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        [StringLength(10)]
        [Required]
        public string? EndDate { get; set; } = DateTime.Now.AddYears(1).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        public long? QuotationId { get; set; }
        [StringLength(50)]
        //[Required]
        public string? QuotationCode { get; set; }
        [Range(1, long.MaxValue)]
        public int? CurrencyId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, long.MaxValue)]
        public decimal ExchangeRate { get; set; }

        public long? Empid { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }

        [Required]
        public int NoticeDuration { get; set; }
        public bool AutomaticRenewal { get; set; }
        public string? Description { get; set; }
        public string? DocumentNote { get; set; }
        public string? ContractIncludes { get; set; }
        public string? DeliveryTerm { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PaymentTermsEN { get; set; }
        public string? ContractTerms { get; set; }
        public string? ContractTermsEN { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        //[Required]
        public decimal ContractAmount { get; set; }
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public int? TransTypeId { get; set; }

        public long? SupplierId { get; set; }
        [StringLength(250)]
        public string? SupplierCode { get; set; }
        [StringLength(2500)]
        [Required]
        public string? SupplierName { get; set; }

        //عدد العمال في العقد_ نستخدمه في شاشة اسناد الموظفين
        public string? EmpCount { get; set; }
        //using in search (filter)
        [StringLength(10)]
        public string? FromDate { get; set; }
        [StringLength(10)]
        public string? ToDate { get; set; }
        public string? ConditionsAddition { get; set; }
        public string? ConditionsAdditionEN { get; set; }
        }

    public class OpmContractEditDto
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(1500)]
        [Required]
        public string? Name { get; set; }
        [StringLength(10)]
        [Required]
        public string? ContractDate { get; set; }

        public int? FacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
        public string? BraName { get; set; }
        public string? BraName2 { get; set; }

        public long? CustomerId { get; set; }
        [StringLength(250)]
        public string? CustomerCode { get; set; }
        [StringLength(2500)]
        [Required]
        public string? CustomerName { get; set; }
        [StringLength(10)]
        [Required]
        public string? StartDate { get; set; }
        [StringLength(10)]
        [Required]
        public string? EndDate { get; set; }

        public long? QuotationId { get; set; }
        [StringLength(50)]
        //[Required]
        public string? QuotationCode { get; set; }
        [Range(1, long.MaxValue)]
        public int? CurrencyId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, long.MaxValue)]
        public decimal ExchangeRate { get; set; }

        public long? Empid { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }

        [Required]
        public int NoticeDuration { get; set; }
        public bool AutomaticRenewal { get; set; }
        public string? Description { get; set; }
        public string? DocumentNote { get; set; }
        public string? ContractIncludes { get; set; }
        public string? DeliveryTerm { get; set; }
        public string? PaymentTerms { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        [Required]
        public decimal ContractAmount { get; set; }

        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        
        public int? TransTypeId { get; set; }

        public long? SupplierId { get; set; }
        [StringLength(250)]
        public string? SupplierCode { get; set; }
        [StringLength(2500)]
        [Required]
        public string? SupplierName { get; set; }

        //عدد العمال في العقد_ نستخدمه في شاشة اسناد الموظفين
        public string? EmpCount { get; set; }
        public string? ConditionsAddition { get; set; }
    }
}
