using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurItemsPriceDDto
    {
        public long Id { get; set; }
        public long? ItemPriceMId { get; set; }
        public long? ItemId { get; set; }
        [Required]
        public string? ItemCode { get; set; }
        public long? UnitId { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public decimal? MaxPrice { get; set; }
        [Required]
        public decimal? MinPrice { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PurItemsPriceDUpdateDto
    {
        public long Id { get; set; }
        //public long? ItemPriceMId { get; set; }
        //public long? ItemId { get; set; }
        //public long? UnitId { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public decimal? MaxPrice { get; set; }
        [Required]
        public decimal? MinPrice { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        //public bool? IsDeleted { get; set; }
    }
    public class PurItemsPriceDEditDto
    {
        public long Id { get; set; }
        public long? ItemPriceMId { get; set; }
        public long? ItemId { get; set; }
        [Required]
        public string? ItemCode { get; set; }
        public long? UnitId { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public decimal? MaxPrice { get; set; }
        [Required]
        public decimal? MinPrice { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class PurItemsPriceDUpdateListDto
    {
        public List<PurItemsPriceDUpdateDto> Details { get; set; }
    }

}
