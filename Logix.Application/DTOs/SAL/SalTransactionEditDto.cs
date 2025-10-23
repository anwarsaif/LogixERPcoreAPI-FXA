
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.SAL
{
    public class SalTransactionEditDto
    {
        public long Id { get; set; }
    
        [StringLength(50)]
        public string? Code { get; set; }
        
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
       
        public long? CustomerId { get; set; }


        [StringLength(250)]
        [Required]
        public string? CustomerCode { get; set; }
        [StringLength(2500)]
        [Required]
        public string? CustomerName { get; set; }

        public long? RecipientId { get; set; }
        [StringLength(2500)]
        public string? RecipientName { get; set; }
        [StringLength(2500)]
        public string? Address { get; set; }
        
        [StringLength(50)]
        public string? PoNumber { get; set; }
        [StringLength(10)]
        [Required]
        public string? Date1 { get; set; }
        [StringLength(10)]
        public string? Date2 { get; set; }
        
        [StringLength(10)]
        public string? DeliveryDate { get; set; }
        [Required]
        [StringLength(10)]
        public string? ExpirationDate { get; set; }
        
        [StringLength(10)]
        [Required]
        public string? DueDate { get; set; }
        [Required]
        public int? PaymentTermsId { get; set; }
        public string? DocumentNote { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Subtotal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountRate { get; set; }
        [Column( TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }
        public string? DeliveryContact { get; set; }
        
        public string? DeliveryAddress { get; set; }
        
        public long? ProjectId { get; set; }
        
        public string? PrivateNote { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// رقم المرجع لعرض الاسعار او اوامر البيع
        /// </summary>
       
        public long? RefranceId { get; set; }
        
        public long? ContractId { get; set; }
       
        [StringLength(50)]
        public string? InvoiceMonth { get; set; }
        
        public int? ServiceRender { get; set; }
        
        public long? EmpId { get; set; }

        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? PaymentTerms { get; set; }
        [Required]
        public string? DeliveryTerm { get; set; }
        public int? InventoryId { get; set; }
        
        public long? EmpId2 { get; set; }
        [StringLength(500)]
        public string? Waybill { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        [Range(1, long.MaxValue)]
        public int? CurrencyId { get; set; }
        [Column(TypeName = "decimal(18, 10)")]
        public decimal? ExchangeRate { get; set; }
        
        public long? PosId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountPaid { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountRemaining { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Points { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? VatAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountCost { get; set; }
        public int? DuePeriodDays { get; set; }
        public int? SafetyPeriodDays { get; set; }
        
        [StringLength(10)]
        public string? SafetyDate { get; set; }
        
        public long? AppId { get; set; }
        
        public long? CcId { get; set; }
        
        public int? ReturnType { get; set; }
        
        public long? ReturnAccountId { get; set; }
        
        public bool? HasReservation { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CashAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BankAmount { get; set; }
        public long? AccAccountCash { get; set; }
        public long? AccAccountBank { get; set; }
        public int? SysAppTypeId { get; set; }
        public bool? Isposted { get; set; }
        
        [StringLength(50)]
        public string? QuotationIncludes { get; set; }
        public int? DocTypeId { get; set; }
        public long PeriodId { get; set; }
        public string? JID { get; set; }
        public long? CustomerType { get; set; }
        public int? TransTypeId { get; set; }

        [StringLength(100)]
        public string? Title { get; set; }
        [StringLength(2500)]
        public string? Notes { get; set; }
        public string? ConditionsAddition { get; set; }
        public string? ConditionsAddition2 { get; set; }
    }
}
