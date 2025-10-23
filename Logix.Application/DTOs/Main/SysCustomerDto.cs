using Logix.Application.DTOs.Main;

using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysCustomerDto
    {

        public long? Id { get; set; }
        public int? CusTypeId { get; set; }
        public string? Code { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Name2 { get; set; }
        [Required]
        public string? IdNo { get; set; }
        public string? IdDate { get; set; }
        [Range(1, long.MaxValue)]
        public int? IdType { get; set; }
        public string? IdIssuer { get; set; }
        [Range(1, long.MaxValue)]
        public int? NationalityId { get; set; }
        public string? CustomerName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
        ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
        ErrorMessage = "Invalid email address")]
        public string? Email2 { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        //[Required]
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }
        public string? RepresentedBy { get; set; }
        public string? JobName { get; set; }
        public string? JobAddress { get; set; }

        public string? Photo { get; set; }
        public string? SponsorId { get; set; }
        public string? SponsorName { get; set; }
        public string? SponsorJobName { get; set; }
        public string? SponsorJobAddress { get; set; }
        public string? SponsorMobile { get; set; }
        public string? SponsorPhone { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",
        ErrorMessage = "Invalid email address")]
        public string? SponsorEmail { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
        public int? CityId { get; set; }
        public int? BankId { get; set; }
        public string? BankAccount { get; set; }

        public long? AccAccountId { get; set; }

        // =========== this for input only ==================
        public string? AccAccountCode { get; set; }
        public string? AccAccountName { get; set; }

        public bool AccSeparate { get; set; }

        public long? FacilityId { get; set; }
        [Required]
        public decimal CreditLimit { get; set; }
        [Range(1, long.MaxValue)]
        public int? GroupId { get; set; }
        public int? ComanyType { get; set; }
        [Range(1, long.MaxValue)]
        public int? CurrencyId { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public long? ItemPriceMId { get; set; }
        public int? SourceId { get; set; }

        public int? StatusId { get; set; }

        public string? ShareWithUsers { get; set; }
        [Range(1, long.MaxValue)]
        public int? IndustryId { get; set; }


        public string? NumberOfEmployees { get; set; }

        public bool VatEnable { get; set; }
        public string? VatNumber { get; set; }
        [Required]
        public int DuePeriodDays { get; set; }

        public string? CollectorName { get; set; }

        public string? CreatedDate { get; set; }

        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        [Required]
        public int SafetyPeriodDays { get; set; }

        [Range(1, long.MaxValue)]
        public int? Enable { get; set; }
        public int? PaymentType { get; set; }
        public int? SalesType { get; set; }
        public int? SalesArea { get; set; }
        public int? PosId { get; set; }
        public string? DaysOfVisit { get; set; }
        public int? Gender { get; set; }

        public string? RefranceCode { get; set; }

        public string? MemberId { get; set; }

        public string? FristName { get; set; }

        public string? SecondName { get; set; }

        public string? ThirdName { get; set; }

        public string? FourthName { get; set; }


        public int? TitleId { get; set; }


        public string? Veneration { get; set; }

        public string? ContactBy { get; set; }

        public string? DateOfBirth { get; set; }

        public long? ParentId { get; set; }

        public int? ParentRelativeType { get; set; }

        public int? StdStatusId { get; set; }

        public int? StdGradeId { get; set; }

        public long? AppId { get; set; }

        public string? UniversityId { get; set; }

        public string? IdExpireDate { get; set; }

        public string? OwnerIdNo { get; set; }

        public bool? FreeMaintenance { get; set; }

        public bool? PreventiveMaintenance { get; set; }

        public bool? CorrectionalMaintenance { get; set; }

        public long? JobId { get; set; }
        public string? Vission { get; set; }
        public string? Mission { get; set; }
        public string? Objective { get; set; }

        public int? IsbusinessPartner { get; set; }
        public string? AcademicDegree { get; set; }
        public int? RateFileCompletion { get; set; }

        public bool? Iscompleted { get; set; }

        public string? AttachmentIbn { get; set; }

        public string? AttachmentProfile { get; set; }

        public string? CountEmployeePrimary { get; set; }

        public string? CountEmployeeForeign { get; set; }

        public string? AttachmentOrganizationalchart { get; set; }
        public string? OtherDetails { get; set; }

        public string? SponsorPobox { get; set; }

        public string? SponsorZipCode { get; set; }

        public string? SponsorAttachment { get; set; }

        public string? Pobox { get; set; }

        public string? ZipCode { get; set; }

        public string? Attachment { get; set; }

        public int? PortalCusTypeId { get; set; }
        public bool? PortalCondition { get; set; }

        public bool? OwnerProperty { get; set; }
        public long? AccountManagerID { get; set; }
        public string? LocationURL { get; set; }

        public bool? RequestUpdate { get; set; }
        public string? CustomerIDNo { get; set; }
        

        public string? CustomerMobile { get; set; }
        public string? NoteUpdate { get; set; }
        [Required]
        public string? StreetName { get; set; }

        public string? BuildingNumber { get; set; }
        [Required]
        public string? DistrictName { get; set; }
        [Required]
        public string? RegionName { get; set; }
        public bool CodeReadOnly { get; set; }
    }
    public class SysCustomerFilterForPURDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public long? FacilityId { get; set; }
        public int? GroupId { get; set; }
        public string? Mobile { get; set; }
        public int? BranchId { get; set; }
    }
    public class SysCustomerDisplayForPURDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public long? FacilityId { get; set; }
        public int? GroupId { get; set; }
        public string? Mobile { get; set; }
        public int? BranchId { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
    }
    public class SysCustomerAddQVDto
    {
        // Add Qualified Vendor
        // Identification and Personal Information
        public string? IdNo { get; set; }
        public string? IdDate { get; set; }
        public string? IdIssuer { get; set; }
        public int? IdType { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public int? NationalityId { get; set; }
        public string? Mobile { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }

        // Job and Address Details
        public string? JobAddress { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set; }

        // Note, Photo, and RepresentedBy
        public string? Note { get; set; }
        public string? Photo { get; set; }
        public string? RepresentedBy { get; set; }
        public int? CityId { get; set; }

        // Banking Information
        public string? BankAccount { get; set; }
        public int? BankId { get; set; }

        // Sponsor Information
        public string? SponsorId { get; set; }
        public string? SponsorName { get; set; }
        public string? SponsorJobName { get; set; }
        public string? SponsorJobAddress { get; set; }
        public string? SponsorMobile { get; set; }
        public string? SponsorPhone { get; set; }
        public string? SponsorEmail { get; set; }

        // Other Settings and Metadata
        public string? CustomerName { get; set; }
        public int CusTypeId { get; set; } = 8;
        public int? CurrencyId { get; set; }
        public int? BranchId { get; set; }
        public int? GroupId { get; set; }
        public long? FacilityId { get; set; }
        public long? AccAccountId { get; set; }
        public bool AccSeparate { get; set; }
        public bool VatEnable { get; set; }
        public string? VatNumber { get; set; }
        public long? CreatedBy { get; set; }
        public List<SysCustomerFileDto>? FileDtos { get; set; }
    }
    public class SysCustomerAddPVDto
    {
        // Add Qualified Vendor
        // Identification and Personal Information
        public string? IdNo { get; set; }
        public string? IdDate { get; set; }
        public string? IdIssuer { get; set; }
        public int? IdType { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public int? NationalityId { get; set; }
        public string? Mobile { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }

        // Job and Address Details
        public string? JobAddress { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set; }

        // Note, Photo, and RepresentedBy
        public string? Note { get; set; }
        public string? Photo { get; set; }
        public string? RepresentedBy { get; set; }
        public int? CityId { get; set; }

        // Banking Information
        public string? BankAccount { get; set; }
        public int? BankId { get; set; }

        // Sponsor Information
        public string? SponsorId { get; set; }
        public string? SponsorName { get; set; }
        public string? SponsorJobName { get; set; }
        public string? SponsorJobAddress { get; set; }
        public string? SponsorMobile { get; set; }
        public string? SponsorPhone { get; set; }
        public string? SponsorEmail { get; set; }

        // Other Settings and Metadata
        public string? CustomerName { get; set; }
        public int CusTypeId { get; set; } = 8;
        public int? CurrencyId { get; set; }
        public int? BranchId { get; set; }
        public int? GroupId { get; set; }
        public long? FacilityId { get; set; }
        public long? AccAccountId { get; set; }
        public bool AccSeparate { get; set; }
        public bool VatEnable { get; set; }
        public string? VatNumber { get; set; }
        public long? CreatedBy { get; set; }
        public List<GetAllSysCustomerFileTypesDto>? FileTypesDto { get; set; }
    }
    public class SysCustomerEditQVDto
    {
        // Identification and Personal Information
        public long Id { get; set; }
        public string? IdNo { get; set; }
        public string? IdDate { get; set; }
        public string? IdIssuer { get; set; }
        public int? IdType { get; set; }
        public string? JobAddress { get; set; }  // Job_Address in VB
        public string? JobName { get; set; }     // Job_Name in VB
        public string? Mobile { get; set; }
        public string? Name { get; set; }
        public int? NationalityId { get; set; }  // Nationality_ID in VB
        public string? Note { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Photo { get; set; }
        public string? RepresentedBy { get; set; }  // Represented_by in VB

        // Contact Information
        public string? Email { get; set; }
        public string? BankAccount { get; set; }    // Bank_Account in VB
        public int? BankId { get; set; }            // Bank_ID in VB
        public int? CityId { get; set; }
        public int? BranchId { get; set; }          // Branch_ID in VB
        public long? ModifiedBy { get; set; }       // Corresponds to ModifiedBy in VB
        public int CusTypeId { get; set; } = 8;     // Cus_Type_Id in VB
        public string? Address { get; set; }

        // Account and Group Information
        public long? AccAccountId { get; set; }     // Acc_Account_ID in VB
        public int? GroupId { get; set; }           // Group_ID in VB
        public int? CurrencyId { get; set; }        // Currency_ID in VB
        public bool VatEnable { get; set; }         // VAT_Enable in VB
        public string? VatNumber { get; set; }      // VAT_Number in VB
        public string? Name2 { get; set; }          // Name2 in VB
        public int? Enable { get; set; }
        public string? CustomerName { get; set; }   // Customer_Name in VB

        // Sponsor Information
        public string? SponsorId { get; set; }      // Sponsor_ID in VB
        public string? SponsorJobAddress { get; set; } // Sponsor_Job_Address in VB
        public string? SponsorJobName { get; set; } // Sponsor_Job_Name in VB
        public string? SponsorMobile { get; set; }  // Sponsor_Mobile in VB
        public string? SponsorName { get; set; }    // Sponsor_Name in VB
        public string? SponsorPhone { get; set; }   // Sponsor_Phone in VB
        public string? SponsorEmail { get; set; }   // Sponsor_Email in VB
        public bool? IsDeleted { get; set; }
        public List<SysCustomerFileDto>? FileDtos { get; set; }
        public List<SysCustomerContactDto>? CustomerContactDtos { get; set; }
    }
    public class SysCustomerMemberIdCodeDto
    {
        public string? Code { get; set; }
        public string? MemberId { get; set; }
    }
}
public class SysCustomerEditDto : SysCustomerDto
{
    public SysCustomerEditDto()
    {
        AttDays = new List<HrAttDayVM>();
    }
    public List<HrAttDayVM> AttDays { get; set; }
}