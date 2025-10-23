
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.WA
{
    public class WaTemplateMessageValueDto
    {
       
        public long Id { get; set; }
        [Required(ErrorMessage ="يجب ادخال نص قالب الرسالة")]
        public string? Message { get; set; }
        public string? Name { get; set; }
        [Required]
        public long? FacilityId { get; set; }
        [Required]
        public int? SystemId { get; set; }
        [Required]
        public long? ScreenId { get; set; }
      
        public long? WaTemplateMessageId { get; set; }
        public bool HasDocument { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
