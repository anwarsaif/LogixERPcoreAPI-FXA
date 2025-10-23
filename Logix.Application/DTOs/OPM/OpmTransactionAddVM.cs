using Logix.Application.DTOs.SAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class QuotationVM
    {
        public long Code { get; set; }
        public string Name { get; set; } = String.Empty;
        public bool Selected { get; set; } = false;
    }
    public class OpmTransactionAddVM
    {
        public OpmTransactionAddVM()
        {
            SalTransactionDto = new SalTransactionDto();
            QuotationList = new List<QuotationVM>();
        }
        public SalTransactionDto SalTransactionDto { get; set; }
        public List<QuotationVM>? QuotationList { get; set; }
    }

    public class OpmTransactionEditVM
    {
        public OpmTransactionEditVM()
        {
            SalTransactionDto = new SalTransactionEditDto();
            SalTransactionCopiesDto = new SalTransactionDto();
            QuotationList = new List<QuotationVM>();
        }
        public SalTransactionEditDto SalTransactionDto { get; set; }
        public SalTransactionDto? SalTransactionCopiesDto { get; set; }
        public List<QuotationVM> QuotationList { get; set; }
    }
}
