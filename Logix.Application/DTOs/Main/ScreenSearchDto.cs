using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{

    public class ScreenSearchDto
    {
        public string? ScreenName { get; set; }
        public string? ScreenName2 { get; set; }
        public long ScreenId { get; set; }
        public string? Folder { get; set; }
        public string? ScreenUrl { get; set; }
        //public string? Url { get; set; }
        public bool? IsAngular { get; set; }

        public bool? IsCore { get; set; }
    }
}
