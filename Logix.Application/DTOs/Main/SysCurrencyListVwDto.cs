using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysCurrencyListVwDto
    {
        public int Id { get; set; }
        [StringLength(101)]
        public string? Title { get; set; }
        [StringLength(101)]
        public string? Title2 { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
