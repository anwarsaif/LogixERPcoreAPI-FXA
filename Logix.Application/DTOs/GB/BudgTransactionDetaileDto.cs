using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace Logix.Application.DTOs.GB
{
    public class BudgTransactionDetaileYearDto
    {


        public long Id { get; set; }
        public int IncreasId { get; set; }
        public long? TId { get; set; }
        
        public string? DateGregorian { get; set; }

        public long? AccAccountId { get; set; }

        public long? CcId { get; set; }
        [Required]
        
        public decimal Debit { get; set; } = 0;
        //[ModelBinder(typeof(CustomDecimalModelBinder))]
        [Required]
        
        public decimal Credit { get; set; }

        public int? ReferenceTypeId { get; set; }


        public long? ReferenceNo { get; set; }
        
        public string? Description { get; set; }

        public int? CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }

        public int? DeleteUserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeleteDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Auto { get; set; }

        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? Cc2Id { get; set; }

        public long? Cc3Id { get; set; }

        public string? ReferenceCode { get; set; }

        public decimal? Rate { get; set; }
        [Required]
        

        public string? AccAccountName { get; set; }


        
        public string? AccAccountName2 { get; set; }


        

        [StringLength(50)]
        [Required]
        public string? AccAccountCode { get; set; }
        //[Required]
        
        public string? CostCenterCode { get; set; }
        //[Required]
        
        public string? CostCenterName { get; set; }
        
        public string? CostCenterName2 { get; set; }
        
        public decimal? AmountInitial { get; set; }
        
        public decimal? AmountTransfersFrom { get; set; }
        
        public decimal? AmountTransfersTO { get; set; }
        
        public decimal? AmountReinforcements { get; set; }
        
        public decimal? AmountLinks { get; set; }
        
        public decimal? AmountDiscounts { get; set; }
        
        public decimal? AmountTotal { get; set; }
        public decimal? AmountTransfers { get; set; }
        [StringLength(10)]
        

        public string StartDate { get; set; } = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        [StringLength(10)]
        

        public string? EndDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();

        
        public string? Code { get; set; }
        
        public string? Code2 { get; set; }
        
        public string? DocTypeName { get; set; }

        public string? DocTypeName2 { get; set; }
        
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? Name2 { get; set; }
        //[Range(1, long.MaxValue)]

        
        public int AccAccountType { get; set; }
        public decimal Balance { get; set; } = 0;
        
        public bool AllYear { get; set; }
        

        public string? AccAccountNameS { get; set; }
        
        public string? AccAccountCodeS { get; set; }
        public decimal? MoneyValue { get; set; }
        public decimal? CostsValue { get; set; }
        
        public long? AccAccountParentId { get; set; }
        [StringLength(50)]
        public string? AccAccountParentCode { get; set; }
        
        [StringLength(250)]
        public string? AccAccountnameParent { get; set; }
        

        public string? AccAccountnameParent2 { get; set; }
        
        public long? AccGroupId { get; set; }
        public string? AccGroupName { get; set; }
        public string? AccGroupName2 { get; set; }
        
        public long? FinYear { get; set; }
        
        public long? FinYearCu { get; set; }
        public int? itemType { get; set; }

    }
    public class BudgTransactionDetaileDto
    {


        public long Id { get; set; }
        public int IncreasId { get; set; } 
        public long? TId { get; set; }
        
        public string? DateGregorian { get; set; }
   
        public long? AccAccountId { get; set; }
   
        public long? CcId { get; set; }
        //[Required]
        
        public decimal Debit { get; set; } = 0;
        //[ModelBinder(typeof(CustomDecimalModelBinder))]
        //[Required]
        
        public decimal Credit { get; set; } 

        public int? ReferenceTypeId { get; set; }
     
 
        public long? ReferenceNo { get; set; }
        
        public string? Description { get; set; }

        public int? CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }

        public int? DeleteUserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeleteDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Auto { get; set; }
     
        public int? CurrencyId { get; set; }
       
        public decimal? ExchangeRate { get; set; }
   
        public long? Cc2Id { get; set; }
       
        public long? Cc3Id { get; set; }

        public string? ReferenceCode { get; set; }

        public decimal? Rate { get; set; }
        [Required]
        


        public string? AccAccountName { get; set; }


        
        public string? AccAccountName2 { get; set; }
 

        

        [StringLength(50)]
        [Required]
        public string? AccAccountCode { get; set; }
        //[Required]
        
        public string? CostCenterCode { get; set; }
        //[Required]
        
        public string? CostCenterName { get; set; }
        
        public string? CostCenterName2 { get; set; }
        
        public decimal? AmountInitial { get; set; }
        
        public decimal? AmountTransfersFrom { get; set; }
        
        public decimal? AmountTransfersTO { get; set; }
        
        public decimal? AmountReinforcements { get; set; }
        
        public decimal? AmountLinks { get; set; }
        
        public decimal? AmountDiscounts { get; set; }
        
        public decimal? AmountTotal { get; set; }
        public decimal? AmountTransfers { get; set; }
        [StringLength(10)]
        

        public string StartDate { get; set; } = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        [StringLength(10)]
        
       
        public string? EndDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();

        
        public string? Code { get; set; }
        
        public string? Code2 { get; set; }
        
        public string? DocTypeName { get; set; }
   
        public string? DocTypeName2 { get; set; }
        
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? Name2 { get; set; }
        //[Range(1, long.MaxValue)]

        
        public int AccAccountType { get; set; }
        public decimal Balance { get; set; } = 0;
        
        public bool AllYear { get; set; }
        
        
        public string? AccAccountNameS { get; set; }
        
        public string? AccAccountCodeS { get; set; }
       
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public decimal Value { get; set; }
        public long? TypeID { get; set; }
        
        public long? AccGroupId { get; set; }
        
        public decimal Value2 { get; set; }
        public string? MCode { get; set; }


    }
    public class BudgTransactionDetaileEditDto
    {


        public long Id { get; set; }
        public int IncreasId { get; set; }
        public long? TId { get; set; }
        
        public string? DateGregorian { get; set; }

        public long? AccAccountId { get; set; }

        public long? CcId { get; set; }
        //[Required]
        
        public decimal? Debit { get; set; }
        //[Required]
        
        public decimal? Credit { get; set; }

        public int? ReferenceTypeId { get; set; }


        public long? ReferenceNo { get; set; }
        
        public string? Description { get; set; }



        public int? ModifiedBy { get; set; }





        public DateTime? ModifiedOn { get; set; }


        public bool? IsDeleted { get; set; }
        public bool? Auto { get; set; }

        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? Cc2Id { get; set; }

        public long? Cc3Id { get; set; }

        public string? ReferenceCode { get; set; }

        public decimal? Rate { get; set; }
        //[Required]
        


        public string? AccAccountName { get; set; }


        
        public string? AccAccountName2 { get; set; }


        

        [StringLength(50)]
        //[Required]
        public string? AccAccountCode { get; set; }
        //[Required]
        
        public string? CostCenterCode { get; set; }
        //[Required]
        
        public string? CostCenterName { get; set; }
        
        public string? CostCenterName2 { get; set; }
        
        public decimal? AmountInitial { get; set; }
        
        public decimal? AmountTransfersFrom { get; set; }
        
        public decimal? AmountTransfersTO { get; set; }
        
        public decimal? AmountReinforcements { get; set; }
        
        public decimal? AmountLinks { get; set; }
        
        public decimal? AmountDiscounts { get; set; }
        
        public decimal? AmountTotal { get; set; }
        public decimal? AmountTransfers { get; set; }
        [StringLength(10)]
        
        public string? StartDate { get; set; }


        [StringLength(10)]
        
        public string? EndDate { get; set; }
        
        public string? Code { get; set; }
        
        public string? Code2 { get; set; }
        
        public string? DocTypeName { get; set; }

        public string? DocTypeName2 { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]

        
        public decimal Value { get; set; }
        public long? TypeID { get; set; }
        
        public long? AccGroupId { get; set; }
    }
    public class BudgTransactionDetaileModel
    {
        public long Id { get; set; }
        public int IncreasId { get; set; }
        public long? TId { get; set; }
        
        public string? DateGregorian { get; set; }

        public long? AccAccountId { get; set; }

        public long? CcId { get; set; }
        [Required]
        
        public decimal? Debit { get; set; }
        [Required]
        
        public decimal? Credit { get; set; }

        public int? ReferenceTypeId { get; set; }


        public long? ReferenceNo { get; set; }
        
        public string? Description { get; set; }

        public int? CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }

        public int? DeleteUserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeleteDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Auto { get; set; }

        public int? CurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? Cc2Id { get; set; }

        public long? Cc3Id { get; set; }

        public string? ReferenceCode { get; set; }

        public decimal? Rate { get; set; }
        //[Required]
        


        public string? AccAccountName { get; set; }


        
        public string? AccAccountName2 { get; set; }


        

        [StringLength(50)]
        //[Required]
        public string? AccAccountCode { get; set; }
        //[Required]
        
        public string? CostCenterCode { get; set; }
        //[Required]
        
        public string? CostCenterName { get; set; }
        
        public string? CostCenterName2 { get; set; }
        
        public decimal? AmountInitial { get; set; }
        
        public decimal? AmountTransfersFrom { get; set; }
        
        public decimal? AmountTransfersTO { get; set; }
        
        public decimal? AmountReinforcements { get; set; }
        
        public decimal? AmountLinks { get; set; }
        
        public decimal? AmountDiscounts { get; set; }
        
        public decimal? AmountTotal { get; set; }
        public decimal? AmountTransfers { get; set; }
        [StringLength(10)]
        
        public string? StartDate { get; set; }


        [StringLength(10)]
        
        public string? EndDate { get; set; }
        
        public string? Code { get; set; }
        
        public string? Code2 { get; set; }
        
        public string? DocTypeName { get; set; }

        public string? DocTypeName2 { get; set; }
        
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? Name2 { get; set; }
        //[Range(1, long.MaxValue)]

        
        public int AccAccountType { get; set; }
        public decimal? Balance { get; set; }
    }
}
