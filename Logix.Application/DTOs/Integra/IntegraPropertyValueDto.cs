using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Integra
{
    public partial class IntegraPropertyValueDto
    {
        public long Id { get; set; }
        public long? PropertyId { get; set; }
        public string? PropertyValue { get; set; }
        public long? FacilityId { get; set; }
        public bool? Editable { get; set; }
        public long? IntegraSystemId { get; set; }
    }
    public partial class IntegraPropertyValueEditDto
    {
        //public long Id { get; set; }
        public long? PropertyId { get; set; }
        public string? PropertyValue { get; set; }
        //public long? FacilityId { get; set; }
        //public bool? Editable { get; set; }
        public long? SystemId { get; set; }
    }
    public partial class IntegraPropertyValueFilterDto
    {
        public long? PropertyId { get; set; }
        public long? PropertyCode { get; set; }
        public string? PropertyName { get; set; }
        public string? PropertyName2 { get; set; }
        public string? PropertyValue { get; set; }
        public long? IntegraSystemId { get; set; }
        public string? IntegraSystemName { get; set; }
        public string? Description { get; set; }
    }
}
