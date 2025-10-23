using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM.PmProjects
{
    public class PMProjectsQuaryDto
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

        public string? Latitude { get; set; }

        public string? Longitude { get; set; }

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

    public class PMProjectExtractInfoDto
    {
        /*
         
         يستخدم لعرض بيانات  المشروع  في  شاشة  اضافة مستخلص  وفيه  البيانات الاساسيه للعرض
         */

        public long Id { get; set; }
        public long? Code { get; set; }
        public string? Name { get; set; }
        public decimal? ProjectValue { get; set; }
        public int? ExtractCount { get; set; } = 0;
        public decimal? ExtractValue { get; set; } = 0;
        public decimal? ExtractPayment { get; set; } = 0;
        public decimal? RemainingAmount { get; set; } = 0;//ExtractValue-ExtractPayment
        public long? CurrencyId { get; set; }
        public long? ParentCode { get; set; }
        public long? MainProjectCode { get; set; }
        public string? MainProjectName { get; set; }

        public decimal? ExchangeRate { get; set; }
        public long? CustomerCode { get; set; } = 0;//pm
        public string? CustomerName { get; set; } = "";   
        
        public long? ContractorCode { get; set; } = 0;// 1subcontract  في شاشة مستخلص عقد مشروع عرض فقط
        public string? ContractorName { get; set; } = "";
        public long? ApplicationCode { get; set; }
        //1

        public string? ProjectStart { get; set; }

        public string? ProjectEnd { get; set; }
        public string? ProjectManagerName { get; set; }
    }
    public class PMProjectsDto
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



    /*    public class PMProjectsEditDto
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

            public long? ModifiedBy { get; set; }

            public DateTime? ModifiedOn { get; set; }


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
    */


    public class GetProjectResultDto
    {
        public int RecipeID { get; set; }
        public decimal? Paid { get; set; }
        public long ProjectId { get; set; }
        // Add other fields here as needed
    }

    // الفلترة في شاشة اعداد ميثاق المشاريع
    public class PMChartsFilterDto
    {
        public string? ProjectCode{ get; set; }
        public string? ProjectName{ get; set; }
        public string? From{ get; set; }
        public string? To{ get; set; }
      
    }

    public class PMProjectChartEditDto
    {
        public long? ProjectId { get; set; }
        public string? ProjectName { get; set; }
        // مالك المشروع
        public string? OwnerCode { get; set; }
        public string? StartDate { get; set; }
        // المدة المخططة لتنفيذ المشروع
        public int? Duration { get; set; }
        public int? DurationType { get; set; }
        //  تاريخ الإنتهاء المخطط
        public string? EndDate { get; set; }
        // الادارة 
        public long? Dept { get; set; }
        // المستفيد من المشروع
        public string? Beneficiary { get; set; }
        // القيمة التقديرية للمشروع
        public decimal? EstimatedCost { get; set; }
        //  نسبة السماح في الميزانية
        public decimal? AllowRate { get; set; }
        public string? Purpose { get; set; }


    }

    public class PMProjectScopeEditDto
    {
        public string? Scope { get; set; }

        public string? ScopeIncludes { get; set; }

        public string? ScopeExclude { get; set; }
        public long? ProjectId { get; set; }


    }

}