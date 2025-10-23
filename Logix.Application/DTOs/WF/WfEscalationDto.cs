using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfEscalationDto
    {
        public long Id { get; set; }

        [StringLength(250)]
        public string? EscNo { get; set; }

        public int? AppId { get; set; }

        [StringLength(10)]
        public string? EscalationDate { get; set; }

        [StringLength(10)]
        public string? EscalationTime { get; set; }

        public int? StepId { get; set; }

        public int? StatusId { get; set; }

        public int? Type { get; set; }

        public string? Note { get; set; }

        public int? EscalationStatus { get; set; }

        public bool? IsDeleted { get; set; }
        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }
    
    public class WfEscalationEditDto
    {
        public long Id { get; set; }

        [StringLength(250)]
        public string? EscNo { get; set; }

        public int? AppId { get; set; }

        [StringLength(10)]
        public string? EscalationDate { get; set; }

        [StringLength(10)]
        public string? EscalationTime { get; set; }

        public int? StepId { get; set; }

        public int? StatusId { get; set; }

        public int? Type { get; set; }

        public string? Note { get; set; }

        public int? EscalationStatus { get; set; }
    }
}