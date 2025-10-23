using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM
{
    public class PmExtractTransactionsProductDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; } = 0;
        public long? ProductId { get; set; } = 0;
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; } = 0;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Total { get; set; } = 0;
        [Column("VAT", TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; } = 0;
        public int? BranchId { get; set; } = 0;
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public long? AccountId { get; set; } = 0;
        public long? PItemsId { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? QtyApprove { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? UnitPriceApprove { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? QtyPrevious { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? AmountPrevious { get; set; } = 0;
        [Column(TypeName = "decimal(18, 8)")]
        public decimal? Rate { get; set; } = 0;
        [Column(TypeName = "decimal(18, 8)")]
        public decimal? AmountRate { get; set; } = 0;
        /*
       يستخدم في اضافة بند جديد في شاشة شهادة انجاز
       */
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public int? UnitId { get; set; } = 0;
        public long? ParentId { get; set; } = 0;


    }
    public class PmExtractTransactionsProductEditOnExtractDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; } = 0;
        public long? ProductId { get; set; } = 0;
        public string? Description { get; set; }
        
        public decimal? Price { get; set; } = 0;
   
        public decimal? Qty { get; set; } = 0;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; }
        public decimal? Total { get; set; } = 0;
        public decimal? Vat { get; set; } = 0;
        public int? BranchId { get; set; } = 0;
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }=false;
        public long? AccountId { get; set; } = 0;
        public long? PItemsId { get; set; } = 0;
        public decimal? QtyApprove { get; set; } = 0;
        public decimal? UnitPriceApprove { get; set; } = 0;
        public decimal? QtyPrevious { get; set; } = 0;
        public decimal? AmountPrevious { get; set; } = 0;
        public decimal? Rate { get; set; } = 0;
        public decimal? AmountRate { get; set; } = 0;
        public string? ItemCode { get; set; } 
        public string? ItemName { get; set; }
        public long? RevenueAccountId { get; set; } = 0;
        public long? ExpenseAccountId { get; set; }= 0;
        /*
     يستخدم في اضافة بند جديد في شاشة شهادة انجاز
     */
     
        public int? UnitId { get; set; } = 0;
        public long? ParentId { get; set; } = 0;

    }

    public class PmExtractTransactionsProductEditDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; } = 0;
        public long? ProductId { get; set; } = 0;
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; } = 0;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscRate { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Total { get; set; } = 0;
        [Column("VAT", TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; } = 0;
        public int? BranchId { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }= false;
        public long? AccountId { get; set; } = 0;
        public long? PItemsId { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? QtyApprove { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? UnitPriceApprove { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? QtyPrevious { get; set; } = 0;
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? AmountPrevious { get; set; } = 0;
        [Column(TypeName = "decimal(18, 8)")]
        public decimal? Rate { get; set; } = 0;
        [Column(TypeName = "decimal(18, 8)")]
        public decimal? AmountRate { get; set; } = 0;
        /*
         يستخدم عند  في عرض عند تعديل  مستخلص 
         */
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
    }
}
