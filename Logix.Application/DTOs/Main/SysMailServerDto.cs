using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysMailServerDto
    {
       
        public long Id { get; set; }
       
        public int? TypeId { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
     
        [StringLength(2500)]
        public string? SmtpServer { get; set; }
    
        [StringLength(50)]
        public string? SmtpPort { get; set; }
       
        public bool? Ssl { get; set; }
      
        public bool? Tls { get; set; }
        [StringLength(50)]
        public string? Username { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
      
        public long? UserId { get; set; }
        public long CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
