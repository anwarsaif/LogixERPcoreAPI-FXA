using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.HD
{

    public partial class HdTickectDto
    {
        public long Id { get; set; }
        public long? TNo { get; set; }
        public string? Code { get; set; }
        public string? TDate { get; set; }
        public string? Subject { get; set; }
        public long? SystemId { get; set; }
        public long? DepId { get; set; }
        public int? Priority { get; set; }
        public string? Message { get; set; }
        public long? StatusId { get; set; }
        public int? CusId { get; set; }
        public int? Source { get; set; }
        public string? DueDate { get; set; }
        public int? AssiginTo { get; set; }
        public int? UserId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? TypeId { get; set; }
        public long? TicketEvaluationId { get; set; }
        public bool IsEvaluated { get; set; }
        public long? ScreenId { get; set; }
    }
    public partial class HdTickectEditDto
    {
        public long Id { get; set; }
        public long? TNo { get; set; }
        public string? Code { get; set; }
        public string? TDate { get; set; }
        public string? Subject { get; set; }
        public long? SystemId { get; set; }
        public long? DepId { get; set; }
        public int? Priority { get; set; }
        public string? Message { get; set; }
        public long? StatusId { get; set; }
        public int? CusId { get; set; }
        public int? Source { get; set; }
        public string? DueDate { get; set; }
        public int? AssiginTo { get; set; }
        public int? UserId { get; set; }
        public int? TypeId { get; set; }
        public long? TicketEvaluationId { get; set; }
        public bool IsEvaluated { get; set; }
        public long? ScreenId { get; set; }
    }
}

