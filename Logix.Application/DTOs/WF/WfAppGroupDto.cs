
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfAppGroupFilterDto
    {
        public long? SystemId { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
    }

    public class WfAppGroupDto
    {
        public long? Id { get; set; }
        [Required]
        [StringLength(2500)]
        public string? Name { get; set; }
        [Required]
        [StringLength(2500)]
        public string? Name2 { get; set; }
        [Range(1, long.MaxValue)]
        public long? SystemId { get; set; }

        [StringLength(2500)]
        public string? Note { get; set; } = "";
        public bool? IsDeleted { get; set; }

        public int? SortNo { get; set; }

        //[StringLength(2500)]
        //public string? Code { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }

    public class WfAppGroupEditDto
    {
        public long Id { get; set; }
        [Required]
        [StringLength(2500)]
        public string? Name { get; set; }
        [Required]
        [StringLength(2500)]
        public string? Name2 { get; set; }
        [Range(1, long.MaxValue)]
        public long? SystemId { get; set; }
        [Required]
        public int? SortNo { get; set; }
        [Required]
        [StringLength(2500)]
        public string? Code { get; set; }

        [StringLength(2500)]
        public string? Note { get; set; } = "";
    }
}
