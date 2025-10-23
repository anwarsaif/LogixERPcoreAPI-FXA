using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysDynamicAttributeDto
    {
        public long? Id { get; set; }

        public Guid? DynamicAttributeId { get; set; }

        public long? ScreenId { get; set; }

        public int? DataTypeId { get; set; }

        [StringLength(2000)]
        public string? AttributeName { get; set; }

        public int? SortOrder { get; set; }

        public bool? Required { get; set; }

        public int? LookUpCatagoriesId { get; set; }

        public bool? IsDeleted { get; set; }

        public long? StepId { get; set; }

        public string? DefaultValue { get; set; }

        public int? MaxLength { get; set; }

        public long? TableId { get; set; }

        [StringLength(2000)]
        public string? AttributeName2 { get; set; }
    }

    public class SysDynamicAttributeEditDto
    {
        public long Id { get; set; }

        public Guid DynamicAttributeId { get; set; }

        public long? ScreenId { get; set; }

        public int? DataTypeId { get; set; }

        [StringLength(2000)]
        public string? AttributeName { get; set; }

        public int? SortOrder { get; set; }

        public bool? Required { get; set; }

        public int? LookUpCatagoriesId { get; set; }

        public long? StepId { get; set; }

        public string? DefaultValue { get; set; }

        public int? MaxLength { get; set; }

        public long? TableId { get; set; }

        [StringLength(2000)]
        public string? AttributeName2 { get; set; }
    }

    public class SysDynamicAttributeVM
    {
        public long ScreenId { get; set; }
        public string? ScreenName { get; set; }
        public string? ScreenName2 { get; set; }
        public int SystemId { get; set; }
        public SysDynamicAttributeDto SysDynamicAttributeDto { get; set; }

        public SysDynamicAttributeVM()
        {
            SysDynamicAttributeDto = new SysDynamicAttributeDto();
        }
    }
}
