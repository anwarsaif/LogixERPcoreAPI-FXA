using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{

    public class PurTransactionsProductDto
    {
        public long? Id { get; set; }
        public long? TransactionId { get; set; }
        [Required]
        public string? ProductCode { get; set; }
        public long? ProductId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Price { get; set; }
        [Required]
        public decimal? Qty { get; set; }
        public decimal? DiscRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Total { get; set; }
        public decimal? Vat { get; set; }
        public int? BranchId { get; set; }
        public string? Desc { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AccountId { get; set; }
        public long? CcId { get; set; }
        public string? CostCenterCode { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? Equivalent { get; set; }
        public decimal? ExpensesAmount { get; set; }
        public long? BatchId { get; set; }
        public int? ReferenceTypeId { get; set; }
        /// <summary>
        /// رقم المرجع في نظام التقسيط
        /// </summary>
        public long? ReferenceNo { get; set; }
        public long? PurTId { get; set; }
        public long? PurPId { get; set; }
        public long? ActivityId { get; set; }
        public int? InventoryId { get; set; }
        public decimal? ExpensesAmount2 { get; set; }
    }
    public class PurTransactionsProductPODto
    {
        public long? Id { get; set; }
        public long? TransactionId { get; set; } // Maps to objpro.Transaction_ID
        public string? ProductCode { get; set; } // Optional: Add mapping if available
        public long? ProductId { get; set; } // Maps to objpro.Product_ID
        public int? UnitId { get; set; } // Maps to objpro.Unit_ID
        public decimal? Price { get; set; } // Maps to objpro.Price
        public string? Desc { get; set; } // Maps to objpro.Desc
        public decimal? Qty { get; set; } // Maps to objpro.Qty
        public decimal? DiscRate { get; set; } // Maps to objpro.Disc_rate
        public decimal? DiscountAmount { get; set; } // Maps to objpro.Discount_Amount
        public decimal? Total { get; set; } // Maps to objpro.Total
        public decimal? Vat { get; set; } // Maps to objpro.VAT
        public decimal? VatAmount { get; set; } // Maps to objpro.VAT_Amount
        public int? BranchId { get; set; } // Maps to objpro.Branch_ID
        public int? CurrencyId { get; set; } // Maps to objpro.Currency_ID
        public decimal? ExchangeRate { get; set; } // Maps to objpro.Exchange_Rate
        public long? PurTId { get; set; } // Maps to objpro.Pur_T_ID
        public long? PurPId { get; set; } // Maps to objpro.Pur_P_ID
        public long? CcId { get; set; } // Maps to objpro.CC_ID
        public int? InventoryId { get; set; } // Maps to objpro.Inventory_ID
        public bool? IsDeleted { get; set; }
    }
    public class PurTransactionsProductBillDto
    {
        public long? Id { get; set; }
        public long? TransactionId { get; set; }
        [Required]
        public string? ProductCode { get; set; }
        public long? ProductId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Price { get; set; }
        [Required]
        public decimal? Qty { get; set; }
        public decimal? DiscRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Total { get; set; }
        public decimal? Vat { get; set; }
        public int? BranchId { get; set; }
        public string? Desc { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AccountId { get; set; }
        public long? CcId { get; set; }
        public string? CostCenterCode { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? Equivalent { get; set; }
        public decimal? ExpensesAmount { get; set; }
        public long? BatchId { get; set; }
        public int? ReferenceTypeId { get; set; }
        /// <summary>
        /// رقم المرجع في نظام التقسيط
        /// </summary>
        public long? ReferenceNo { get; set; }
        public long? PurTId { get; set; }
        public long? PurPId { get; set; }
        public long? ActivityId { get; set; }
        public int? InventoryId { get; set; }
        public decimal? ExpensesAmount2 { get; set; }
    }

    public class PurTransactionsProductEditDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public long? ProductId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Qty { get; set; }
        public decimal? DiscRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Total { get; set; }
        public decimal? Vat { get; set; }
        public int? BranchId { get; set; }
        public string? Desc { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AccountId { get; set; }
        public long? CcId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? Equivalent { get; set; }
        public decimal? ExpensesAmount { get; set; }
        public long? BatchId { get; set; }
        public int? ReferenceTypeId { get; set; }
        /// <summary>
        /// رقم المرجع في نظام التقسيط
        /// </summary>
        public long? ReferenceNo { get; set; }
        public long? PurTId { get; set; }
        public long? PurPId { get; set; }
        public long? ActivityId { get; set; }
        public int? InventoryId { get; set; }
        public decimal? ExpensesAmount2 { get; set; }
    }
}
