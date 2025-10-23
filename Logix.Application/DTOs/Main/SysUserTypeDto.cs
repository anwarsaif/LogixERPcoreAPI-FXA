using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysUserTypeDto
    {
        public int UserTypeId { get; set; }

        [StringLength(50)]
        public string? UserTypeName { get; set; }
    }
}
