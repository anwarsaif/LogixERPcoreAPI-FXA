
using Logix.Domain.HR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class InvestEmployeeDto
    {
        public long? Id { get; set; }

        [StringLength(50)]
        public string? EmpId { get; set; } = null!;

        [Required]
        [StringLength(250)]
        public string? EmpName { get; set; }
        [StringLength(250)]
        public string? EmpName2 { get; set; }

        public bool? Isdel { get; set; }

        public long? UserId { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }

        public int? JobType { get; set; }

        [Column("Job_Catagories_ID")]
        public int? JobCatagoriesId { get; set; }

        [Column("Status_ID")]
        public int? StatusId { get; set; }

        [Column("Job_Description")]
        public string? JobDescription { get; set; }

        [Column("Nationality_ID")]
        public int? NationalityId { get; set; }

        [Column("Marital_Status")]
        public int? MaritalStatus { get; set; }

        public int? Gender { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salary { get; set; }

        [Column("Stop_salary")]
        public bool? StopSalary { get; set; }

        [Column("Stop_Date_Salary")]
        [StringLength(12)]
        public string? StopDateSalary { get; set; }

        [Column("Stop_Salary_Code")]
        public int? StopSalaryCode { get; set; }

        [Column("Postal_Code")]
        [StringLength(20)]
        public string? PostalCode { get; set; }

        [Column("POBox")]
        [StringLength(20)]
        public string? Pobox { get; set; }

        [Column("Home_Phone")]
        [StringLength(20)]
        public string? HomePhone { get; set; }

        [Column("Office_Phone")]
        [StringLength(20)]
        public string? OfficePhone { get; set; }

        [Column("Office_Phone_Ex")]
        [StringLength(20)]
        public string? OfficePhoneEx { get; set; }

        [StringLength(20)]
        public string? Mobile { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [Column("Emp_Photo")]
        [StringLength(500)]
        public string? EmpPhoto { get; set; }

        [Column("Contract_Type_ID")]
        public int? ContractTypeId { get; set; }

        [Column("DOAppointment")]
        [StringLength(12)]
        public string? Doappointment { get; set; }

        public string? Note { get; set; }

        [Column("ID_No")]
        [StringLength(50)]
        public string? IdNo { get; set; }

        [Column("ID_Issuer")]
        [StringLength(250)]
        public string? IdIssuer { get; set; }

        [Column("ID_Issuer_Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdIssuerDate { get; set; }

        [Column("ID_Expire_Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdExpireDate { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? BirthDate { get; set; }

        [Column("Birth_Place")]
        [StringLength(500)]
        public string? BirthPlace { get; set; }

        [Column("Passport_No")]
        [StringLength(50)]
        public string? PassportNo { get; set; }

        [Column("Pass_Issuer_Date")]
        [StringLength(50)]
        public string? PassIssuerDate { get; set; }

        [Column("Pass_Expire_Date")]
        [StringLength(50)]
        public string? PassExpireDate { get; set; }

        [Column("Qualification_ID")]
        public int? QualificationId { get; set; }

        [Column("Specialization_ID")]
        public int? SpecializationId { get; set; }

        [Column("Direct_Deposit")]
        public bool? DirectDeposit { get; set; }

        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        [Column("Bank_ID")]
        public int? BankId { get; set; }

        [Column("Account_No")]
        [StringLength(50)]
        public string? AccountNo { get; set; }

        [Column("IBAN")]
        [StringLength(50)]
        public string? Iban { get; set; }

        [Column("Daily_Working_hours", TypeName = "decimal(18, 2)")]
        public decimal? DailyWorkingHours { get; set; }

        [Column("Dept_ID")]
        public int? DeptId { get; set; }

        [Column("Exclude_Attend")]
        public bool? ExcludeAttend { get; set; }

        [Column("Vacation_Days_Year")]
        public int? VacationDaysYear { get; set; }

        [Column("Pass_Issuer")]
        [StringLength(50)]
        public string? PassIssuer { get; set; }

        [Column("Religion_ID")]
        public int? ReligionId { get; set; }

        [StringLength(50)]
        public string? EntryNo { get; set; }

        [StringLength(10)]
        public string? EntryDate { get; set; }

        [StringLength(50)]
        public string? EntryPort { get; set; }

        public int? ChequeCash { get; set; }

        [StringLength(10)]
        public string? ContarctDate { get; set; }

        public int? IdType { get; set; }

        [StringLength(50)]
        public string? WorkNo { get; set; }

        [StringLength(10)]
        public string? WorkDate { get; set; }

        [StringLength(50)]
        public string? WorkExpDate { get; set; }


        [StringLength(50)]
        public string? WorkPlace { get; set; }


        [StringLength(50)]
        public string? VisaNo { get; set; }

        public long? CcId { get; set; }

        public long? AccountId { get; set; }


        [StringLength(50)]
        public string? AccountCode { get; set; }

        [StringLength(50)]
        public string? Doappointmentold { get; set; }


        public int? InsuranceCategory { get; set; }


        public int? InsuranceCompany { get; set; }


        [StringLength(10)]
        public string? InsuranceDateValidity { get; set; }

        public int? Location { get; set; }


        [StringLength(10)]
        public string? ContractData { get; set; }


        [StringLength(10)]
        public string? ContractExpiryDate { get; set; }


        public string? NoteContract { get; set; }


        [StringLength(50)]
        public string? EmpCode2 { get; set; }


        [StringLength(10)]
        public string? GosiDate { get; set; }


        [StringLength(50)]
        public string? GosiNo { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? GosiSalary { get; set; }

        [StringLength(50)]
        public string? OccupationId { get; set; }

        public int? SponsorsId { get; set; }

        [StringLength(50)]
        public string? PhoneCountry { get; set; }


        [StringLength(250)]
        public string? AddressCountry { get; set; }

        [StringLength(250)]
        public string? Address { get; set; }

        [StringLength(50)]
        public string? InsuranceCardNo { get; set; }

        [StringLength(250)]
        public string? TicketTo { get; set; }

        public int? TicketType { get; set; }

        [StringLength(50)]
        public string? TicketNoDependent { get; set; }


        public long? SalaryGroupId { get; set; }

        [Column("Facility_ID")]
        public int? FacilityId { get; set; }

        [Column("Card_Expiration_Date")]
        [StringLength(10)]
        public string? CardExpirationDate { get; set; }

        [Column("IS_Ticket")]
        public bool? IsTicket { get; set; }

        [Column("Gois_Subscription_Expiry_Date")]
        [StringLength(10)]
        public string? GoisSubscriptionExpiryDate { get; set; }

        [Column("Gosi_Bisc_Salary", TypeName = "decimal(18, 2)")]
        public decimal? GosiBiscSalary { get; set; }

        [Column("Gosi_House_Allowance", TypeName = "decimal(18, 2)")]
        public decimal? GosiHouseAllowance { get; set; }

        [Column("Gosi_Allowance_Commission", TypeName = "decimal(18, 2)")]
        public decimal? GosiAllowanceCommission { get; set; }

        [Column("Gosi_Other_Allowances", TypeName = "decimal(18, 2)")]
        public decimal? GosiOtherAllowances { get; set; }

        [Column("Place_Attendance")]
        public int? PlaceAttendance { get; set; }

        [Column("Attendance_Type")]
        public int? AttendanceType { get; set; }

        [Column("Value_Ticket", TypeName = "decimal(18, 2)")]
        public decimal? ValueTicket { get; set; }

        [Column("Ticket_Entitlement")]
        public int? TicketEntitlement { get; set; }

        [Column("Program_ID")]
        public int? ProgramId { get; set; }

        [Column("Manager_ID")]
        public string? ManagerId { get; set; }

        [Column("Others_Requirements")]
        public string? OthersRequirements { get; set; }

        [Column("Have_Bank_Loan")]
        public bool? HaveBankLoan { get; set; }

        [Column("Is_Sub")]
        public bool? IsSub { get; set; }

        [Column("Parent_ID")]
        public long? ParentId { get; set; }

        [Column("Apply_Salary_ladder")]
        public bool? ApplySalaryLadder { get; set; }

        [Column("Level_ID")]
        public int? LevelId { get; set; }

        [Column("Degree_ID")]
        public int? DegreeId { get; set; }

        [Column("Payment_Type_ID")]
        public int? PaymentTypeId { get; set; }

        [Column("Wages_Protection")]
        public int? WagesProtection { get; set; }

        [Column("Manager2_ID")]
        public long? Manager2Id { get; set; }

        [Column("Manager3_ID")]
        public long? Manager3Id { get; set; }

        [Column("Trial_Expiry_Date")]
        [StringLength(10)]
        public string? TrialExpiryDate { get; set; }

        [Column("Trial_Status_ID")]
        public int? TrialStatusId { get; set; }

        [Column("Gosi_Rate_Facility", TypeName = "decimal(18, 2)")]
        public decimal? GosiRateFacility { get; set; }

        [Column("Gosi_Type")]
        public int? GosiType { get; set; }

        [Column("Vacation2_Days_Year", TypeName = "decimal(18, 2)")]
        public decimal? Vacation2DaysYear { get; set; }

        [Column("Job_ID")]
        public long? JobId { get; set; }

        [Column("Reason_Status")]
        public string? ReasonStatus { get; set; }

        public bool? Synced { get; set; }

        [Column("Key_Check_Device")]
        [StringLength(50)]
        public string? KeyCheckDevice { get; set; }

        [Column("Check_Device")]
        public bool? CheckDevice { get; set; }

        [Column("Check_Device_Active")]
        public bool? CheckDeviceActive { get; set; }

        public int? AnnualIncreaseMethod { get; set; }

        [StringLength(10)]
        public string? LastIncrementDate { get; set; }

        [StringLength(10)]
        public string? LastPromotionDate { get; set; }


        public bool? ShareContactInfo { get; set; }


        public int? PayrollType { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HourCost { get; set; }

        public bool AutoNumbering { get; set; }

        //for display in opmContractEmpController=>Add
        public bool IsSelected { get; set; }
        public string? BraName { get; set; }
        public string? DepName { get; set; }
        public string? LocName { get; set; }
        public string? CatName { get; set; }
        public string? NationalityName { get; set; }
        public long IncreasId { get; set; }

        public int? TimeZoneId { get; set; }
        [Column("salary_insurance_wage", TypeName = "decimal(18, 2)")]
        public decimal? SalaryInsuranceWage { get; set; }

        [Column("IsJoinedGOSIAfterJuly32024")]
        public bool? IsJoinedGosiafterJuly32024 { get; set; }

        [StringLength(50)]
        public string? Email2 { get; set; }

        [Column("First_Name")]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Column("Father_Name")]
        [StringLength(50)]
        public string? FatherName { get; set; }

        [Column("Grandfather_Name")]
        [StringLength(50)]
        public string? GrandfatherName { get; set; }

        [Column("Last_Name")]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Column("First_Name2")]
        [StringLength(50)]
        public string? FirstName2 { get; set; }

        [Column("Father_Name2")]
        [StringLength(50)]
        public string? FatherName2 { get; set; }

        [Column("Grandfather_Name2")]
        [StringLength(50)]
        public string? GrandfatherName2 { get; set; }

        [Column("Last_Name2")]
        [StringLength(50)]
        public string? LastName2 { get; set; }

        [Column("Mobile_Backup")]
        [StringLength(20)]
        public string? MobileBackup { get; set; }

        [Column("Contract_Period_Type")]
        public int? ContractPeriodType { get; set; }
        public int? SectorId { get; set; }

        [Column("Blood_Type")]
        public int? BloodType { get; set; }

        [Column("Direct_Phone_Number")]
        public string? DirectPhoneNumber { get; set; }
        public InvestEmployeeDto()
        {
            AutoNumbering = true;
            IsSelected = false;
        }
    }

    public class InvestEmployeeAddDto : InvestEmployeeDto
    {
        public long? ShiftId { get; set; } // الورديات
        public int? TrialType { get; set; } // نوع فترة التجربة - شهر - اسبوع - يوم 
        public int? TrialCount { get; set; } // مدة فترة التجربة
        public decimal? TransportAllowance { get; set; } //  بدل النقل
        public decimal? HousingAllowance { get; set; } //  بدل السكن
        public decimal? MobileAllowance { get; set; } // بدل الهاتف
        public decimal? OtherAllowances { get; set; } // بدلات اخرى
        public decimal? GOSIDeduction { get; set; } // التأمينات الاجتماعية
        public decimal? TotalSalary { get; set; } // الراتب الاجمالي
        public decimal? NetSalary { get; set; } //  الراتب الصافي
        public bool ChkCreateUser { get; set; } // انشاء مستخدم للموظف
        public long? GroupId { get; set; } // مجموعة الصلاحيات
        public string? CostCenterCode { get; set; }
        //public int? MonthServes { get; set; } // عدد أشهر الخدمة
        //public int? DaysServes { get; set; } // عدد أيام الخدمة
        //public int? YearServes { get; set; } // عدد سنوات الخدمة
        //public List<HrAllowanceDeductionVw>? SalryAllownce { get; set; }
        //public List<HrAllowanceDeductionVw>? SalryDeduction { get; set; }

    }

    // this dto for edit or add new employee from employeescreen in main system
    public class InvestEmployeeDto2
    {
        public long? Id { get; set; }
        [StringLength(50)]
        public string? EmpId { get; set; } = null!;
        [Required]
        [StringLength(250)]
        public string? EmpName { get; set; }
        [StringLength(250)]
        public string? EmpName2 { get; set; }
        //public long? UserId { get; set; }
        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }
        //public int? JobType { get; set; }
        //public int? JobCatagoriesId { get; set; }
        //public int? StatusId { get; set; }
        //public int? FacilityId { get; set; }
        //[StringLength(50)]
        //public string? Email { get; set; }
        //[StringLength(50)]
        //public string? IdNo { get; set; }
        //public bool? CheckDevice { get; set; }
        //public bool? CheckDeviceActive { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }

        public bool AutoNumbering { get; set; }
    }


    // مستخدم في شاشة تعديل بيانات موظف - بيانات الموظف
    public class EmpDataForEditDto
    {
        public HrEmployeeVw? HrEmployeeVw { get; set; }
        public List<HrAllowanceVw>? SalryAllownce { get; set; }
        public List<HrDeductionVw>? SalryDeduction { get; set; }
        public List<HrDependentsVw>? Dependents { get; set; }
        public List<HrArchiveFilesDetailsVw>? Archives { get; set; }
        public Dictionary<long, string>? Properties { get; set; }
        public decimal? NetSalary { get; set; } //  الراتب الصافي
        public decimal? TotalSalary { get; set; } //  اجمالي الراتب

        public int? MonthServes { get; set; } // عدد أشهر الخدمة
        public int? DaysServes { get; set; } // عدد أيام الخدمة
        public int? YearServes { get; set; } // عدد سنوات الخدمة
        public string? LastworkingDay { get; set; }
        public int? Age { get; set; }
        //public string? CC_2Visible { get; set; }
        //public string? CC_3Visible { get; set; }
        //public string? CC_4Visible { get; set; }
        //public string? CC_5Visible { get; set; }
        //public string? RowIncomeTaxe { get; set; }
        //public string? RowIncomeTaxe2 { get; set; }

    }


    public class ChangeEmployeeImageDto
    {
        public string? empCode { get; set; }
        public string? imageUrl { get; set; }
    }

    public partial class EditEmployeeSalaryInfo
    {
        public string? Name { get; set; }
        public long Id { get; set; }
        public int? TypeId { get; set; }
        public int? AdId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
