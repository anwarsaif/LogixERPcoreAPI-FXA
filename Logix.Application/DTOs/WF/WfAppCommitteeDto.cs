using Logix.Application.DTOs.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfAppCommitteeFilterDto
    {
        public string? Name { get; set; }
        public string? EmpName { get; set; }
        public int? Status { get; set; }
    }

    public class WfAppCommitteeDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public string? DecisionNumber { get; set; }
        [StringLength(10)]
        public string? DecisionDate { get; set; }
        public long? EmpId { get; set; }
        public string? FormationDecision { get; set; }
        public string? Note { get; set; }
        public bool Isactive { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class WfAppCommitteeAddDto
    {
        public long Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Name2 { get; set; }
        [Required]
        public string? DecisionNumber { get; set; }
        [Required]
        [StringLength(10)]
        public string? DecisionDate { get; set; }
        //public long? EmpId { get; set; }
        [Required]
        public string? EmpCode { get; set; }
        public string? FormationDecision { get; set; }
        public string? Note { get; set; }
        public bool Isactive { get; set; }
        public bool IsDeleted { get; set; }

        public List<WfAppCommitteesMemberDto>? MembersDto { get; set; }
        public List<SaveFileDto>? FilesDto { get; set; }
    }

    public class WfAppCommitteeEditDto
    {
        public long Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Name2 { get; set; }
        [Required]
        public string? DecisionNumber { get; set; }
        [Required]
        [StringLength(10)]
        public string? DecisionDate { get; set; }
        public long? EmpId { get; set; }
        [Required]
        public string? EmpCode { get; set; }
        public string? FormationDecision { get; set; }
        public string? Note { get; set; }
        public bool Isactive { get; set; }

        public List<WfAppCommitteesMemberDto>? MembersDto { get; set; }
        public List<SaveFileDto>? FilesDto { get; set; }
    }
}
