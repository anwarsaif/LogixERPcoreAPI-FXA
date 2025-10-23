using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.FXA
{
    public class FxaTransactionFxaTransactionsAssetDto
    {
        //this dto contains columns of FxaTransaction and FxaTransactionsAsset,, use when add new asset.
        public long Id { get; set; }
        public long? No { get; set; }
        public string? Code { get; set; }
        public string? TransDate { get; set; }
        public decimal? Total { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public long? FacilityId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? AccountId { get; set; }
        public int? TransTypeId { get; set; }
        public long? TransactionId { get; set; }
        public long? FixedAssetId { get; set; }
        public decimal? Debet { get; set; }
        public decimal? Credit { get; set; }
        public string? Description { get; set; }
    }
}