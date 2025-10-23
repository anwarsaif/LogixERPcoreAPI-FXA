
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.FXA
{
    public class AssetsDeprecAddDto
    {
        //this view model use in assets depreciation to add new depreciation.
        public AssetsForDeprecFilter DeprecFilter { get; set; }
        public List<AssetsForDeprecVm> AssetList { get; set; }

        public AssetsDeprecAddDto()
        {
            DeprecFilter = new AssetsForDeprecFilter();
            AssetList = new List<AssetsForDeprecVm>();
        }
    }

    public class AssetsDeprecAccountsAndCostCenters
    {
        //this class use in assets depreciation
        public long? AccountId2 { get; set; }
        public long? AccountId3 { get; set; }
        public long? CcId { get; set; }
        public long? CcId2 { get; set; }
        public long? CcId3 { get; set; }
        public long? CcId4 { get; set; }
        public long? CcId5 { get; set; }
        public long FxId { get; set; }
        public decimal Value { get; set; } = 0;
    }

    public class AssetsDeprecEditDto
    {
        public long? Id { get; set; } //transaction Id
        public string? Code { get; set; }
        public string? TransDate { get; set; }
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }

        public List<AssetsForDeprecEditVm> AssetList { get; set; }

        public AssetsDeprecEditDto()
        {
            AssetList = new List<AssetsForDeprecEditVm>();
        }
    }
}