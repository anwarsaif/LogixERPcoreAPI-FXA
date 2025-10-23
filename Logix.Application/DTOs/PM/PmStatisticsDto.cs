using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM
{
    public class PmStatisticsDto
    {
        public int StatusId { get; set; }
        public int Count { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string StatusName2 { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }
}
