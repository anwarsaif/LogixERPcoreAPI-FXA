using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfApplicationsCommentDto
    {
        public long Id { get; set; }

        public long? ApplicationsId { get; set; }

        public long? ApplicantsId { get; set; }

        public int? AppStatusId { get; set; }

        public int? StepId { get; set; }

        public string? Comment { get; set; }

        public bool? IsDeleted { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }

    public class WfApplicationsCommentEditDto
    {
        public long Id { get; set; }

        public long? ApplicationsId { get; set; }

        public long? ApplicantsId { get; set; }

        public int? AppStatusId { get; set; }

        public int? StepId { get; set; }

        public string? Comment { get; set; }
    }
}