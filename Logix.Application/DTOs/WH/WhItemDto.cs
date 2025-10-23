using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
    public class WhItemDto
    {
        public long? Id { get; set; }
        /// <summary>
        /// 1 products 2 services
        /// </summary>
        public int? ItemType { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? ItemName2 { get; set; }
        public long? CatId { get; set; }
        public int? StatusId { get; set; }
        public string? CustomerCode { get; set; }
        public string? BarCode { get; set; }
        public string? ImgItem { get; set; }
        public string? AllowOver { get; set; }
        public string? AllowDown { get; set; }
        public decimal? PriceSale { get; set; }
        public int? UnitItemId { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? AllowOverDiscount { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int? ValuationCosting { get; set; }
        public bool? AuthorizeNegativeStock { get; set; }
        public long? AccountId { get; set; }
        public long? FacilityId { get; set; }
        public long? CcId { get; set; }
        public int? ManufactureCountry { get; set; }
        public string? ManufacturingYear { get; set; }
        public int? ExternalColor { get; set; }
        public int? EnternalColor { get; set; }
        public int? SeatsColor { get; set; }
        /// <summary>
        /// 1 products 2 services
        /// </summary>
        public int? ItemType2 { get; set; }
        public string? Note { get; set; }
        public bool? VatEnable { get; set; }
        public long? VatId { get; set; }
        public long? SupplierId { get; set; }
        public int? LevelItem { get; set; }
        public int? ParentId { get; set; }
        public string? ParentCode { get; set; }
        public decimal? Equivalent { get; set; }
        public bool? HasBatchNo { get; set; }
        public decimal? AvgUnitCost { get; set; }
        public bool? PriceIncludeVat { get; set; }
        public bool? HasSerialNo { get; set; }
        public bool? Isweighed { get; set; }
        public bool? PublishStore { get; set; }
        public long? VatResonId { get; set; }
        public string? Sku { get; set; }
        public long? CountryId { get; set; }
        public long? ManufacturerId { get; set; }
        public string? ItemModel { get; set; }
    }
    public class WhItemEditDto
    {
        public long Id { get; set; }
        /// <summary>
        /// 1 products 2 services
        /// </summary>
        public int? ItemType { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? ItemName2 { get; set; }
        public long? CatId { get; set; }
        public int? StatusId { get; set; }
        public string? CustomerCode { get; set; }
        public string? BarCode { get; set; }
        public string? ImgItem { get; set; }
        public string? AllowOver { get; set; }
        public string? AllowDown { get; set; }
        public decimal? PriceSale { get; set; }
        public int? UnitItemId { get; set; }
        public decimal? AllowOverDiscount { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int? ValuationCosting { get; set; }
        public bool? AuthorizeNegativeStock { get; set; }
        public long? AccountId { get; set; }
        public long? FacilityId { get; set; }
        public long? CcId { get; set; }
        public int? ManufactureCountry { get; set; }
        public string? ManufacturingYear { get; set; }
        public int? ExternalColor { get; set; }
        public int? EnternalColor { get; set; }
        public int? SeatsColor { get; set; }
        /// <summary>
        /// 1 products 2 services
        /// </summary>
        public int? ItemType2 { get; set; }
        public string? Note { get; set; }
        public bool? VatEnable { get; set; }
        public long? VatId { get; set; }
        public long? SupplierId { get; set; }
        public int? LevelItem { get; set; }
        public int? ParentId { get; set; }
        public string? ParentCode { get; set; }
        public decimal? Equivalent { get; set; }
        public bool? HasBatchNo { get; set; }
        public decimal? AvgUnitCost { get; set; }
        public bool? PriceIncludeVat { get; set; }
        public bool? HasSerialNo { get; set; }
        public bool? Isweighed { get; set; }
        public bool? PublishStore { get; set; }
        public long? VatResonId { get; set; }
        public string? Sku { get; set; }
        public long? CountryId { get; set; }
        public long? ManufacturerId { get; set; }
        public string? ItemModel { get; set; }
    }

	public class WhItemSearch
    {
		public string? ItemCode { get; set; }
		public string? ItemName { get; set; }
		public string? ItemName2 { get; set; }
		public int? UnitItemId { get; set; }
		public int? ItemType { get; set; }
		public long? CatId { get; set; }
		public int? StatusId { get; set; }
		public long? ManufacturerId { get; set; }
		public long? CountryId { get; set; }
		public string? Sku { get; set; }
		public string? ItemModel { get; set; }
		public long? FacilityId { get; set; }
	}
}
