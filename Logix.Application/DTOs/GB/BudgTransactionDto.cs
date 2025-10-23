using Logix.Domain.GB;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Logix.Application.DTOs.GB
{
    public class PrintBudgTransactionVM
    {
        public string? FacilityName { get; set; }
        public string? FacilityName2 { get; set; }
        public string? FacilityAddress { get; set; }
        public string? FacilityMobile { get; set; }
        public string? FacilityLogoPrint { get; set; }
        public string? FacilityLogoFooter { get; set; }

        public string? UserName { get; set; }
        public string? ProjectName { get; set; }
        public string? DateGregorian { get; set; }
        public string? DeptName { get; set; }
        public string? ItemsNo { get; set; }
        public string? ItemsName { get; set; }
        public decimal Amount { get; set; }

        public string? AccAccountName { get; set; }
        public string? Code { get; set; }
        public List<BudgTransactionDetaileDto> BudgeDetails { get; set; }
        public PrintBudgTransactionVM()
        {
            BudgeDetails = new List<BudgTransactionDetaileDto>();

        }

    }
    public class BudgTransactionDto
    {
        public long Id { get; set; }

        public string? Code { get; set; }
        public string? encId { get; set; }


        public string? DateHijri { get; set; }
        [Required]


        public string? DateGregorian { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();

        public string? TTime { get; set; }

        public string? Description { get; set; }
        [Range(1, long.MaxValue)]

        public long? PeriodId { get; set; }
        [Range(1, long.MaxValue)]

        public long? FinYear { get; set; }


        public long? FacilityId { get; set; }
        [Range(1, long.MaxValue)]

        public long? CcId { get; set; }

        public int? DocTypeId { get; set; }

        public int TransfersTypeId { get; set; }

        public int? CreatedBy { get; set; }


        public DateTime? CreatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? StatusId { get; set; }

        public int? PaymentTypeId { get; set; }

        public string? ChequNo { get; set; }

        public string? ChequDateHijri { get; set; }

        public long? BankId { get; set; }

        public string? Bian { get; set; }
        //[Required]

        [StringLength(255)]


        public decimal? Amount { get; set; }

        public string? AmountWrite { get; set; }

        public long? ReferenceNo { get; set; }

        public long? CollectionEmpId { get; set; }
        //[Range(1, long.MaxValue)]

        public int? CurrencyId { get; set; }
        //[Required]

        public decimal? ExchangeRate { get; set; }

        public string? ReferenceCode { get; set; }

        public long? ProjectId { get; set; }

        [Range(1, long.MaxValue)]
        public int? ReferenceType { get; set; }

        public long? ReferenceId { get; set; }

        public long? CustomerId { get; set; }

        public long? AppId { get; set; }
        // [Required]


        [StringLength(50)]
        public string? AccAccountCode { get; set; }

        public long AccAccountId { get; set; }
        //[Required]



        [StringLength(255)]
        public string? AccAccountName { get; set; }
        //[Required]

        [StringLength(255)]

        public string? AccAccountName2 { get; set; }




        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public string? CostCenterName2 { get; set; }

        public string? Code2 { get; set; }

        public string? JENO { get; set; }

        public string? DocTypeName { get; set; }

        [StringLength(10)]

        public string StartDate { get; set; } = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        [StringLength(10)]

        public string? EndDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();

        public string? AttachFile { get; set; }

        //[Required]

        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? Name2 { get; set; }
        //[Range(1, long.MaxValue)]

        public int AccAccountType { get; set; }
        //[Range(1, long.MaxValue)]

        public long? AccGroupId { get; set; }

        public long? AccAccountParentId { get; set; }

        public string? ProjectName { get; set; }
        [Range(1, long.MaxValue)]


        public long? DeptID { get; set; }

        public long? DeptIDS { get; set; }

    }
    public class BudgTransactionLinksDto
    {
        public long Id { get; set; }

        public string? Code { get; set; }

        public string? DateHijri { get; set; }
        [Required]


        public string? DateGregorian { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();

        public string? TTime { get; set; }

        public string? Description { get; set; }
        [Range(1, long.MaxValue)]

        public long? PeriodId { get; set; }
        [Range(1, long.MaxValue)]

        public long? FinYear { get; set; }


        public long? FacilityId { get; set; }
        [Range(1, long.MaxValue)]

        public long? CcId { get; set; }

        public int? DocTypeId { get; set; }

        public int TransfersTypeId { get; set; }

        public int? CreatedBy { get; set; }


        public DateTime? CreatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? StatusId { get; set; }

        public int? PaymentTypeId { get; set; }

        public string? ChequNo { get; set; }

        public string? ChequDateHijri { get; set; }

        public long? BankId { get; set; }

        public string? Bian { get; set; }
        //[Required]

        [StringLength(255)]


        public decimal? Amount { get; set; }

        public string? AmountWrite { get; set; }

        public long? ReferenceNo { get; set; }

        public long? CollectionEmpId { get; set; }
        //[Range(1, long.MaxValue)]

        public int? CurrencyId { get; set; }
        //[Required]

        public decimal? ExchangeRate { get; set; }
        [Required]

        public string? ReferenceCode { get; set; }

        public long? ProjectId { get; set; }

        [Range(1, long.MaxValue)]
        public int? ReferenceType { get; set; }

        public long? ReferenceId { get; set; }

        public long? CustomerId { get; set; }

        public long? AppId { get; set; }
        // [Required]


        [StringLength(50)]
        public string? AccAccountCode { get; set; }

        public long AccAccountId { get; set; }
        //[Required]



        [StringLength(255)]
        public string? AccAccountName { get; set; }
        //[Required]

        [StringLength(255)]

        public string? AccAccountName2 { get; set; }




        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public string? CostCenterName2 { get; set; }

        public string? Code2 { get; set; }

        public string? JENO { get; set; }

        public string? DocTypeName { get; set; }

        [StringLength(10)]

        public string StartDate { get; set; } = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

        [StringLength(10)]

        public string? EndDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //DateTime.ParseExact(DateTime.Now.ToString(), "yyyy/MM/dd", new CultureInfo("en-US")).ToString();
        public string? AttachFile { get; set; }


        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }

        public string? Name2 { get; set; }
        //[Range(1, long.MaxValue)]


        public int AccAccountType { get; set; }


        public string? ProjectName { get; set; }
        [Range(1, long.MaxValue)]


        public long? DeptID { get; set; }
    }

    public class BudgTransactionEditDto
    {
        public long Id { get; set; }

        public string? Code { get; set; }

        public string? DateHijri { get; set; }
        [Required]

        public string? DateGregorian { get; set; }

        public string? TTime { get; set; }

        public string? Description { get; set; }






        public long? CcId { get; set; }

        public int? DocTypeId { get; set; }

        public int TransfersTypeId { get; set; }

        public int? ModifiedBy { get; set; }



        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? StatusId { get; set; }

        public int? PaymentTypeId { get; set; }

        public string? ChequNo { get; set; }

        public string? ChequDateHijri { get; set; }

        public long? BankId { get; set; }

        public string? Bian { get; set; }
        //[Required]

        [StringLength(255)]

        public decimal? Amount { get; set; }

        public string? AmountWrite { get; set; }

        public long? ReferenceNo { get; set; }

        public long? CollectionEmpId { get; set; }


        public string? ReferenceCode { get; set; }

        public long? ProjectId { get; set; }
        [Range(1, long.MaxValue)]


        public int? ReferenceType { get; set; }

        public long? ReferenceId { get; set; }

        public long? CustomerId { get; set; }

        public long? AppId { get; set; }
        public long AccAccountId { get; set; }
        //[Required]



        [StringLength(255)]
        public string? AccAccountName { get; set; }
        //[Required]

        [StringLength(255)]

        public string? AccAccountName2 { get; set; }

        //[Required]


        [StringLength(50)]
        public string? AccAccountCode { get; set; }

        public string? Note { get; set; }

        [StringLength(50)]


        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public string? CostCenterName2 { get; set; }

        public string? Code2 { get; set; }

        public string? JENO { get; set; }

        public string? DocTypeName { get; set; }

        [StringLength(10)]

        public string? StartDate { get; set; }


        [StringLength(10)]

        public string? EndDate { get; set; }
        public string? AttachFile { get; set; }


        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }

        public string? Name2 { get; set; }
        //[Range(1, long.MaxValue)]


        public int AccAccountType { get; set; }
        [Range(1, long.MaxValue)]

        public long? FinYear { get; set; }

        public string? ProjectName { get; set; }
        [Range(1, long.MaxValue)]


        public long? DeptID { get; set; }
    }
    public class BudgTransactionVM2
    {
        public BudgTransactionVM2()
        {
            BudgTransactionDto = new BudgTransactionDto();
            Children2 = new List<BudgTransactionDetailesVw>();


        }
        public BudgTransactionDto BudgTransactionDto { get; set; }

        public List<BudgTransactionDetailesVw> Children2 { get; set; }

    }
    public class BudgTransactionVM
    {
        public BudgTransactionVM()
        {
            Children = new List<BudgTransactionDetaileDto>();
            BudgTransactionDto = new BudgTransactionDto();
            Children2 = new List<BudgTransactionDetailesVw>();
            Childrenyear = new List<BudgTransactionDetaileYearDto>();


        }
        public BudgTransactionDto BudgTransactionDto { get; set; }

        public BudgTransactionDetaileDto BudgTransactionDetaileDto { get; set; }
        public BudgTransactionDetaileDto? BudgTransactionDetaileDto2 { get; set; }


        public List<BudgTransactionDetaileDto> Children { get; set; }
        public List<BudgTransactionDetailesVw> Children2 { get; set; }
        public List<BudgTransactionDetaileYearDto> Childrenyear { get; set; }

    }

    public class BudgTransactionEditVM
    {
        public BudgTransactionEditVM()
        {
            Children = new List<BudgTransactionDetaileEditDto>();
        }
        public BudgTransactionEditDto BudgTransactionEditDto { get; set; }
        public BudgTransactionDetaileEditDto BudgTransactionDetaileEditDto { get; set; }
        public BudgTransactionDetaileEditDto? BudgTransactionDetaileEditDto2 { get; set; }
        public List<BudgTransactionDetaileEditDto> Children { get; set; }


    }
    public class BudgItemTransactionsVM
    {
        public BudgItemTransactionsVM()
        {
            Children = new List<BudgTransactionDetaileDto>();
            BudgTransactionDto = new BudgTransactionDto();


        }
        public BudgTransactionDto BudgTransactionDto { get; set; }
        public BudgTransactionDetaileDto BudgTransactionDetaileDto { get; set; }


        public List<BudgTransactionDetaileDto> Children { get; set; }


    }
    public class BudgTransactionLinksVM
    {
        public BudgTransactionLinksVM()
        {
            Children = new List<BudgTransactionDetaileDto>();
            BudgTransactionLinksDto = new BudgTransactionLinksDto();


        }
        public BudgTransactionLinksDto? BudgTransactionLinksDto { get; set; }

        public BudgTransactionDetaileDto BudgTransactionDetaileDto { get; set; }
        public BudgTransactionDetaileDto? BudgTransactionDetaileDto2 { get; set; }


        public List<BudgTransactionDetaileDto> Children { get; set; }


    }
    public class BudgTransactionLinksEditDto
    {
        public long Id { get; set; }

        public string? Code { get; set; }

        public string? DateHijri { get; set; }
        [Required]

        public string? DateGregorian { get; set; }

        public string? TTime { get; set; }

        public string? Description { get; set; }






        public long? CcId { get; set; }

        public int? DocTypeId { get; set; }

        public int TransfersTypeId { get; set; }

        public int? ModifiedBy { get; set; }



        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? StatusId { get; set; }

        public int? PaymentTypeId { get; set; }

        public string? ChequNo { get; set; }

        public string? ChequDateHijri { get; set; }

        public long? BankId { get; set; }

        public string? Bian { get; set; }
        //[Required]

        [StringLength(255)]

        public decimal? Amount { get; set; }

        public string? AmountWrite { get; set; }

        public long? ReferenceNo { get; set; }

        public long? CollectionEmpId { get; set; }


        public string? ReferenceCode { get; set; }

        public long? ProjectId { get; set; }
        [Range(1, long.MaxValue)]


        public int? ReferenceType { get; set; }

        public long? ReferenceId { get; set; }

        public long? CustomerId { get; set; }

        public long? AppId { get; set; }
        public long AccAccountId { get; set; }
        //[Required]



        [StringLength(255)]
        public string? AccAccountName { get; set; }
        //[Required]

        [StringLength(255)]

        public string? AccAccountName2 { get; set; }

        //[Required]


        [StringLength(50)]
        public string? AccAccountCode { get; set; }

        public string? Note { get; set; }

        [StringLength(50)]


        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public string? CostCenterName2 { get; set; }

        public string? Code2 { get; set; }

        public string? JENO { get; set; }

        public string? DocTypeName { get; set; }

        [StringLength(10)]

        public string? StartDate { get; set; }


        [StringLength(10)]

        public string? EndDate { get; set; }
        public string? AttachFile { get; set; }


        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }

        public string? Name2 { get; set; }
        //[Range(1, long.MaxValue)]


        public int AccAccountType { get; set; }
        [Range(1, long.MaxValue)]

        public long? FinYear { get; set; }

        public string? ProjectName { get; set; }
        [Range(1, long.MaxValue)]


        public long? DeptID { get; set; }
    }
    public class BudgTransactionLinksEditVM
    {
        public BudgTransactionLinksEditVM()
        {
            Children = new List<BudgTransactionDetaileEditDto>();
        }
        public BudgTransactionDetaileEditDto BudgTransactionDetaileEditDto { get; set; }
        public BudgTransactionDetaileEditDto? BudgTransactionDetaileEditDto2 { get; set; }
        public List<BudgTransactionDetaileEditDto> Children { get; set; }
        public BudgTransactionLinksEditDto BudgTransactionLinksEditDto { get; set; }


    }


}
