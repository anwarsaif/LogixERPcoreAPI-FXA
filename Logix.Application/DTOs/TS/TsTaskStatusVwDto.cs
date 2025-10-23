using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.TS
{
    public partial class TsTaskStatusVwDto
    {
        public long? StatusId { get; set; }
        public string? StatusName { get; set; }
        public long Id { get; set; }
        public int? CatagoriesId { get; set; }
        public bool? Isdel { get; set; }
        public long? UserId { get; set; }
        public int? SortNo { get; set; }
        public string? Note { get; set; }
        public string? RefranceNo { get; set; }
        public int? ColorId { get; set; }
        public string? Expr1 { get; set; }
        public string? ColorValue { get; set; }
        public string? Color { get; set; }
        public string? Icon { get; set; }
        public string? StatusName2 { get; set; }
    }
}
