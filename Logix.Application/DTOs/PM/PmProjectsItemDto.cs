using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PMExtractItemDto
    {
        //  يستخدم  في  عرض  البند   في المستخلص  عند اختيار  بند 
        public long Id { get; set; }

        public string? ItemName { get; set; }
        public decimal? Price { get; set; } = 0;
        public string? UnitName { get; set; }
        public string? Note { get; set; }
        public decimal? Total { get; set; } = 0;
        public decimal? Qty { get; set; } = 0;
        public long? ProjectId { get; set; } = 0;

        public long? ItemId { get; set; } = 0;
        [StringLength(50)]
        public string? ItemCode { get; set; }

        public int? UnitId { get; set; } = 0;

        public decimal? QtyApprove { get; set; } = 0;
        public decimal? QtyPrevious { get; set; } = 0;
        public decimal? AmountPrevious { get; set; } = 0;
        public decimal? RateAll { get; set; } = 0;
        public decimal? SumAmount { get; set; } = 0;
        public decimal? PriceApprove { get; set; } = 0;
        public decimal? Rate { get; set; } = 0;
        public decimal? AmountRate { get; set; } = 0;
    }

    public class PMProjectsItemDto
    {
        public long Id { get; set; }

        public string? ItemName { get; set; }

        public long? ProjectId { get; set; } = 0;

        public long? ItemId { get; set; } = 0;
        [StringLength(50)]
        public string? ItemCode { get; set; }

        public int? UnitId { get; set; } = 0;

        [StringLength(50)]
        public string? UnitName { get; set; }
        public decimal? Qty { get; set; } = 0;
        public decimal? Price { get; set; } = 0;
        public decimal? Total { get; set; } = 0;
        public long? ParentId { get; set; } = 0;
        public string? Note { get; set; }
        public long? CatId { get; set; } = 0;
        public int? ItemTypeId { get; set; } = 0;
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }

        public decimal? PercentComplete { get; set; }
        public bool? Expanded { get; set; }

        public int? WbsActivity { get; set; }

        public long? LevelId { get; set; } = 0;

        public long? ItemsManagerId { get; set; } = 0;

        public long? ItemsManagerTypeId { get; set; } = 0;


        public decimal? VatRate { get; set; } = 0;

        public decimal? VatAmount { get; set; } = 0;
        public long? TreeOrderByShort { get; set; } = 0;

        public int? TreePartsId { get; set; } = 0;
        public decimal? CostPrice { get; set; } = 0;

        [StringLength(250)]
        public string? DeliveryDateT { get; set; }
        [StringLength(10)]
        public string? DeliveryDate { get; set; }
        public bool? IsDeleted { get; set; }

    }



    public class PMProjectsItemEditDto
    {
        public long Id { get; set; }

        public string? ItemName { get; set; }

        public long? ProjectId { get; set; } = 0;

        public long? ItemId { get; set; } = 0;
        [StringLength(50)]
        public string? ItemCode { get; set; }

        public int? UnitId { get; set; } = 0;

        [StringLength(50)]
        public string? UnitName { get; set; } = "";
        public decimal? Qty { get; set; } = 0;
        public decimal? Price { get; set; } = 0;
        public decimal? Total { get; set; } = 0;
        public long? ParentId { get; set; } = 0;
        public string? Note { get; set; } = "";


        public long? CatId { get; set; } = 0;
        public int? ItemTypeId { get; set; } = 0;
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }

        public decimal? PercentComplete { get; set; }
        public bool? Expanded { get; set; } = false;

        public int? WbsActivity { get; set; } = 0;

        public long? LevelId { get; set; } = 0;

        public long? ItemsManagerId { get; set; } = 0;

        public long? ItemsManagerTypeId { get; set; } = 0;


        public decimal? VatRate { get; set; } = 0;

        public decimal? VatAmount { get; set; } = 0;
        public long? TreeOrderByShort { get; set; } = 0;

        public int? TreePartsId { get; set; } = 0;
        public decimal? CostPrice { get; set; } = 0;

        [StringLength(250)]
        public string? DeliveryDateT { get; set; }
        [StringLength(10)]
        public string? DeliveryDate { get; set; }
    }


    //PmCostControl ------ use just to contian data not in database 
    public class PmCostControlAddVM
    {
        public long? ProjectCode { get; set; }
        public bool? CheckUpdateProject { get; set; } = false;
        public List<PmCostControlItemVM> PmCostControlItemVMs { get; set; } = new List<PmCostControlItemVM>();

    }
    public class PmCostControlItemVM
    {
        public long Id { get; set; } = 0;
        public decimal? Qty { get; set; }
        public decimal? CostPrice { get; set; }

    }

    public class UpdateProjectItemsCatagoryDto
    {
        public List<long> ItemsIds { get; set; }

        public long CatId { get; set; }

    }

}
