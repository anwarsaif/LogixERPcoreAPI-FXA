using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public partial class SysRecordWebhookAuthDto
    {
        public long Id { get; set; }

        public long? WebHookAuthId { get; set; }

        public string? ErrorReason { get; set; }

        public string? ErrorCode { get; set; }

        public string? Data { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsSended { get; set; }
    }
    public partial class SysRecordWebhookAuthEditDto
    {
        public long Id { get; set; }

        public long? WebHookAuthId { get; set; }

        public string? ErrorReason { get; set; }

        public string? ErrorCode { get; set; }

        public string? Data { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsSended { get; set; }
    }
    public partial class SysRecordWebhookAuthFilterDto
    {
        public string? Name { get; set; }
        public string? ErrorCode { get; set; }
        public long? IsSended { get; set; }
        public long? AppId { get; set; }
    }
}
