using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysZatcaSignedXmlSimulationDto
    {
        public long Id { get; set; }
        public long InvoiceId { get; set; }
        [StringLength(10)]
        public string InvoiceAccordingTypeId { get; set; } = null!;
        public string SignedXml { get; set; } = null!;
        public long FacilityId { get; set; }
        public int? BranchId { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
