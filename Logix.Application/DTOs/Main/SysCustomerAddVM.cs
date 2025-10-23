using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class HrAttDayVM
    {
        public int DayNo { get; set; }
        public string DayName { get; set; } = String.Empty;
        public bool Selected { get; set; } = false;
    }
    public class SysCustomerAddVM
    {
        public SysCustomerAddVM()
        {
            SysCustomerDto = new SysCustomerDto();
            SysCustomerContactDto = new SysCustomerContactDto();
            SysCustomerFiles = new HashSet<SysCustomerFileDto>();
            AttDays = new List<HrAttDayVM>();
        }
        public SysCustomerDto SysCustomerDto { get; set; }
        public SysCustomerContactDto SysCustomerContactDto { get; set; }
        public List<HrAttDayVM> AttDays { get; set; }
        public IEnumerable<SysCustomerFileDto> SysCustomerFiles { get; set; }

    }
}
