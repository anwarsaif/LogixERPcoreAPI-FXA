using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{
    [Keyless]
    public class SysVatGroupVwDto
    {

        public long VatId { get; set; }

        [StringLength(10)]
        public string? VatName { get; set; }

        public decimal? VatRate { get; set; }

        public long? FacilityId { get; set; }
        public bool? IsDeleted { get; set; }

        public long? SalesVatAccountId { get; set; }

        [StringLength(50)]
        public string? SalesVatAccountCode { get; set; }

        [StringLength(255)]
        public string? SalesVatAccountName { get; set; }

        public long? PurchasesVatAccountId { get; set; }

        [StringLength(50)]
        public string? PurchasesVatAccountCode { get; set; }

        [StringLength(255)]
        public string? PurchasesVatAccountName { get; set; }
    }
}
