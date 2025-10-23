using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.FXA
{
    public class AssetsForDeprecVm
    {
        //this view model use in assets depreciation to return the data of assets we need to deprecate.
        public long Id { get; set; }
        public long? No { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(4000)]
        public string? Name { get; set; }

        public long? AccountId { get; set; }
        public long? Account2Id { get; set; }

        public long? Account3Id { get; set; }
        [StringLength(255)]
        public string? AccAccountName { get; set; }
        [StringLength(255)]
        public string? AccAccountName2 { get; set; }
        [StringLength(255)]
        public string? AccAccountName3 { get; set; }

        [StringLength(150)]
        public string? CostCenterName { get; set; }
        public long? CcId { get; set; }
        public long? CcId2 { get; set; }
        public long? CcId3 { get; set; }
        public long? CcId4 { get; set; }
        public long? CcId5 { get; set; }

        public decimal? Amount { get; set; }
        public decimal? InitialBalance { get; set; }

        public decimal? Balance { get; set; } //fill from FXA_Transactions_Assest FixedAsset_ID=FXA_FixedAsset_VW.ID and IsDeleted=0
        public string? LastDeprecDate { get; set; } //fill from FXA_Transactions_Assest

        public int? DeprecMethod { get; set; }
        public decimal? InstallmentValue { get; set; } //based on Deprec_Method
        public decimal? DeprecMonthlyRate { get; set; }
        public decimal? ScrapValue { get; set; }

        //addition properties
        public int CntMonth { get; set; } = 0;
        public decimal DeprecValue { get; set; } = 0;

        public int CntDays { get; set; } = 0;
        public decimal DeprecValueDialy { get; set; } = 0;

        public bool IsSelected { get; set; } = false;
    }
}