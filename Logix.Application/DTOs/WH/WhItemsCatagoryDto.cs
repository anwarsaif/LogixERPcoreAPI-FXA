using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
	public partial class WhItemsCatagoryDto
	{
		public long? CatId { get; set; }
		[StringLength(2500)]
		public string? CatName { get; set; }
		public long? ParentId { get; set; }
		[StringLength(2500)]
		public string? CatName2 { get; set; }
		[StringLength(50)]
		public string? CatCode { get; set; }
		public long? FacilityId { get; set; }
		public bool IsDeleted { get; set; }
		public string? RevenueAccounCode { get; set; }
		public string? ExpenseAccountCode { get; set; }
		public string? DiscountAccountCode { get; set; }
		public string? DiscountCreditAccountCode { get; set; }
		public string? SalesReturnsAccountCode { get; set; }
		public string? InventoryAccountCode { get; set; }
		public bool? PublishStore { get; set; }
	}

	public partial class WhItemsCatagoryEditDto
	{
		public long CatId { get; set; }
		[StringLength(2500)]
		public string? CatName { get; set; }
		public long? ParentId { get; set; }
		[StringLength(2500)]
		public string? CatName2 { get; set; }
		public long? FacilityId { get; set; }
		public string? RevenueAccountCode { get; set; }
		public long? RevenueAccountId { get; set; }
		public string? ExpenseAccountCode { get; set; }
		public long? ExpenseAccountId { get; set; }
		public string? DiscountAccountCode { get; set; }
		public long? DiscountAccountId { get; set; }
		public string? DiscountCreditAccountCode { get; set; }
		public long? DiscountCreditAccountId { get; set; }
		public string? SalesReturnsAccountCode { get; set; }
		public long? SalesReturnsAccountId { get; set; }
		public string? InventoryAccountCode { get; set; }
		public long? InventoryAccountId { get; set; }
		[StringLength(50)]
		public string? Color { get; set; }
		public bool? PublishStore { get; set; }
	}
	public partial class WhItemsCatagoryFilterDto
	{
		public long? CatId { get; set; }
		[StringLength(2500)]
		public string? CatName { get; set; }
		public long? FacilityId { get; set; }
		public bool? IsDeleted { get; set; }
	}
}
