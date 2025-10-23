using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfStepsCommitteeDto
    {
        public long Id { get; set; }
        public long? CommitteeId { get; set; }
        public long? AppId { get; set; }
        public long? StepId { get; set; }
        public long? AppTypeId { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
