using Logix.Application.DTOs.PM.PmProjects;
using Logix.Application.DTOs.PM.PmProjectsStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM.SubContract
{
    public class PMSubContractsQuaryDto
    {

        public int? ProjectType { get; set; }

        public long Id { get; set; }
        public long? Code { get; set; }

        public string? Name { get; set; }

        public long? CustomerId { get; set; }
        public string? Description { get; set; }
        public int? Type { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public string? DateH { get; set; }

        public string? DateG { get; set; }

        public string? CustomerName { get; set; }

        public string? ProjectTypeName { get; set; }

        public string? TypeName { get; set; }

        public string? CustomerCode { get; set; }

        public int? BranchId { get; set; }

        public string? No { get; set; }

        public string? EmailCustomer { get; set; }

        public string? TelCustomer { get; set; }
        public string? Note { get; set; }

        public decimal? ProjectValue { get; set; }

        public string? ProjectStart { get; set; }

        public string? ProjectEnd { get; set; }

        public int? StartFrom { get; set; }

        public string? DateQutation { get; set; }

        public string? CodQutation { get; set; }

        public string? DurationDay { get; set; }

        public long? QutationId { get; set; }

        public string? Duration { get; set; }

        public decimal? DownPaymentPercent { get; set; }

        public long? ProjectManagerId { get; set; }


        public string? CompletionRate { get; set; }

        public decimal? EstimatedCost { get; set; }

        public string? ActualStartDate { get; set; }

        public string? ActualEndDate { get; set; }

        public decimal? DownPayment { get; set; }

        public string? EmpId { get; set; }

        public string? EmpName { get; set; }

        public string? DefendantName { get; set; }

        public string? DefendantNoId { get; set; }

        public string? JudicialAuthority { get; set; }

        public string? DepId { get; set; }

        public string? IssueNo { get; set; }

        public string? IssueNoFile { get; set; }

        public string? SubjectCase { get; set; }

        public string? FinalService { get; set; }

        public string? FinalOpinion { get; set; }

        public int RecipeId { get; set; }

        public int? CountOfEmployee { get; set; }

        public string? Latitude { get; set; } = "0";

        public string? Longitude { get; set; } = "0";

        public string? Name2 { get; set; }

        public int? InstallmentsCnt { get; set; }

        public decimal? InstallmentsValue { get; set; }

        public decimal? Cambialah { get; set; }

        public int? PaymentType { get; set; }

        public string? PaymentTypeName { get; set; }

        public string? SponsorName { get; set; }

        public string? SponsorId { get; set; }

        public string? IdNo { get; set; }

        public string? BraName { get; set; }

        public decimal? AmountProfit { get; set; }

        public decimal? AdministrativeFees { get; set; }

        public string? UserFullname { get; set; }

        public string? Mobile { get; set; }

        public string? StatusName { get; set; }

        public string? ColorValue { get; set; }

        public int? StatusId { get; set; }

        public long? ParentId { get; set; }

        public long? AppId { get; set; }

        public bool? IsSubContract { get; set; }

        public long? CcId { get; set; }

        public long? FacilityId { get; set; }

        public long? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? DurationType { get; set; }

        public string? CustomerName2 { get; set; }
        public long? ContractsType { get; set; }
        public decimal? ProjectAdditionsValue { get; set; }

        public long? SystemId { get; set; }

        public bool? Iscase { get; set; }

        public long? ContractualPaymentDay { get; set; }

        public long? ContactPersonId { get; set; }

        public decimal? DeductionValue { get; set; }

        public int? SalesmanId { get; set; }

        public long? RevenueChannelId { get; set; }

        public long? RevenueDivisionId { get; set; }

        public decimal? RetentionAmount { get; set; }

        public decimal? RetentionRate { get; set; }
        public long? BillingEvery { get; set; }

        public string? CostCenterName { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostCenterName2 { get; set; }

        public decimal? AllowanceRatioBudget { get; set; }
        public string? Beneficiary { get; set; }

        public long? OwnerDeptId { get; set; }
        public string? Scope { get; set; }

        public string? ScopeIncludes { get; set; }

        public string? ScopeExclude { get; set; }

        public string? OwnerDeptName { get; set; }

        public string? OwnerDeptName2 { get; set; }

        public long? ParentCode { get; set; }

        public string? ParentName { get; set; }

        public string? ParentName2 { get; set; }

        public long? ApplicantEmpId { get; set; }

        public string? ApplicantEmpCode { get; set; }

        public string? ApplicantEmpName { get; set; }

        public long? StepId { get; set; }

        public string? ProjStepName { get; set; }

        public string? ProjStepName2 { get; set; }

        public string? Part1Name { get; set; }

        public string? Patr1NoId { get; set; }

        public string? BraName2 { get; set; }

        public long? OwnerId { get; set; }

        public string? OwnerCode { get; set; }

        public string? OwnerName { get; set; }

        public long? DeptParentId { get; set; }

        public string? DurationTypeName { get; set; }

        public int? CharterStatus { get; set; }

        public string? IssueNoResumption { get; set; }

        public string? IssueNoSupremeCourt { get; set; }


        public string? IssueFileDateH { get; set; }

        public string? ResumptionNo { get; set; }

        public string? SupremeCourtNo { get; set; }

        public bool? Isletter { get; set; }

        public string? EmpName2 { get; set; }

        public string? CurrencyName { get; set; }

        public string? CurrencyName2 { get; set; }

        public string? StartFromName { get; set; }

        public string? StatusName2 { get; set; }

        public int TenderStatus { get; set; }

        public string? TenderStatusName { get; set; }

        public string? TenderStatusName2 { get; set; }

        public string? LastUpdateSteps { get; set; }
        // as select and calculate 
        public decimal Net { get; set; } = 0;
        public int RemainingDays { get; set; } = 0;
        public decimal InvAmts { get; set; } = 0;
        public int CntContarct { get; set; } = 0;
    }


    public class PMSubContractAddDto
    {

        public long Id { get; set; } = 0;
      //  public long DDLParentType { get; set; } = 0;//نوع  المشروع  2 رئيسي او فرعيpm 
        public long? ParentCode { get; set; } = 0;//
        public string? ParentName { get; set; } = "";//  يستخدم  فقط  في التعديل  غرض فقط

        public int? DDLCustomerType { get; set; }// يستخدم في عقود المشاريع استعلام فقط  اما في المشروع قيمته ثابتة 2
        public long? CustomerCode { get; set; } = 0;//pm
        public string? CustomerName { get; set; } = "";//pm  يستخدم  فقط  في التعديل  غرض فقط
        public int? Create_CC_ID { get; set; } = 0; //بيانات مركز التكلفةpm  
                                                    //if = 1
                                                    //CC_ID=CostCenterCode
                                                    //1=ربط بمركز تكلفة موجود مسبقاً
        public string? CostCenterCode { get; set; } //  gust for filter 
        public string? CostCenterName { get; set; } //  يستخدم  فقط  في التعديل  غرض فقط 
        public int? BranchId { get; set; } = 0;//pm
        public long? Code { get; set; } = 0;//pm

        public string? No { get; set; }//pm رقم المشروع

        public int? ProjectType { get; set; } = 0;

        public string? Name { get; set; }//pm

        public long? CustomerId { get; set; } = 0;//pm

        public string? DateH { get; set; }//pm

        public string? DateG { get; set; }//pm
        public string? Description { get; set; }//pm

        public int? StatusId { get; set; } = 0;// pm حالة المشروع 
        public int? Type { get; set; } = 0;// pm النوع   استشارات او ..
        public long? CreatedBy { get; set; }//pm

        public DateTime? CreatedOn { get; set; }//pm

        public bool? IsDeleted { get; set; }//pm

        public decimal? ProjectValue { get; set; } = 0;//pm

        public decimal? DownPayment { get; set; } = 0;//الدفعة المقدمة


        public string? ProjectStart { get; set; }//pm

        public string? ProjectEnd { get; set; }//pm

        public long? ProjectManagerId { get; set; } = 0;//pm يستخدم لي جلب الايدي


        public string? EmpID { get; set; } // فقط يستخدم  في الكود  لتخزين قيمة الموظف ليتم جب  الايدي عبره  وغير موجود في الداتا بيس

        public string? EmpName { get; set; } = "";// يستخدم في التعديل فقط عرض 
        public string? CompletionRate { get; set; } = "0";

        public decimal? EstimatedCost { get; set; } = 0;//التكلفة التقديرية

        public string? ActualStartDate { get; set; }//تاريخ الاستلام 

        public string? ActualEndDate { get; set; }//تاريخ الاغلاق
        public string? Note { get; set; }//pm

        public decimal? DownPaymentPercent { get; set; } = 0;

        public string? Duration { get; set; }//المدة  المشروع رقم

        public int? StartFrom { get; set; } = 0;//pm	بداية من 

        public string? DurationDay { get; set; }//احتساب عدد الإيامpm 

        public long? QutationId { get; set; } = 0;//Request("ID")  
        // في شاشة اضافة المشروع  .Request("ID")   nothang   == 

        public long? CcId { get; set; } = 0;             //pm

        public long? FacilityId { get; set; } = 0;//pm

        public int? CountOfEmployee { get; set; } = 0;//pm 

        public string? Latitude { get; set; }="0"; // خط العرض pm

        public string? Longitude { get; set; }= "0"; //خط  الطولpm

        public string? Name2 { get; set; }//pm

        public int? InstallmentsCnt { get; set; } = 0;

        public decimal? InstallmentsValue { get; set; } = 0;

        public decimal? Cambialah { get; set; } = 0;

        public int? PaymentType { get; set; } = 0;

        public decimal? AmountProfit { get; set; } = 0;

        public decimal? AdministrativeFees { get; set; } = 0;

        public long? ParentId { get; set; } = 0;

        public long? AppId { get; set; } = 0;

        public bool? IsSubContract { get; set; } = false;

        public long? CurrencyId { get; set; } = 0;//العملة

        public decimal? ExchangeRate { get; set; } = 0;//تعادل العملة

        public int? DurationType { get; set; } = 0;//نوع  مدة المشروع

        public long? ContractsType { get; set; } = 0;

        public decimal? ProjectAdditionsValue { get; set; } = 0;

        public long? ContractualPaymentDay { get; set; } = 0;

        public long? ContactPersonId { get; set; } = 0;

        public decimal? DeductionValue { get; set; } = 0;

        public int? SalesmanId { get; set; } = 0;//مسؤول المبيعات
        public string? SalesmanEmpId { get; set; }//رقم مسول المبيعات ليتم جلب الايدي عبره   
        public string? SalesmanEmpName { get; set; }//يستخدم  فقط في التعديل  عرض  فقط   

        public long? RevenueChannelId { get; set; } = 0;

        public long? RevenueDivisionId { get; set; } = 0;

        public decimal? RetentionAmount { get; set; } = 0;

        public decimal? RetentionRate { get; set; } = 0;
        public long? BillingEvery { get; set; } = 0;

        public decimal? AllowanceRatioBudget { get; set; } = 0;
        public string? Beneficiary { get; set; }

        public long? OwnerDeptId { get; set; } = 0;
        public string? Scope { get; set; }

        public string? ScopeIncludes { get; set; }

        public string? ScopeExclude { get; set; }

        public long? ApplicantEmpId { get; set; } = 0;

        public long? StepId { get; set; } = 0;

        public long? OwnerId { get; set; } = 0;

        public int? CharterStatus { get; set; } = 0;

        public bool? Isletter { get; set; } = false;
        public List<long?> AssigneeToUserIdList { get; set; } = new List<long?>();
        //pm project task use  sysTask

        public List<PMProjectTaskDto> PMProjectTaskDto { get; set; } = new List<PMProjectTaskDto>();
        public List<PMProjectsStaffAddDto> PMProjectsStaffAddDtos { get; set; } = new List<PMProjectsStaffAddDto>();
        public List<PMProjectsStokeholderDto> PMProjectsStokeholderDto { get; set; } = new List<PMProjectsStokeholderDto>();
        public List<PMProjectsItemDto> PMProjectsItemDtos { get; set; } = new List<PMProjectsItemDto>();
        public List<PMProjectsInstallmentDto> PmProjectsInstallmentDto { get; set; } = new List<PMProjectsInstallmentDto>();
        public List<PmProjectsAddDeducDto> PmProjectsAddDeducDto { get; set; } = new List<PmProjectsAddDeducDto>();//الاضافات 
        public List<PmProjectsAddDeducDto> DeducProjects { get; set; } = new List<PmProjectsAddDeducDto>();  //الخصومات
        public List<PmProjectsFileAddDto> ProjectFileList { get; set; } = new List<PmProjectsFileAddDto>();  //ملفات المشروع 

    }

    public class PMSubContractDto
    {

        public long Id { get; set; }

        public int? BranchId { get; set; }
        public long? Code { get; set; }

        public string? No { get; set; }

        public int? ProjectType { get; set; }

        public string? Name { get; set; }

        public long? CustomerId { get; set; }

        public string? DateH { get; set; }

        public string? DateG { get; set; }
        public string? Description { get; set; }

        public int? StatusId { get; set; }
        public int? Type { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public decimal? ProjectValue { get; set; }

        public decimal? DownPayment { get; set; }


        public string? ProjectStart { get; set; }

        public string? ProjectEnd { get; set; }

        public long? ProjectManagerId { get; set; }

        public string? CompletionRate { get; set; }

        public decimal? EstimatedCost { get; set; }

        public string? ActualStartDate { get; set; }

        public string? ActualEndDate { get; set; }
        public string? Note { get; set; }

        public decimal? DownPaymentPercent { get; set; }

        public string? Duration { get; set; }

        public int? StartFrom { get; set; }

        public string? DurationDay { get; set; }

        public long? QutationId { get; set; }

        public long? CcId { get; set; }

        public long? FacilityId { get; set; }

        public int? CountOfEmployee { get; set; }

        public string? Latitude { get; set; }

        public string? Longitude { get; set; }

        public string? Name2 { get; set; }

        public int? InstallmentsCnt { get; set; }

        public decimal? InstallmentsValue { get; set; }

        public decimal? Cambialah { get; set; }

        public int? PaymentType { get; set; }

        public decimal? AmountProfit { get; set; }

        public decimal? AdministrativeFees { get; set; }

        public long? ParentId { get; set; }

        public long? AppId { get; set; }

        public bool? IsSubContract { get; set; }

        public long? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? DurationType { get; set; }

        public long? ContractsType { get; set; }

        public decimal? ProjectAdditionsValue { get; set; }

        public long? ContractualPaymentDay { get; set; }

        public long? ContactPersonId { get; set; }

        public decimal? DeductionValue { get; set; }

        public int? SalesmanId { get; set; }

        public long? RevenueChannelId { get; set; }

        public long? RevenueDivisionId { get; set; }

        public decimal? RetentionAmount { get; set; }

        public decimal? RetentionRate { get; set; }
        public long? BillingEvery { get; set; }

        public decimal? AllowanceRatioBudget { get; set; }
        public string? Beneficiary { get; set; }

        public long? OwnerDeptId { get; set; }
        public string? Scope { get; set; }

        public string? ScopeIncludes { get; set; }

        public string? ScopeExclude { get; set; }

        public long? ApplicantEmpId { get; set; }

        public long? StepId { get; set; }

        public long? OwnerId { get; set; }

        public int? CharterStatus { get; set; }

        public bool? Isletter { get; set; }
    }


    public class PMSubContractEditDto
    {

        public long Id { get; set; } = 0;
        public long? Code { get; set; } = 0;//pm
        public string? No { get; set; }//pm رقم المشروع
        public int? ProjectType { get; set; } = 0;
        public string? Name { get; set; }//pm
        public string? Name2 { get; set; }//pm
     //  public long DDLParentType { get; set; } = 0;//نوع  المشروع  2 رئيسي او فرعيpm 
        public long? CreatedBy { get; set; }//pm
        public long? CustomerId { get; set; } = 0;//pm
        public int? DDLCustomerType { get; set; } = 3;// يستخدم في عقود المشاريع استعلام فقط  اما في المشروع قيمته ثابتة 2

        public long? CustomerCode { get; set; } = 0;//pm
        public string? DateH { get; set; }//pm
        public string? DateG { get; set; }//pm
        public int? StatusId { get; set; } = 0;// pm حالة المشروع 
        public int? Type { get; set; } = 0;// pm النوع   استشارات او ..
        public string? Description { get; set; }//pm
        public string? ProjectEnd { get; set; }//pm
        public string? ProjectStart { get; set; }//pm
        public decimal? ProjectValue { get; set; } = 0;//pm
        public decimal? DownPayment { get; set; } = 0;//الدفعة المقدمة
        public long? ProjectManagerId { get; set; } = 0;//pm يستخدم لي جلب الايدي
        public decimal? EstimatedCost { get; set; } = 0;//التكلفة التقديرية
        public string? ActualStartDate { get; set; }//تاريخ الاستلام 
        public string? ActualEndDate { get; set; }//تاريخ الاغلاق
        public int? StartFrom { get; set; } = 0;//pm	بداية من 
        public string? DurationDay { get; set; }//احتساب عدد الإيامpm 
        public string? Note { get; set; }//pm
        public int? CountOfEmployee { get; set; } = 0;//pm 
        public string? Latitude { get; set; } // خط العرض pm
        public string? Longitude { get; set; }//خط  الطولpm
        public long? ParentId { get; set; } = 0;
        public long? CcId { get; set; } = 0;             //pm
        public long? CurrencyId { get; set; } = 0;//العملة
        public decimal? ExchangeRate { get; set; } = 0;//تعادل العملة
        public int? DurationType { get; set; } = 0;//نوع  مدة المشروع
        public string? Duration { get; set; }//المدة  المشروع رقم
        public int? BranchId { get; set; } = 0;//pm
        public decimal? ProjectAdditionsValue { get; set; } = 0;
        public decimal? DeductionValue { get; set; } = 0;
        public int? SalesmanId { get; set; } = 0;//مسؤول المبيعات
        public string? SalesmanEmpId { get; set; }//رقم مسول المبيعات ليتم جلب الايدي عبره   
        public string? SalesmanEmpName { get; set; }//يستخدم  فقط في التعديل  عرض  فقط   



        public long? ParentCode { get; set; } = 0;//pm
        public int? Create_CC_ID { get; set; } = 0; //بيانات مركز التكلفةpm  
                                                    //if = 1
                                                    //CC_ID=CostCenterCode
                                                    //1=ربط بمركز تكلفة موجود مسبقاً
        public string? CostCenterCode { get; set; } //  gust for filter 

        public string? EmpID { get; set; } // فقط يستخدم  في الكود  لتخزين قيمة الموظف ليتم جب  الايدي عبره  وغير موجود في الداتا بيس      
                                           //public string? CompletionRate { get; set; } = "0";




        public List<PmProjectsFileAddDto> ProjectFileList { get; set; } = new List<PmProjectsFileAddDto>();  //ملفات المشروع 




    }

}
