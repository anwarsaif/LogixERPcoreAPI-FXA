using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysDepartmentCatagoryDto
    {
        public int Id { get; set; }
        [StringLength(2500)]
        public string? CatName { get; set; }
    }
}
