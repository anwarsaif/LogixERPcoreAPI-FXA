using Logix.Application.DTOs.ACC;
using Logix.Application.DTOs.OPM;

using Logix.Domain.ACC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.GB
{
    public class BranchListVM
    {
        public int BranchId { get; set; }
        public string? BraName { get; set; } = String.Empty;
        public string? BraName2 { get; set; } = String.Empty;
        public bool Selected { get; set; } = false;
    }
    public class SubitemsDto
    {
      
        public long AccAccountId { get; set; }
        [Required]
        

        [StringLength(255)]
        public string? AccAccountName { get; set; }
        [Required]
        
        [StringLength(255)]
        
        public string? AccAccountName2 { get; set; }
        [Range(1, long.MaxValue)]
        
        public long? AccGroupId { get; set; }
        //[Required]
        
        
        [StringLength(50)]
        public string? AccAccountCode { get; set; }
        
        public bool IsSub { get; set; }
        [Range(1, long.MaxValue)]
        
        public long? AccAccountParentId { get; set; }
        /// <summary>
        /// مركز التكلفة الافتراضي
        ////[Range(1, long.MaxValue)]
        
        public long? CcId { get; set; }


        [Range(1, long.MaxValue)]
        
        public int? AccountCloseTypeId { get; set; }
        //[Required]
        

        public int? AccountLevel { get; set; }
        
        public bool IsHelpAccount { get; set; }

        public bool? Aggregate { get; set; }
        [Range(1, long.MaxValue)]
        
        public bool IsActive { get; set; } = true;

        public long? FacilityId { get; set; }
        [Range(1, long.MaxValue)]
        
        public int? CurrencyId { get; set; }

        public int? BranchId { get; set; }

       
        public long? AccAccountParentId2 { get; set; }

        public long? AccAccountParentId3 { get; set; }
        

        [StringLength(50)]
        public string? AccAccountParentCode { get; set; }
        //[Required]
        
        [StringLength(250)]
        public string? AccAccountnameParent { get; set; }
        [Range(1, long.MaxValue)]
        
        
        public int? DeptID { get; set; }
        [Range(1, long.MaxValue)]
        
        
        public int? AccAccountType { get; set; }
        //[Required]
        
        public string? RefranceNo { get; set; }
      
       
        
        public string? Note { get; set; }
   
     
        //[Required]
        
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public bool Numbring { get; set; }
        public int? CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }

        public int? DeleteUserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeleteDate { get; set; }
        public bool? IsDeleted { get; set; }

        public string? CurrencyName { get; set; }

        
        public string? DeptName { get; set; }
    
        public List<SubitemsDto>? Children { get; set; }

        public DateTime RefranceDate { get; set; }
        //-----------------------------------------
   
        
        [StringLength(255)]
        public string? AccAccountNameS { get; set; }
        
        
        [StringLength(50)]
        public string? AccAccountCodeS { get; set; }
        
        public string? Code { get; set; }
        public string? Code2 { get; set; }
        
        public string? AccGroupName { get; set; }
        //[Required]
        [Range(1, long.MaxValue)]
        
        public long? FinYear { get; set; }
        public List<BranchListVM>? BranchList { get; set; }
        
        public int? duration { get; set; }
     
        public string? Branches { get; set; }
        
        public int? itemType { get; set; }

    }
    public class SubitemsEditDto 
    {
        public long AccAccountId { get; set; }
        [Required]
        

        [StringLength(255)]
        public string? AccAccountName { get; set; }
        [Required]
        [StringLength(255)]
        
        public string? AccAccountName2 { get; set; }
        [Range(1, long.MaxValue)]
        
        public long? AccGroupId { get; set; }
        [Required]
        
        
        [StringLength(50)]
        public string? AccAccountCode { get; set; }
        
        public bool IsSub { get; set; }
        [Range(1, long.MaxValue)]
        
        public long? AccAccountParentId { get; set; }
        /// <summary>
        /// مركز التكلفة الافتراضي
        ////[Range(1, long.MaxValue)]
        
        public long? CcId { get; set; }


        [Range(1, long.MaxValue)]
        
        public int? AccountCloseTypeId { get; set; }
        //[Required]
        

        public int? AccountLevel { get; set; }
        
        public bool IsHelpAccount { get; set; }

        public bool? Aggregate { get; set; }
        [Range(1, long.MaxValue)]
        
        public bool IsActive { get; set; }

        [Range(1, long.MaxValue)]
        
        public int? CurrencyId { get; set; }

        public int? BranchId { get; set; }
      


        public long? AccAccountParentId2 { get; set; }

        public long? AccAccountParentId3 { get; set; }
        //[Required]
        

        [StringLength(50)]
        public string? AccAccountParentCode { get; set; }
        //[Required]
        
        [StringLength(250)]
        public string? AccAccountnameParent { get; set; }
        [Range(1, long.MaxValue)]
        
        
        public int? DeptID { get; set; }
        [Range(1, long.MaxValue)]
        
        
        public int? AccAccountType { get; set; }
        //[Required]
        
        public string? RefranceNo { get; set; }
       


        
        public string? Note { get; set; }
        //[Required]
        
        public string? Code { get; set; }
        public string? Code2 { get; set; }
        //[Required]
        

        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public bool Numbring { get; set; }
   
        public string? CurrencyName { get; set; }
        
        public string? DeptName { get; set; }

        [Range(1, long.MaxValue)]
        
        public long? FinYear { get; set; }
        public List<BranchListVM>? BranchList { get; set; }
        
        public int? duration { get; set; }

        
        public string? Branches { get; set; }

        
        public int? itemType { get; set; }
    }
    public class SubitemsReportVM
    {

        public long AccAccountId { get; set; }

        

        [StringLength(255)]
        public string? AccAccountName { get; set; }


        [StringLength(255)]
        
        public string? AccAccountName2 { get; set; }

        

        [StringLength(50)]
        public string? AccAccountCode { get; set; }
       
    
        
        public long? AccAccountParentId { get; set; }
     

        public long? FacilityId { get; set; }
      
 
        

        [StringLength(50)]
        public string? AccAccountParentCode { get; set; }
        
        [StringLength(250)]
        public string? AccAccountnameParent { get; set; }
      


        //[Required]
        
        public string? Code { get; set; }
        public string? Code2 { get; set; }
        //[Required]
        
        public string? Name { get; set; }
        //[Range(1, long.MaxValue)]

        
        public int? DeptID { get; set; }


        
        public bool? IsActive { get; set; } = true;
        public string? Name2 { get; set; }
        public decimal AmountInitial { get; set; }
        public decimal AmountReinforcements { get; set; }
        public decimal AmountTransfersFrom { get; set; }
        public decimal AmountTransfersTo { get; set; }
        public decimal AmountLinks  { get; set; }
    public decimal AmountTotal { get; set; }
    public decimal AmountDiscounts { get; set; }
        


        [StringLength(255)]
        public string? AccAccountNameS { get; set; }


   

        

        [StringLength(50)]
        public string? AccAccountCodeS { get; set; }
        public decimal AmountExpenses { get; set; }

    }
    public class SubitemsVM:AccAccountsVw
    {
        public decimal AmountInitial { get; set; } = 0;
        public decimal AmountTransfersFrom { get; set; } = 0;
        public decimal AmountTransfersTo { get; set; } = 0;
        public decimal AmountReinforcements { get; set; } = 0;
        public decimal AmountLinks { get; set; } = 0;
        public decimal AmountTotal { get; set; } = 0;
        public decimal AmountDiscounts { get; set; } = 0;
        public decimal AmountExpenses { get; set; } = 0;

    }
    public class SubitemExportExcelVM 
    {
        public long AccAccountId { get; set; }
        public string? AccAccountName { get; set; }
        public string? AccAccountName2 { get; set; }
        public string? AccAccountCode { get; set; }
        public decimal AmountInitial { get; set; } = 0;
        public decimal AmountTransfersFrom { get; set; } = 0;
        public decimal AmountTransfersTo { get; set; } = 0;
        public decimal AmountReinforcements { get; set; } = 0;
        public decimal AmountLinks { get; set; } = 0;
        public decimal AmountTotal { get; set; } = 0;
        public decimal AmountDiscounts { get; set; } = 0;

    }
}
