using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysCustomerTypeDto
    {
        public int TypeId { get; set; }
       
        [StringLength(50)]
        public string? CusTypeName { get; set; }
        
        [StringLength(50)]
        public string? PervixCode { get; set; }
       
        public long? ScreenId { get; set; }

        //if we need it in future
        public long? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
