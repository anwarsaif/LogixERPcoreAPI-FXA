using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysSmsDto
    {
        public long Id { get; set; }
        public string? ReceiverMobile { get; set; }
        public string? Message { get; set; }
        public long? FacilityId { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }
}
