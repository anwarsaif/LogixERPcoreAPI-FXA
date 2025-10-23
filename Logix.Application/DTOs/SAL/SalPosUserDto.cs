using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.SAL
{
    public class SalPosUserDto
    {
        public long Id { get; set; }
        
        public long? PosId { get; set; }
        
        public long? UserId { get; set; }
        public long? CreatedBy { get; set; }
        
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
    
    public class SalPosUserEditDto
    {
        public long Id { get; set; }
        
        public long? PosId { get; set; }
        
        public long? UserId { get; set; }
       
        public long? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
    }
}
