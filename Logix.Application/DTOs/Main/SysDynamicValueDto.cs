namespace Logix.Application.DTOs.Main
{
    public class SysDynamicValueDto
    {
        public long Id { get; set; }
        public Guid DynamicValueId { get; set; }
        public Guid? AttributeId { get; set; }
        public object? DynamicValue { get; set; }
        public long? ScreenId { get; set; }
        public long? ApplicationId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public bool? IsDeleted { get; set; }
    } 
    public class SysDynamicValueEditDto
    {
        public long Id { get; set; }
        public Guid DynamicValueId { get; set; }
        public Guid? AttributeId { get; set; }
        public object? DynamicValue { get; set; }
        public long? ScreenId { get; set; }
        public long? ApplicationId { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
