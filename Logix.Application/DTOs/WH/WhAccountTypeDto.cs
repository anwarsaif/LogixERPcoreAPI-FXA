using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
    public class WhAccountTypeDto
    {
        public int AccountTypeId { get; set; }
        [StringLength(50)]
        public string? AccountTypeName { get; set; }
    }
}