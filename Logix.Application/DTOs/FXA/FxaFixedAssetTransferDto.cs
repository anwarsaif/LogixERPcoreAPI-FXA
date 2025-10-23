using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logix.Application.DTOs.FXA
{
    public class FxaFixedAssetTransferFilterDto
    {
        [StringLength(10)]
        public string? StartDate { get; set; }
        [StringLength(10)]
        public string? EndDate { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? FromEmpCode { get; set; }
        public string? ToEmpCode { get; set; }
        public long? FromLocationId { get; set; }
        public long? ToLocationId { get; set; }
        public long? FxaFixedAssetId { get; set; }
    }
    
    public class FxaFixedAssetTransferDto
    {
        public long Id { get; set; }
        [Required]
        public long? FxaFixedAssetNo { get; set; }
        [Range(1, long.MaxValue)]
        public int? FromBranchId { get; set; }
        [Range(1, long.MaxValue)]
        public long? FromFacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? ToBranchId { get; set; }
        [Range(1, long.MaxValue)]
        public long? ToFacilityId { get; set; }
        [Required]
        [StringLength(10)]
        public string? DateTransfer { get; set; }
        public string? Note { get; set; }
        public bool IsDeleted { get; set; }

        public string? FromCcCode { get; set; }
        public string? ToCcCode { get; set; }

        public string? FromEmpCode { get; set; }
        public string? ToEmpCode { get; set; }

        public long? FromLocationId { get; set; }
        public long? ToLocationId { get; set; }
    }

    public class FxaFixedAssetTransferEditDto
    {
        public long Id { get; set; }
        //public long? FxaFixedAssetId { get; set; }
        [Required]
        public long? FxaFixedAssetNo { get; set; }
        public string? FxaFixedAssetName { get; set; }
        [Required]
        [StringLength(10)]
        public string? DateTransfer { get; set; }
        [Range(1, long.MaxValue)]
        public long? FromFacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? FromBranchId { get; set; }

        public string? FromCcCode { get; set; }
        public string? FromCcName { get; set; }
        [Range(1, long.MaxValue)]
        public long? ToFacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? ToBranchId { get; set; }
        public string? ToCcCode { get; set; }
        public string? ToCcName { get; set; }
        public string? FromEmpCode { get; set; }
        public string? FromEmpName { get; set; }
        public long? FromLocationId { get; set; }
        public string? ToEmpCode { get; set; }
        public string? ToEmpName { get; set; }
        public long? ToLocationId { get; set; }
        public string? Note { get; set; }
    }

    //this dto used when transfer list of assets from an employee to another employee
    public class FxaFixedAssetTransferDto2
    {
        public long Id { get; set; }
        
        [Range(1, long.MaxValue)]
        public int? FromBranchId { get; set; }
        [Range(1, long.MaxValue)]
        public long? FromFacilityId { get; set; }
        [Range(1, long.MaxValue)]
        public int? ToBranchId { get; set; }
        [Range(1, long.MaxValue)]
        public long? ToFacilityId { get; set; }
        [Required]
        [StringLength(10)]
        public string? DateTransfer { get; set; }
        public string? Note { get; set; }

        public bool IsDeleted { get; set; }

        public string? FromCcCode { get; set; }
        public string? ToCcCode { get; set; }

        public string? FromEmpCode { get; set; }
        public string? ToEmpCode { get; set; }

        public long? FromLocationId { get; set; }
        public long? ToLocationId { get; set; }

        //ids of all assets that will be transfer (1,2,3,...)
        public string? FxaFixedAssetIds { get; set; }
    }
}