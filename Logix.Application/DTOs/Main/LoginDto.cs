using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public long FacilityId { get; set; }
        public int Language { get; set; } = 1;
        public bool RememberMe { get; set; } = false;
    } 
    public class LoginWithAuthenticationCodeDto
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public long FacilityId { get; set; }
        public int Language { get; set; } = 1;
        public bool RememberMe { get; set; } = false;
        [Required]
        public string? Code { get; set; } 
    }

    public class LoginResendCodeDto
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public long FacilityId { get; set; }
        public int Language { get; set; } = 1;

    }
    public class AzureCodeDto
    {
        public string Code { get; set; }
        public long FacilityId { get; set; }
        public int LanguageId { get; set; }
    }


}
