using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
    public class WhUnitDto
    {

        public long UnitId { get; set; }

        public string? UnitName { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
    
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; } = false;

        public string? UnitName2 { get; set; }
    } 
    public class WhUnitEditDto
    {

        public long UnitId { get; set; }

        public string? UnitName { get; set; }

        public long? ModifiedBy { get; set; }
    
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public string? UnitName2 { get; set; }
    }
}
