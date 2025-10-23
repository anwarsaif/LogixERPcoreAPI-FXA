using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Integra
{
    public partial class IntegraFieldDto
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public string? FieldName { get; set; }
        public long? TableId { get; set; }
    }

    public partial class IntegraFieldEditDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public string? FieldName { get; set; }
        public long? TableId { get; set; }
    }
}
