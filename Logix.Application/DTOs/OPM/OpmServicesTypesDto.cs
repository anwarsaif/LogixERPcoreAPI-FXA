using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logix.Application.DTOs.OPM
{
    public class OpmServicesTypesDto
    {
       
        public long Id { get; set; }

        public long? Code { get; set; }
        [StringLength(2500)]
        public string? ServiceName { get; set; }
        [StringLength(2500)]
        public string? ServiceName2 { get; set; }
        public int? StatusId { get; set; }
        public long? FacilityId { get; set; }
        public long? RevenueAccountId { get; set; }
        
        public long? ExpenseAccountId { get; set; }
        public long? DiscountAccountId { get; set; }
        public long? DiscountCreditAccountId { get; set; }
       
        public long? SalesReturnsAccountId { get; set; }
        public long? CreatedBy { get; set; }
       
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
   
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long? ParentId { get; set; }
        public string? RevenueAccountCode { get; set; }
        public string? RevenueAccountName { get; set; }
        public string? ExpenseAccountCode { get; set; }
        public string? ExpenseAccountName { get; set; }

        public string? DiscountAccountCode { get; set; }
        public string? DiscountAccountName { get; set; }

        public string? DiscountCreditAccountCode { get; set; }
        public string? DiscountCreditAccountName { get; set; }

        public string? SalesReturnsAccountCode { get; set; }
        public string? SalesReturnsAccountName { get; set; }


    }
    public class OpmServicesTypesEditDto
    {

        public long Id { get; set; }

        public long? Code { get; set; }
        [StringLength(2500)]
        public string? ServiceName { get; set; }
        //[StringLength(2500)]
        //public string? ServiceName2 { get; set; }
        public int? StatusId { get; set; }
        public long? FacilityId { get; set; }
        public long? RevenueAccountId { get; set; }

        public long? ExpenseAccountId { get; set; }
        public long? DiscountAccountId { get; set; }
        public long? DiscountCreditAccountId { get; set; }

        public long? SalesReturnsAccountId { get; set; }
      
        public bool? IsDeleted { get; set; }
        public long? ParentId { get; set; }
        public string? RevenueAccountCode { get; set; }
        public string? RevenueAccountName { get; set; }
        public string? ExpenseAccountCode { get; set; }
        public string? ExpenseAccountName { get; set; }

        public string? DiscountAccountCode { get; set; }
        public string? DiscountAccountName { get; set; }

        public string? DiscountCreditAccountCode { get; set; }
        public string? DiscountCreditAccountName { get; set; }

        public string? SalesReturnsAccountCode { get; set; }
        public string? SalesReturnsAccountName { get; set; }
    }
}
