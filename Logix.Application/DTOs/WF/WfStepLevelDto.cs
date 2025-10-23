using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfStepLevelDto
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string? LevelName { get; set; }
    }
}