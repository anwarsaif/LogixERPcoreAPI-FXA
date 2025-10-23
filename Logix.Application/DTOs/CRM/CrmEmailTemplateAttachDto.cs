using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.CRM
{
    public class CrmEmailTemplateAttachDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? FileUrl { get; set; }
        public long? TemplateId { get; set; }
        //public long CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; } = false;
    }

    public class CrmEmailTemplateAttachEditDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? FileUrl { get; set; }
        public long? TemplateId { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }
}
