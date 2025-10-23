using Logix.Application.DTOs.SAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{

    public class PurDiscountCatalogDto
    {
        public long? Id { get; set; }
        public long? BranchId { get; set; }
        public long? FacilityId { get; set; }
        public string? Name { get; set; }
        public int? DiscountType { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public decimal? DiscountRate { get; set; }
        public long? ItemsPriceId { get; set; }
        public long? CustomerId { get; set; }
        public bool? IsDeleted { get; set; }
        public List<PurDiscountByAmountDto>? purDiscountByAmounts { get; set; }
        public List<PurDiscountByQtyDto>? purDiscountByQties { get; set; }
        public List<PurDiscountProductDto>? purDiscountProducts { get; set; }

    }
    public class PurDiscountCatalogEditDto
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public long? FacilityId { get; set; }
        public string? Name { get; set; }
        public int? DiscountType { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public decimal? DiscountRate { get; set; }
        public long? ItemsPriceId { get; set; }
        public long? CustomerId { get; set; }
        public List<PurDiscountByAmountDto>? purDiscountByAmounts { get; set; }
        public List<PurDiscountByQtyDto>? purDiscountByQties { get; set; }
        public List<PurDiscountProductDto>? purDiscountProducts { get; set; }
    }
    public class PurDiscountCatalogFilterDto
    {
        public long? BranchId { get; set; }
    }
}
