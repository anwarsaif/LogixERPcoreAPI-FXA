using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM.PmProjectsStaff
{
    public class PmProjectsStaffDto
    {
        public long Id { get; set; }

        public long? EmpId { get; set; }

        public long? ProjectId { get; set; }
        [StringLength(50)]
        public string? DateH { get; set; }

        public bool? IsDeleted { get; set; }

        public int? TypeId { get; set; }

        public bool? PlanningTeam { get; set; }

        public bool? ImplementationTeam { get; set; }

        public int? DepId { get; set; }
        public string? Responsibility { get; set; }
        public long? ParentId { get; set; }

        public long? RoleId { get; set; }
    }
   
    
    
    public class PmProjectsStaffEditDto
    {
        public long Id { get; set; }

        public long? EmpId { get; set; }

        public long? ProjectId { get; set; }
        [StringLength(50)]
        public string? DateH { get; set; }
        public long? CreatedBy { get; set; }

        public int? TypeId { get; set; }

        public bool? PlanningTeam { get; set; }

        public bool? ImplementationTeam { get; set; }

        public int? DepId { get; set; }
        [StringLength(250)]
        public string? Responsibility { get; set; }
        public long? ParentId { get; set; }

        public long? RoleId { get; set; }
    }

    public class EmployeeAssignDto
    {
        public List<long> ProjectsId { get; set; }

        public long EmpId { get; set; }

    }
}
