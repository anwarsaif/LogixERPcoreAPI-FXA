using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfAppCommitteesMemberDto
    {
        public long Id { get; set; }
        public long? CommitteeId { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public bool IsBoss { get; set; }
        public int? MemberType { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
