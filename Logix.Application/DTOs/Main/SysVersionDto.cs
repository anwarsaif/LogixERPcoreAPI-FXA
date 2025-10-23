using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysVersionDto
    {

        public long Id { get; set; }
        [StringLength(250)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? VersionNo { get; set; }

        public DateTime? CreatedOn { get; set; }
    }

    public class SysVersionEditDto: SysVersionDto
    {

    }
}
