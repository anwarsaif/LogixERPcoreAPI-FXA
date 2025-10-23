using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysTableDto
    {
        public int TableId { get; set; }
        
        [StringLength(200)]
        public string? TableDescription { get; set; }

        [StringLength(50)]
        public string? Primarykey { get; set; }
        
        [StringLength(50)]
        public string? TableName { get; set; }

        public string? Condition { get; set; }
        
        public string? ScreenUrl { get; set; }
        
        [StringLength(100)]
        public string? SystemId { get; set; }
    }
}
