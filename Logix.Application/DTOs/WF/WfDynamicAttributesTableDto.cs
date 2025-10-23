using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfDynamicAttributesTableDto
    {
        public long Id { get; set; }
        //public Guid? DynamicAttributeId { get; set; }

        [Required]
        [StringLength(2000)]
        public string? AttributeName { get; set; }
        [Range(1,int.MaxValue)]
        public int? DataTypeId { get; set; }
        public int? LookUpType { get; set; }
        public int? LookUpCatagoriesId { get; set; }
        public long? SysLookUpCatagoriesId { get; set; }
        public string? LookUpSql { get; set; }
        public long? TableId { get; set; }
        public long? StepId { get; set; }
        [Required]
        public int? SortOrder { get; set; }
        public bool? Required { get; set; }
        public string? DefaultValue { get; set; }
        public bool? IsReadOnly { get; set; }
        public int? MaxLength { get; set; }

        public bool IsDeleted { get; set; }
    }

    public class WfDynamicAttributesTableEditDto
    {
        public long Id { get; set; }
        public Guid? DynamicAttributeId { get; set; }

        [Required]
        [StringLength(2000)]
        public string? AttributeName { get; set; }
        [Range(1, int.MaxValue)]
        public int? DataTypeId { get; set; }
        public int? LookUpType { get; set; }
        public int? LookUpCatagoriesId { get; set; }
        public long? SysLookUpCatagoriesId { get; set; }
        public string? LookUpSql { get; set; }
        public long? TableId { get; set; }
        public long? StepId { get; set; }
        [Required]
        public int? SortOrder { get; set; }
        public bool? Required { get; set; }
        public string? DefaultValue { get; set; }
        public bool? IsReadOnly { get; set; }
        public int? MaxLength { get; set; }
    }
}