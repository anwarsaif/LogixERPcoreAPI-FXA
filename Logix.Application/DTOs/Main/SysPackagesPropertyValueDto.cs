using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysPackagesPropertyValueDto
    {
        public long Id { get; set; }

        public long? PackageId { get; set; }

        public long? PropertyId { get; set; }

        public long? FacilityId { get; set; }

        public string? PropertyValue { get; set; }

        public bool IsDeleted { get; set; }
    }
}