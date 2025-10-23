using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysResetPasswordDto
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? DDate { get; set; }
        public bool? IsUpdate { get; set; }
        public string? Email { get; set; }
        public bool? IsDeleted { get; set; }
        public byte VerificationType { get; set; }
        public string? MobileNumber { get; set; }
        public string VerificationCode { get; set; } = null!;
        public DateTime ExpiryTime { get; set; }

    }
    public class SysResetPasswordEditDto
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? DDate { get; set; }
        public bool? IsUpdate { get; set; }
        public string? Email { get; set; }
        public byte VerificationType { get; set; }
        public string? MobileNumber { get; set; }
        public string VerificationCode { get; set; } = null!;
        public DateTime ExpiryTime { get; set; }
    }
    public class ResetPasswordByEmail
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public int? Language { get; set; }
    }
    public class ResetPasswordResultDto
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? CodeContent { get; set; }
        public int? Language { get; set; }
        public string? VerificationCode { get; set; }
        public byte VerificationType { get; set; }
        public string? MobileNumber { get; set; }
        public DateTime ExpiryTime { get; set; }

    }
    public class ResetPasswordByMobile
    {
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public int? Language { get; set; }
    }
    public class ValidateVerificationCodeDto
    {
        public int? Language { get; set; }

        public string UserName { get; set; } = null!;
        public string VerificationCode { get; set; } = null!;
        public int VerificationType { get; set; }
    }

    public class ResetPasswordDto
    {
        public string passWord { get; set; } = null!;
        public string VerificationCode { get; set; } = null!;
        public int? Language { get; set; }
        public string UserName { get; set; } = null!;

    }
}
