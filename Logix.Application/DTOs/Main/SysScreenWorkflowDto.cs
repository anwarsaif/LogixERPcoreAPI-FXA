using Logix.Application.Common;

namespace Logix.Application.DTOs.Main
{
    public class DynamicAttributeDto
    {
        public Guid DynamicAttributeId { get; set; }
        public DataTypeIdEnum DataTypeId { get; set; }
        public string? AttributeName { get; set; }
        public bool? Required { get; set; }
        public int? LookUpCatagoriesId { get; set; }
        public int? SysLookUpCatagoriesId { get; set; }
        public string? LookUpSql { get; set; }
        public int? LookUpType { get; set; }
        public long? TableId { get; set; }
        public string? DefaultValue { get; set; }
        public bool? IsReadOnly { get; set; }
        public string? LayoutSpan { get; set; }
        public int? UserControlID { get; set; }
        public string? UserControlPath { get; set; }
    }
    public class DynamicAttributeValueDto
    {
        public Guid DynamicAttributeId { get; set; }
        public DataTypeIdEnum DataTypeId { get; set; }
        public string? AttributeName { get; set; }
        public bool? Required { get; set; }
        public int? LookUpCatagoriesId { get; set; }
        public int? SysLookUpCatagoriesId { get; set; }
        public string? LookUpSql { get; set; }
        public int? LookUpType { get; set; }
        public long? TableId { get; set; }
        public string? DefaultValue { get; set; }
        public bool? IsReadOnly { get; set; }
        public string? LayoutSpan { get; set; }
        public int? UserControlID { get; set; }
        public string? UserControlPath { get; set; }
        public object? AttributeValue { get; set; }
        public int? SortOrder { get; set; }
    }
    public class SysScreenWorkflowDto
    {


        public long Id { get; set; }
        public string? Description { get; set; }

        public long? WorkflowId { get; set; }

        public long? ScreenId { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
