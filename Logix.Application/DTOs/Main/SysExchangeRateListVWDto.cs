using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysExchangeRateListVWDto
    {
       
        public int Id { get; set; }
     
        public string? Name { get; set; }
     
        public string? Name2 { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
