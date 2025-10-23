using System.ComponentModel.DataAnnotations;
using Logix.Application.DTOs.Main;

namespace Logix.Application.DTOs.CRM
{
    public class CrmEmailTemplateFilterDto
    {
        public string? Name { get; set; }
    }

    public class CrmEmailTemplateDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Subject { get; set; }
        [StringLength(2500)]
        public string? SenderName { get; set; }
        [StringLength(2500)]
        public string? SenderEmail { get; set; }
        public string? Message { get; set; }
        [StringLength(250)]
        public string? TableName { get; set; }
        public bool IsDeleted { get; set; } = false;
        public List<SysFileDto>? Files { get; set; }
    }

    public class CrmEmailTemplateEditDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Subject { get; set; }
        [StringLength(2500)]
        public string? SenderName { get; set; }
        [StringLength(2500)]
        public string? SenderEmail { get; set; }
        public string? Message { get; set; }
        [StringLength(250)]
        public string? TableName { get; set; }
        public List<SysFileDto>? Files { get; set; }
    }
}
