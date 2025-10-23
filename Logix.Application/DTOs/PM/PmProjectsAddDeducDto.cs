using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsAddDeducDto
    {

        public long Id { get; set; }

        public long? ProjectId { get; set; } = 0;

        public int? TypeId { get; set; } = 0;
        public decimal? Debit { get; set; } = 0;
        public decimal? Credit { get; set; } = 0;
        public decimal? Percentage { get; set; } = 0;
        [StringLength(10)]
        public string? Tdate { get; set; }
        [StringLength(50)]
        public string? Note { get; set; }

    }
    
    
    public class PmProjectsAddDeducEditDto
    {
        public long Id { get; set; }

        public long? ProjectId { get; set; } = 0;

        public int? TypeId { get; set; } = 0;
        public decimal? Debit { get; set; } = 0;
        public decimal? Credit { get; set; } = 0;
        public decimal? Percentage { get; set; } = 0;
        [StringLength(10)]
        public string? Tdate { get; set; }
        [StringLength(50)]
        public string? Note { get; set; }
 
    }
}
