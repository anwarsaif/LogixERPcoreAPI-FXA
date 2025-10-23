using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfLookupTypeDto
    {
        public long Id { get; set; }

        [StringLength(550)]
        public string? TypeName { get; set; }

        [StringLength(550)]
        public string? TypeName2 { get; set; }
    }
}