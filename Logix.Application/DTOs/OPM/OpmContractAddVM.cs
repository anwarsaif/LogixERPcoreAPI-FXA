using Logix.Application.DTOs.SAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    //public class QuotationVM
    //{
    //    public long Code { get; set; }
    //    public string Name { get; set; } = String.Empty;
    //    public bool Selected { get; set; } = false;
    //}
    public class OpmContractAddVM
    {
        public OpmContractAddVM()
        {
              OpmContractDto = new OpmContractDto();
            QuotationList = new List<QuotationVM>();
        }
        public OpmContractDto OpmContractDto { get; set; }
        public List<QuotationVM> QuotationList { get; set; }
    }

    public class OpmContractVM
    {
        public OpmContractVM()
        {
            Items = new List<OpmContractItemDto>();
            Locations = new List<OpmContractLocationDto>();
        }
        public OpmContractDto OpmContractDto { get; set; }

        public List<OpmContractItemDto> Items { get; set; }
        public List<OpmContractLocationDto> Locations { get; set; }

    }
}
