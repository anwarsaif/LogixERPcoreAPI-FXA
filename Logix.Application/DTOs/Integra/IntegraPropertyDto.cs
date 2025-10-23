using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Integra
{
    public partial class IntegraPropertyDto
    {
        public long? Id { get; set; }
        public long? Code { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public long? IntegraSystemId { get; set; }
        public string? Description { get; set; }
    }
    public partial class IntegraPropertyEditDto
    {
        public long Id { get; set; }
        public long? Code { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public long? IntegraSystemId { get; set; }
        public string? Description { get; set; }
    }
    public partial class IntegraPropertyFilterDto
    {
        public string? Name { get; set; }
        public long? IntegraSystemId { get; set; }
    }
}
