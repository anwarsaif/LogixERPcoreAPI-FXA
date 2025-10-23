using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logix.Application.DTOs.FXA
{
    public class FxaAdditionsExclusionTypeFilterDto
    {
        public long? Id { get; set; }
        [StringLength(200)]
        public string? Name { get; set; }
        public int? TypeId { get; set; }
        public string? TypeName { get; set; }
    }
    
    public class FxaAdditionsExclusionTypeDto
    {
        public long? Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? Name { get; set; }
        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}