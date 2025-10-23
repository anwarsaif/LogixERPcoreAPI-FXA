using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PMProjectsInstallmentDto
    {
        public long Id { get; set; }
        public long? Code { get; set; } = 0;

        public long? ProjectId { get; set; } = 0;
        [StringLength(50)]
        public string? No { get; set; }
        [StringLength(10)]
        public string? Date { get; set; }
        public decimal? Raet { get; set; } = 0;

        public decimal? Amount { get; set; } = 0;
        public string? Note { get; set; }


        public long? InvId { get; set; } = 0;
        [StringLength(10)]
        public string? DateH { get; set; }

        public decimal? VatRate { get; set; } = 0;
        public decimal? VatAmount { get; set; } = 0;
        [StringLength(250)]
        public string? Name { get; set; }
        [StringLength(10)]
        public string? PlannedDatePayment { get; set; }

        public int? StatusId { get; set; } = 0;

        public bool? Ispaid { get; set; }= false;

        public DateTime? LastUpdate { get; set; }
        public string? LastAction { get; set; }
    }
    
    public class PmProjectsInstallmentEditDto
    {
        public long Id { get; set; }
        public long? Code { get; set; } = 0;

        public long? ProjectId { get; set; } = 0;
        [StringLength(50)]
        public string? No { get; set; }
        [StringLength(10)]
        public string? Date { get; set; }
        public decimal? Raet { get; set; } = 0;

        public decimal? Amount { get; set; } = 0;
        public string? Note { get; set; }


        public long? InvId { get; set; } = 0;
        [StringLength(10)]
        public string? DateH { get; set; }

        public decimal? VatRate { get; set; } = 0;
        public decimal? VatAmount { get; set; } = 0;
        [StringLength(250)]
        public string? Name { get; set; }
        [StringLength(10)]
        public string? PlannedDatePayment { get; set; }

        public int? StatusId { get; set; } = 0;

        public bool? Ispaid { get; set; } = false;

        public DateTime? LastUpdate { get; set; }
        public string? LastAction { get; set; }
    }
}
