using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.PM
{
    public class PmJobsSalaryDto
    {
        public long Id { get; set; }

        public long? ProjectId { get; set; }
        public int? ProgramId { get; set; }
        public int? JobCatagoriesId { get; set; }
        public decimal? Maxsalary { get; set; }
        public string? Note { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class PmJobsSalaryEditDto
    {
        public long Id { get; set; }

        public long? ProjectId { get; set; }
        public int? ProgramId { get; set; }
        public int? JobCatagoriesId { get; set; }
        public decimal? Maxsalary { get; set; }
        public string? Note { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
    }
}
