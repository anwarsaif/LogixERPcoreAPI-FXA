using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysNotificationfilterDto
    {
        public string? DateFrom { get; set; } 
        public string? DateTo { get; set; } 
        public long? StatusID { get; set; }

  

    }
    public class SysNotificationDto
    {
        public long Id { get; set; }

        public long? UserId { get; set; }

        public string? MsgTxt { get; set; }

        public bool? IsRead { get; set; }

        public DateTime? ReadDate { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? Url { get; set; }

        public long? ActivityLogId { get; set; }

        public long? TableId { get; set; }
    }
}
