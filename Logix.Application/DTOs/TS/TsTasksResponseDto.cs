using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.TS
{
    public partial class TsTasksResponseDto
    {
        public long? Id { get; set; }
        public long? TaskId { get; set; }
        public string? Comment { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedIn { get; set; }
        public long? UserId { get; set; }
        public bool? Isdel { get; set; }
        public string? DoneOn { get; set; }
        public TimeSpan? HoursSpent { get; set; }
        public TimeSpan? DoneTime { get; set; }
        public bool? ExractReport { get; set; }
        public string? SendToCustomerDate { get; set; }
        public string? ExractReportDate { get; set; }
        public decimal? CompletionRate { get; set; }
    }

    public partial class TsTasksResponseEditDto
    {
        public long Id { get; set; }
        public long? TaskId { get; set; }
        public string? Comment { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedIn { get; set; }
        public long? UserId { get; set; }
        public bool? Isdel { get; set; }
        public string? DoneOn { get; set; }
        public TimeSpan? HoursSpent { get; set; }
        public TimeSpan? DoneTime { get; set; }
        public bool? ExractReport { get; set; }
        public string? SendToCustomerDate { get; set; }
        public string? ExractReportDate { get; set; }
        public decimal? CompletionRate { get; set; }
    }
}
