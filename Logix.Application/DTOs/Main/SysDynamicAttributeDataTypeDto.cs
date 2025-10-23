using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysDynamicAttributeDataTypeDto
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string? DataTypeCaption { get; set; }

        [StringLength(50)]
        public string? DataTypeName { get; set; }
    }
}
