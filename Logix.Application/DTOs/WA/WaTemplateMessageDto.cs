
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.WA
{
    public class WaTemplateMessageDto
    {
       
        public long Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    } 
}
