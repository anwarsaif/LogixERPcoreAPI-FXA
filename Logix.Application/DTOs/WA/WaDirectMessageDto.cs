
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.WA
{
    public class WaDirectMessageDto
    {
       
        public long Id { get; set; }
        [Required]
        public string? RecipientPhoneNumber { get; set; }
        public string? Message { get; set; }
        public string? FileURl { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
