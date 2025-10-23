using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class PrintInvoiceVM
    {
        public string? FacilityLogo { get; set; }
        public string? QrCode { get; set; }
        public string? RefNumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? ReleaseDate { get; set; }
        public string? DueDate { get; set; }
        public string? PrintDate { get; set; } = DateTime.Now.ToString("HH:mm:fff yyyy-MM-dd", CultureInfo.InvariantCulture);
        public string? CustomerName { get; set; }
        public string? CustomerVat { get; set; }
        public string? CustomerProject { get; set; }
        public string? MonthName { get; set; }
        
        public string? CustomerAddress { get; set; }

        public string? SellerName { get; set; }
        public string? SellerVat { get; set; }
        public string? UserCreator { get; set; }
        public string? SellerAddress { get; set; }
        public string? Note { get; set; }

        public List<OPMTransactionsDetailsDto> InvoiceDetails { get; set; }
        public decimal? TotalWithoutVat { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? TotalWithVat { get; set; }
        public decimal? TotalDiscounted { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string? Bankaccounts { get; set; }
        public PrintInvoiceVM()
        {
            InvoiceDetails = new List<OPMTransactionsDetailsDto>();
        }

    }
    
    public class PrintQuotationVM
    {
        public string? FacilityLogo { get; set; }
        public string? QrCode { get; set; }
        public string? RefNumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? ReleaseDate { get; set; }
        public string? DueDate { get; set; }
        public string? PrintDate { get; set; } = DateTime.Now.ToString("HH:mm:fff yyyy-MM-dd", CultureInfo.InvariantCulture);
        public string? CustomerName { get; set; }
        public string? CustomerVat { get; set; }
        public string? CustomerProject { get; set; }
        public string? CustomerAddress { get; set; }

        public string? SellerName { get; set; }
        public string? SellerVat { get; set; }
        public string? UserCreator { get; set; }
        public string? UserName { get; set; }
        public string? UserNameTitle { get; set; }
        public string? SellerAddress { get; set; }

        public List<OpmTransactionsItemDto> InvoiceDetails { get; set; }
        public decimal? TotalWithoutVat { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? TotalWithVat { get; set; }

        public string? FacilityName { get; set; }
        public string? FacilityName2 { get; set; }
        public string? FacilityAddress { get; set; }
        public string? FacilityMobile { get; set; }
        public string? FacilityLogoPrint { get; set; }

        public List<string> QuotIncludes { get; set; }
        public List<string> QuotIncludesEN { get; set; }
        public string? DeliveryTerm { get; set; }
        public string? Notes { get; set; }
        public string? AdditionalCondition { get; set; }
        public string? DocumentNote { get; set; }
        public string? PaymentTerms { get; set; }
        public string? DeliveryDate { get; set; }
        public string? FacilityStamp { get; set; }
        public string? introductionDetails { get; set; }

        public string? introduction { get; set; }
        public string? PrintFooter { get; set; }
        //------------------------------بياتات الاتصال في العميل
        public string? CusContactName { get; set; }
        public string? CusContactMobile { get; set; }
        public string? CusContactPhone { get; set; }
        public string? CusContactAddress { get; set; }
        public string? CusContactJobName { get; set; }
        public string? CusContactJobAddress { get; set; }
        public string? CusContactEmail { get; set; }
        public string? QuotationIncludesText { get; set; }
        public PrintQuotationVM()
        {
            InvoiceDetails = new List<OpmTransactionsItemDto>();
            QuotIncludes = new List<string>();
            QuotIncludesEN = new List<string>();
        }

    }

    
}
