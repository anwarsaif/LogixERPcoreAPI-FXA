using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfLookupDataFilterDto
    {
        public int? CatagoriesId { get; set; }
        [StringLength(250)]
        public string? Name { get; set; }
    }

    public class WfLookupDataDto
    {
        public long Id { get; set; }
        public long? Code { get; set; }
        [Range(1, int.MaxValue)]
        public int? CatagoriesId { get; set; }
        [Required]
        [StringLength(250)]
        public string? Name { get; set; }
        [Required]
        [StringLength(250)]
        public string? Name2 { get; set; }
        public long? UserId { get; set; }
        public int? SortNo { get; set; }
        public bool IsDeleted { get; set; }
    }
}