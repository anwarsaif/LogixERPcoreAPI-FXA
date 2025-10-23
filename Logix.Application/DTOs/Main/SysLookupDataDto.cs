using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysLookupDataDto
    {
        public long Id { get; set; }
        public long? Code { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string? Name2 { get; set; }
        [Range(1, long.MaxValue)]
        public int CatagoriesId { get; set; }
        // 
        [Range(1, long.MaxValue)]
        public int? SystemId { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public string? CostCenterCode { get; set; }
        public string? CostCenterName { get; set; }
        //

        public bool Isdel { get; set; } = false;

        public long? UserId { get; set; }

        public int? SortNo { get; set; }
        public string? Note { get; set; }

        [StringLength(250)]
        public string? RefranceNo { get; set; }

        public int? ColorId { get; set; }

        public string? Icon { get; set; }

        public long? AccAccountId { get; set; }

        public long? CcId { get; set; }

    }

    public class SysLookupDataFilterDto
    {
        public int? CatagoriesId { get; set; }
        public string? SystemId { get; set; }
        public string? Name { get; set; }
    }
}
