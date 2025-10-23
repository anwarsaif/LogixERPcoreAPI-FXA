using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Integra
{
    public partial class IntegraPropertyValuesVwDto
    {
        [Column("ID")]
        public long? Id { get; set; }
        [Column("Property_ID")]
        public long? PropertyId { get; set; }
        public long? Code { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Name2 { get; set; }
        public string? Description { get; set; }
        [Column("Property_Value")]
        public string? PropertyValue { get; set; }
        [Column("Integra_System_ID")]
        public long? IntegraSystemId { get; set; }
        [Column("Facility_ID")]
        public long? FacilityId { get; set; }
    }
}
