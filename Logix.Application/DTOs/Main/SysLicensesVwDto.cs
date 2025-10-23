using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{

    public class SysLicensesVwDto
    {

        public long Id { get; set; }

        public long? FacilityId { get; set; }
        public int? JobCat { get; set; }

        public int? LicenseType { get; set; }

        [StringLength(50)]
        public string? LicenseNo { get; set; }

        [StringLength(50)]
        public string? LicenseFormerPlace { get; set; }

        [StringLength(10)]
        public string? IssuedDate { get; set; }

        [StringLength(10)]
        public string? ExpiryDate { get; set; }
        public string? Note { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        [StringLength(500)]
        public string? FacilityName { get; set; }

        [StringLength(500)]
        public string? FacilityName2 { get; set; }

        [StringLength(250)]
        public string? LicenseTypeName { get; set; }

        [StringLength(10)]
        public string? RenewalDate { get; set; }

        [StringLength(250)]
        public string? FileUrl { get; set; }

        public int? BranchId { get; set; }

        public string? BraName { get; set; }

        [StringLength(753)]
        public string? TypeAndNameEn { get; set; }

        [StringLength(753)]
        public string? TypeAndName { get; set; }
    }
}
