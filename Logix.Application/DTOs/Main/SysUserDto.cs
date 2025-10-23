using System.ComponentModel.DataAnnotations;


namespace Logix.Application.DTOs.Main
{
    public class SysUserfilterDto
    {

        
        public long? BranchId { get; set; }
        
        public int? Enable { get; set; }

        

        public string? GroupsId { get; set; }
        [StringLength(50)]
        public string? UserFullname { get; set; }
        
        public string? EmpCode { get; set; }
    }

    public class SysUserDto
    {
        public long Id { get; set; }
        
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string? StringUserPassword { get; set; } //password insert by user

        

        public byte[]? UserPassword { get; set; } //encrypt password

        [StringLength(50)]
        public string? UserFullname { get; set; }

        [StringLength(50)]
        
        [Required]
        public string? Email { get; set; }
        public long? UserPkId { get; set; }
        
        public int? UserTypeId { get; set; }
        public int? UserType2Id { get; set; }
        [StringLength(2500)]
        
        [Range(1, long.MaxValue)]
        public string? GroupsId { get; set; }
        
        public string? BranchsId { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? EmpName2 { get; set; }
        
        public int? EmpId { get; set; }
        [Range(1, long.MaxValue)]
        
        public long? FacilityId { get; set; }
        public long? CusId { get; set; }
        public int? SalesType { get; set; }
        public string? ProjectsId { get; set; }
        public string? AccTransfer { get; set; }
        public bool? Isupdate { get; set; }
        
        public int? Enable { get; set; }
        public bool? Isdel { get; set; }
        public bool? IsDeleted { get; set; }

        public long? SupId { get; set; }
        public long? CreatedBy { get; set; }
        public long? CandId { get; set; }
        public long? CurrLang { get; set; }
        public string? LastLogin { get; set; }
        public string? CalendarType { get; set; }
        public bool? TwoFactor { get; set; }
    }

    public class SysUserEditDto
    {
        public long Id { get; set; }
        
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string? StringUserPassword { get; set; } //password insert by user

        

        //public byte[]? UserPassword { get; set; } //encrypt password

        [StringLength(50)]
        public string? UserFullname { get; set; }

        [StringLength(50)]
        
        [Required]
        public string? Email { get; set; }
        public long? UserPkId { get; set; }
        
        public int? UserTypeId { get; set; }
        public int? UserType2Id { get; set; }
        [StringLength(2500)]
        
        [Range(1, long.MaxValue)]
        public string? GroupsId { get; set; }
        
        public string? BranchsId { get; set; }
        public string? EmpCode { get; set; }

        
        public int? EmpId { get; set; }
        [Range(1, long.MaxValue)]
        
        public long? FacilityId { get; set; }
        public long? CusId { get; set; }
        public int? SalesType { get; set; }
        public string? ProjectsId { get; set; }
        public string? AccTransfer { get; set; }
        public bool? Isupdate { get; set; }
        
        public int? Enable { get; set; }

        public long? SupId { get; set; }
        public long? CandId { get; set; }
        public long? ModifiedBy { get; set; }
        public string? DashboardWidget { get; set; }
        public string? Ips { get; set; }
        public TimeSpan? TimeFrom { get; set; }
        public TimeSpan? TimeTo { get; set; }

        public string? PermissionsOverUserId { get; set; }

        public string? PermissionsOverCustomerGroupsId { get; set; }

        //for check when edit user
        public int? PreviousEnable { get; set; }
        public int? PreviousUserType2Id { get; set; }

    }

    public class SysUserFilterDto
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        [StringLength(50)]
        public string? UserFullname { get; set; }
        public int? Enable { get; set; }
        public string? GroupsId { get; set; }
        public string? EmpCode { get; set; }
        public long? FacilityId { get; set; }
        public int? UserTypeId { get; set; }
        public string? UserName { get; set; }

        //
        public string? UserEmail { get; set; }
        public string? BraName { get; set; }
        public string? BraName2 { get; set; }
        public bool EnableChkbx { get; set; }
        public string? GroupName { get; set; }
        public string? lastLogin { get; set; }
        // use in two factor
        public string? Mobile { get; set; }
        public bool? IsChecked { get; set; } = false;
    }

    public class SysUserLoginTimeDto
    {
        public long Id { get; set; }
        public string? Ips { get; set; }
        public string? TimeFrom { get; set; }/* = default;*/
        public string? TimeTo { get; set; }

        //for display
        public string? UserName { get; set; }
        public string? EmpCode { get; set; }
    }

    public class UserNameAndEmpCodeDto
    {
        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? EmpCode { get; set; }
    }
    public class UserIdNameDto
    {
        public long? UserId { get; set; }
        public string? UserName { get; set; }
    }

    public class SysPropertyVM
    {
        public long PermissionId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public string? PropertyName { get; set; }
        public bool? Allow { get; set; }
        public string? Value { get; set; }
    }

    public class PackageVM
    {
        public string? Proprty { get; set; }
        public long Quantity { get; set; }
        public long Used { get; set; }
    }

    public class CreateUserRequstDto
    {

        public string UserName { get; set; } = null!;
        //password insert by user
        public string? StringUserPassword { get; set; }
        //  "خطاب مباشرة العمل"
        public string FileUrl { get; set; } = null!;
        public string? IdNo { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? BirthDate { get; set; }
        public bool? CheckApprove { get; set; }
        public int? AppTypeId { get; set; }

    }
    public class GetDataForCreateUserRequstDto
    {
        public string IdNo { get; set; } = null!;
        public string BirthDate { get; set; } = null!;

    }
    public class SysUserchangepasswordDto
    {
        public string? UserName { get; set; }
        public string? EmpName { get; set; }
        public string? Email { get; set; }
        public bool? TwoFactor { get; set; }
        public int? TwoFactorType { get; set; }
        public bool ChecKFactorType { get; set; }
        public bool TrOtp2 { get; set; }
        public bool? TowfactorVisible { get; set; }
        public int RadioTypeOtp { get; set; }
    }
    public class UserCountResult
    {
        public long UserCount { get; set; }
    }

    public class SysUserchangepasswordAddDto
    {

        
        [Required]
        public string? UserName { get; set; } = null!;



        
        public string? UserPassword { get; set; } // Encrypted password

        [StringLength(50)]
        public string? UserFullname { get; set; }

        [StringLength(50)]
        
        [Required]
        public string? Email { get; set; }
        public string? NewPassword { get; set; } // Add this property for new password
        public string? ConfirmPassword { get; set; } // Add this property for new password
    }
    public class SysUserchangepasswordVerificationDto
    {
        public bool ChecKFactorType { get; set; }
        public int RadioTypeOtp { get; set; }

        public bool DIVOtpCodeContainer { get; set; }

    }
    public class LdapLoginRequest
    {
        public string? Ldap { get; set; }
        public string ActiveUserName { get; set; } = null!;
        public string userName { get; set; } = null!;
        public string pass { get; set; } = null!;
    }
    public class LdapLoginResult
    {
        public bool IsValidUser { get; set; }
        public string? empName { get; set; }
        public string? Email { get; set; }
        public string? Exception { get; set; }
    }
    public class ActiveDirectoryUserAddDto
    {
        public string userName { get; set; }
        public string empName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int GroupId { get; set; }
    }

    public class SysUsersLoginsVm
    {
        // تقرير الدخول للمستخدمين
        // تقرير الصلاحيات للمستخدمين
        // this for filter
        public long? UserId { get; set; }
        public long? GroupId { get; set; }
        public string? EmpCode { get; set; } // Emp_ID
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        // this for display
        public string? EmpName { get; set; }
        public string? EmpName2 { get; set; }
        public string? UserName { get; set; }
        public string? IdNo { get; set; }
        public string? BraName { get; set; }
        public string? BraName2 { get; set; }
        public string? DepName { get; set; }
        public string? DepName2 { get; set; }
        public string? LocationName { get; set; }
        public string? LocationName2 { get; set; }
        public string? FirstLogin { get; set; }
        public string? LastLogin { get; set; }

        // this used in usersPermissions report
        public string? CreatedOn { get; set; }
        public string? ModifiedOn { get; set; }
        public string? NotEnableModifiedOn { get; set; }
    }
}