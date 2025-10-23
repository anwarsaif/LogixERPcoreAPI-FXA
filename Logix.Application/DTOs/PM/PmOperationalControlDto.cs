using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.PM
{
    public class PmOperationalControlDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public int? JobCatagoriesId { get; set; }
        public int? CountOfEmplyee { get; set; }
        public long? HrShitId { get; set; }
        public string? Note { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class PmOperationalControlEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public int? JobCatagoriesId { get; set; }
        public int? CountOfEmplyee { get; set; }
        public long? HrShitId { get; set; }
        public string? Note { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
