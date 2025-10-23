using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM.PmProjectsStaff
{

 
    public class PMProjectsStaffAddDto
    {

        public string? EmpCode { get; set; } 

        public List<long> ProjectIds { get; set; }    
        public long? RoleId { get; set; }
    }
}
