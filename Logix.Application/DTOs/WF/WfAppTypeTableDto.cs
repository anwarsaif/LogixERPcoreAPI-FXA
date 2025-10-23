using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfAppTypeTableDto
    {
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
