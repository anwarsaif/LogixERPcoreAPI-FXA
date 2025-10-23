using System.ComponentModel.DataAnnotations;

using System.Globalization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.GB
{

    public class PrintBudgExpensesLinksVM
    {
        public string? FacilityName { get; set; }
        public string? FacilityName2 { get; set; }
        public string? FacilityAddress { get; set; }
        public string? FacilityMobile { get; set; }
        public string? FacilityLogoPrint { get; set; }
        public string? FacilityLogoFooter { get; set; }

        public string? UserName { get; set; }

        public BudgExpensesLinksEditDto BudgExpensesLinksEditDto { get; set; }
        public PrintBudgExpensesLinksVM()
        {
            BudgExpensesLinksEditDto = new BudgExpensesLinksEditDto();

        }

    }

    public class BudgExpensesLinksDto
    {
        
        public long Id { get; set; }

        public long LinkID { get; set; }

        public long FinancialNo { get; set; }
        public decimal? Amount { get; set; }
 
        
        public int? CreatedBy { get; set; }


        public DateTime? CreatedOn { get; set; }

        public bool? IsDeleted { get; set; }



        public long? AppCode { get; set; }

        public string? AppDate { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public string? LinkCode { get; set; }
        public decimal? LinkAmount { get; set; }
         
        public decimal? ExpensesAmount { get; set; }

        public decimal? RequestAmount { get; set; }
        public decimal? ExRequestAmount { get; set; }
        public decimal? ExRemainingِِAmount { get; set; }
        public decimal? AmountTotal { get; set; }
        public long? BranchId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
      
        public int AccAccountType { get; set; }
        public decimal? LinkAmountInitial { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public long? AppId { get; set; }


    }
    public class BudgExpensesLinksEditDto
    {

        public long Id { get; set; }

        public long LinkID { get; set; }

        public long FinancialNo { get; set; }
        public decimal? Amount { get; set; }

      


        public long? AppCode { get; set; }

        public string? AppDate { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public string? LinkCode { get; set; }
        public decimal? LinkAmount { get; set; }
        public decimal? ExpensesAmount { get; set; }

        public decimal? RequestAmount { get; set; }
        public decimal? ExRequestAmount { get; set; }
        public decimal? ExRemainingِِAmount { get; set; }
        public decimal? AmountTotal { get; set; }
        public long? BranchId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }

        public int AccAccountType { get; set; }

        public string? BraName { get; set; }

        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
    }
}
