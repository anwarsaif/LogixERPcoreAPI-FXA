using Logix.Application.DTOs.PM.PmProjectsStaff;

namespace Logix.Application.DTOs.PM.PmProjects
{
    public class PMProjectsSimpleInfoDto
    { //يستخدم في عن جلب من السرفيس المشروع باستخدام الكود
        public long? Id { get; set; } = 0;
        public string? Name { get; set; }
        public long? Code { get; set; } = 0;//pm
        public string? ProjectStart { get; set; }
        public string? ProjectEnd { get; set; }
        public decimal? ProjectValue { get; set; }
        public string? EmpName { get; set; }
        public long? FacilityId { get; set; }
        public bool? IsSubContract { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? Paid { get; set; }
        public int? RecipeId { get; set; }
        public decimal? PrevChangeRequestCost { get; set; }
        public decimal? BeforProjectCost { get; set; }
        public long? ManagerId { get; set; }
        public string? ManagerName { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerCode { get; set; }
        public string? BeforeProjectEndDate { get; set; }


    }
    public class PMProjectsAddDto
    {

        public long Id { get; set; } = 0;
        public long DDLParentType { get; set; } = 0;//نوع  المشروع  2 رئيسي او فرعيpm 
        public long? ParentCode { get; set; } = 0;//pm
        public string? ParentName { get; set; } = "";//pm  يستخدم  فقط  في التعديل  غرض فقط
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

        public string? Latitude { get; set; } // خط العرض pm

        public string? Longitude { get; set; }//خط  الطولpm

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
        public int? AppTypeID { get; set; } = 0;//not in database 
        public List<PMProjectTaskDto> PMProjectTaskDto { get; set; } = new List<PMProjectTaskDto>();
        public List<PMProjectsStaffAddDto> PMProjectsStaffAddDtos { get; set; } = new List<PMProjectsStaffAddDto>();
        public List<PMProjectsStokeholderDto> PMProjectsStokeholderDto { get; set; } = new List<PMProjectsStokeholderDto>();
        public List<PMProjectsItemDto> PMProjectsItemDtos { get; set; } = new List<PMProjectsItemDto>();
        public List<PMProjectsInstallmentDto> PmProjectsInstallmentDto { get; set; } = new List<PMProjectsInstallmentDto>();
        public List<PmProjectsAddDeducDto> PmProjectsAddDeducDto { get; set; } = new List<PmProjectsAddDeducDto>();//الاضافات 
        public List<PmProjectsAddDeducDto> DeducProjects { get; set; } = new List<PmProjectsAddDeducDto>();  //الخصومات
        public List<PmProjectsFileAddDto> ProjectFileList { get; set; } = new List<PmProjectsFileAddDto>();  //ملفات المشروع 



    }

    public class PMProjectsEditDto
    {

        public long Id { get; set; } = 0;
        public long? Code { get; set; } = 0;//pm
        public string? No { get; set; }//pm رقم المشروع
        public int? ProjectType { get; set; } = 0;
        public string? Name { get; set; }//pm
        public string? Name2 { get; set; }//pm
        public long DDLParentType { get; set; } = 0;//نوع  المشروع  2 رئيسي او فرعيpm 
        public long? CreatedBy { get; set; }//pm
        public long? CustomerId { get; set; } = 0;//pm
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




        // public decimal? DownPaymentPercent { get; set; } = 0;



        //   public long? QutationId { get; set; } = 0;//Request("ID")  
        // في شاشة اضافة المشروع  .Request("ID")   nothang   == 


        // public long? FacilityId { get; set; } = 0;//pm


        /*
                public int? InstallmentsCnt { get; set; } = 0;

                public decimal? InstallmentsValue { get; set; } = 0;

                public decimal? Cambialah { get; set; } = 0;

                public int? PaymentType { get; set; } = 0;

                    public decimal? AmountProfit { get; set; } = 0;

                public decimal? AdministrativeFees { get; set; } = 0;


                public long? AppId { get; set; } = 0;

                public bool? IsSubContract { get; set; }=false;*/

        //***************
        public List<PmProjectsFileAddDto> ProjectFileList { get; set; } = new List<PmProjectsFileAddDto>();  //ملفات المشروع 



    }

    /// <summary>
    /// ميثاق مشروع جديد
    /// </summary>
    public class PmProjectsCharterAddDto
    {

        public long? Id{ get; set; }
        public long? Code{ get; set; }
        public string? ProjectName { get; set; }
        public string? ManagerCode { get; set; }//pm
        public string? OwnerCode { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        //  الإدارة
        public long? OwnerDept { get; set; }
        public string? Beneficiary { get; set; }
        public decimal? EstimatedCost { get; set; }
        public decimal? AllowRate { get; set; }
        public string? Purpose { get; set; }
        public int? Duration { get; set; }
        public int? DurationType { get; set; }
         
    }





}