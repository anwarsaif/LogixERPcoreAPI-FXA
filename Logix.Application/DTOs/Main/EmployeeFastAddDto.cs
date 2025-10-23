
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class EmployeeFastAddDto
    {
        public EmployeeFastAddDto()
        {
            AutoNumbering = true;
        }
        [StringLength(50)]
        public string? EmpId { get; set; } = null!;

        [Required]
        [StringLength(250)]
        public string? EmpName { get; set; }

        [StringLength(250)]
        public string? EmpName2 { get; set; }

        [Range(1, long.MaxValue)]
        public int? BranchId { get; set; }

        public int? JobType { get; set; }

        [Column("Job_Catagories_ID")]
        public int? JobCatagoriesId { get; set; }

        public bool AutoNumbering { get; set; }
        public string? IdNo { get; set; }
        public int? NationalityId { get; set; }

    }
}
