using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Domain.FXA;

[Table("FXA_Transactions")]
public partial class FxaTransaction
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    public long? No { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column("Trans_Type_ID")]
    public int? TransTypeId { get; set; }

    [Column("Facility_ID")]
    public long? FacilityId { get; set; }

    [Column("Branch_ID")]
    public int? BranchId { get; set; }

    [Column("Trans_Date")]
    [StringLength(10)]
    public string? TransDate { get; set; }

    [Column("Start_Date")]
    [StringLength(10)]
    public string? StartDate { get; set; }

    [Column("End_Date")]
    [StringLength(10)]
    public string? EndDate { get; set; }

    [Column("Status_ID")]
    public int? StatusId { get; set; }

    [Column("Payment_Terms_ID")]
    public int? PaymentTermsId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Subtotal { get; set; }

    [Column("Discount_Rate", TypeName = "decimal(18, 2)")]
    public decimal? DiscountRate { get; set; }

    [Column("Discount_Amount", TypeName = "decimal(18, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column("VAT", TypeName = "decimal(18, 2)")]
    public decimal? Vat { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    [Column("Purchase_Order")]
    [StringLength(50)]
    public string? PurchaseOrder { get; set; }

    [Column("Purchase_Date")]
    [StringLength(10)]
    public string? PurchaseDate { get; set; }

    [Column("Account_ID")]
    public long? AccountId { get; set; }

    [Column("Supplier_ID")]
    public long? SupplierId { get; set; }

    [Column("Ref_Number")]
    [StringLength(250)]
    public string? RefNumber { get; set; }

    [Column("VAT_Amount", TypeName = "decimal(18, 2)")]
    public decimal? VatAmount { get; set; }

    [Column("Location_ID")]
    public long? LocationId { get; set; }

    [Column("CC_ID")]
    public long? CcId { get; set; }

    [Column("CC_ID2")]
    public long? CcId2 { get; set; }

    [Column("CC_ID3")]
    public long? CcId3 { get; set; }

    [Column("CC_ID4")]
    public long? CcId4 { get; set; }

    [Column("CC_ID5")]
    public long? CcId5 { get; set; }

    public string? Note { get; set; }

    [Column("Create_New_ID")]
    public bool? CreateNewId { get; set; }

    [Column("Account_ID2")]
    public long? AccountId2 { get; set; }
}
