using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfAppTypeFilterDto
    {
        [StringLength(250)]
        public string? Name { get; set; }
        [StringLength(250)]
        public string? Name2 { get; set; }
        public long? GroupId { get; set; }
        public long? SystemId { get; set; }
    }

    public class WfAppTypeDto
    {
        public int? Id { get; set; }
        [Required]
        [StringLength(250)]
        public string? Name { get; set; }
        [Required]
        [StringLength(250)]
        public string? Name2 { get; set; }
        public string? Url { get; set; }
        [Range(1,long.MaxValue)]
        public long? GroupId { get; set; }

        public bool? NotAllowRepeatRequest { get; set; }

        public string? SysGroupQuery { get; set; }
        public string? SysGroupId { get; set; }
        public bool? RequiredSubject { get; set; }

        public bool IsDeleted { get; set; }
    }
    
    public class WfAppTypeEditDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string? Name { get; set; }
        [Required]
        [StringLength(250)]
        public string? Name2 { get; set; }
        public string? Url { get; set; }
        [Range(1, long.MaxValue)]
        public long? GroupId { get; set; }

        public bool? NotAllowRepeatRequest { get; set; }

        public string? SysGroupQuery { get; set; }
        public string? SysGroupId { get; set; }
        public bool? RequiredSubject { get; set; }
    }
}
