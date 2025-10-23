
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.WA
{


    public partial class WaWhatsappSettingDto
    {
        public long Id { get; set; }
        [Required]
        public string? BusinessId { get; set; }
        [Required]
        public string? ApplicationId { get; set; }
        [Required]
        public string? PhoneNumberId { get; set; }
        
        public string? PhoneNumber { get; set; }
        [Required]
        public string? AccessToken { get; set; }
        [Required]
        public string? BaseUrl { get; set; }
        
        public string? WebhookUrl { get; set; }
     
        public string? WebhookVerifyToken { get; set; }
   
        public int? SystemId { get; set; }
     
        public long? ScreenId { get; set; }
  
        public long? FacilityId { get; set; }

        public string? Attribute1 { get; set; }
 
        public string? Attribute2 { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
