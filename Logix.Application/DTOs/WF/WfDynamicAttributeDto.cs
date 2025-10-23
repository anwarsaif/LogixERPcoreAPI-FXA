using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logix.Application.Common;

namespace Logix.Application.DTOs.WF
{
    public class WfDynamicAttributeDto
    {
        public long Id { get; set; }
        //public Guid DynamicAttributeId { get; set; }
        [Required]
        public string? AttributeName { get; set; }
        [Required]
        [StringLength(2000)]
        public string? AttributeName2 { get; set; }
        [Range(1, int.MaxValue)]
        public int? DataTypeId { get; set; }
        public bool? Required { get; set; }
        public int? LookUpType { get; set; }
        public int? LookUpCatagoriesId { get; set; }
        public int? SysLookUpCatagoriesId { get; set; }
        public string? LookUpSql { get; set; }
        public long? TableId { get; set; }
        [Required]
        public int? SortOrder { get; set; }
        public string? DefaultValue { get; set; }
        public bool? IsReadOnly { get; set; }
        public int? MaxLength { get; set; }
        [Range(1, int.MaxValue)]
        public int? LayoutAttributeId { get; set; }
        public long? AppTypeId { get; set; }
        public long? StepId { get; set; }

        public bool IsDeleted { get; set; }
    }

    public class WfDynamicAttributeEditDto
    {
        public long Id { get; set; }
        public Guid DynamicAttributeId { get; set; }
        [Required]
        public string? AttributeName { get; set; }
        [Required]
        [StringLength(2000)]
        public string? AttributeName2 { get; set; }
        [Range(1, int.MaxValue)]
        public int? DataTypeId { get; set; }
        public bool? Required { get; set; }
        public int? LookUpType { get; set; }
        public int? LookUpCatagoriesId { get; set; }
        public int? SysLookUpCatagoriesId { get; set; }
        public string? LookUpSql { get; set; }
        public long? TableId { get; set; }
        [Required]
        public int? SortOrder { get; set; }
        public string? DefaultValue { get; set; }
        public bool? IsReadOnly { get; set; }
        public int? MaxLength { get; set; }
        [Range(1, int.MaxValue)]
        public int? LayoutAttributeId { get; set; }
        public long? AppTypeId { get; set; }
        public long? StepId { get; set; }
    }


    public class DynamicAttributeResult
    {
        public long? ID { get; set; }
        public Guid DynamicAttributeId { get; set; }
        public long? Screen_ID { get; set; }
        public DataTypeIdEnum DataTypeId { get; set; }
        public string? AttributeName { get; set; }
        public int? SortOrder { get; set; }
        public bool? Required { get; set; }
        public int? LookUp_Catagories_ID { get; set; }
        public object? DynamicValue { get; set; }
        public string? AttributeName2 { get; set; }
    }
}
