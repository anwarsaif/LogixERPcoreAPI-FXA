
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.FXA
{
    public class AssetsForDeprecFilter
    {
        //this filter use in assets depreciation to search the assets we need to deprecate.
        [Range(1, long.MaxValue)]
        public long? PeriodId { get; set; }
        public string? JCode { get; set; }
        public long? JId { get; set; }
        public string? Code { get; set; }
        [Required]
        [StringLength(10)]
        public string? TransDate { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [Required]
        [StringLength(10)]
        public string? EndDate { get; set; }
        public long? TypeId { get; set; } //asset type
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
        [Range(1, long.MaxValue)]
        public int? PeriodTypeId { get; set; } //monthly or daily
    }
}