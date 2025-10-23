using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfLookUpCatagoryDto
    {
        public int CatagoriesId { get; set; }
        [Required]
        [StringLength(250)]
        public string? CatagoriesName { get; set; }
        [Required]
        [StringLength(250)]
        public string? CatagoriesName2 { get; set; }

        public long? UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
