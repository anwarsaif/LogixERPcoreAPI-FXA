namespace Logix.Application.DTOs.PM.PmProjects
{
    public class PmProjectSearchFilterVm
    {
        //النوع
        public int? ProjectType { get; set; }
        //التصنيفات 
        //Type
        public int? ProjectType2 { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerCode { get; set; }
        // الفرع 
        public int? BranchId { get; set; }
        /*      If BRANCH_ID <> 0 Then
                    objCmd.CommandText += " AND BRANCH_ID=@BRANCH_ID"
                    objCmd.Parameters.AddWithValue("BRANCH_ID", BRANCH_ID)
                Else
                    objCmd.CommandText += " and  BRANCH_ID in(select value from dbo.fn_Split('" & BRANCHs_ID.ToString & "',','))"
                End If
        */


        //  رقم  المشروع
        public long? Code { get; set; }
        public string? No { get; set; }
        //اسم المشروع 
        public string? Name { get; set; }
        //من تاريخ  
        public string? DateFrom { get; set; }
        // الى تاريخ
        public string? DateTo { get; set; }
        // الحالة   مكتمل او لم يبداء بعد 
        public int? StatusId { get; set; }
        //طبيعة المشروع  يتم    من  حقل Parent_ID
        //بحيث يتم  طبيعة المشروع  >رئيسي او فرعي  اذا رئيسي  يعن  =0 واذا فرعي  != 0  

        public long? Parent_Type { get; set; } = 1;
        // عقد الباطن 

        public bool? IsSubContract { get; set; } = false;

        //رقم المشروع في عقد الباطن
        public long? ParentCode { get; set; }


        //(Emp_ID=@Project_Manager_Code)
        public string? EmpId { get; set; }
        //Emp_Name LIKE N'%'+@Project_Manager_Name+'%'
        public string? EmpName { get; set; }

        //and Project_Value between @Amountfrom and @Amountto

        public decimal? Amountfrom { get; set; }
        public decimal? Amountto { get; set; }

        //(select count(CC_ID) from ACC_CostCenter
        //where CostCenter_Code=@CostCenter_Code and PM_Projects_VW.CC_ID=ACC_CostCenter.CC_ID)>0
        // ناتج الاسعلام  true or false 
        public string? CC_Code { get; set; }
        public string? CC_Name { get; set; }
        public bool? Isletter { get; set; } = false;
        public long? SystemId { get; set; } = 5;



    }
}
