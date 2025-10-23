namespace Logix.Application.DTOs.WF
{
    public  class WfDynamicValueDto
    {
        public Guid DynamicValueId { get; set; }
        public Guid? AttributeId { get; set; }
        public object? DynamicValue { get; set; }
        public long? AppTypeId { get; set; }
        public long? ApplicationId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long Id { get; set; }
    }

    public  class WfDynamicValueEditDto
    {
        public Guid DynamicValueId { get; set; }
        public Guid? AttributeId { get; set; }
        public object? DynamicValue { get; set; }
        public long? AppTypeId { get; set; }
        public long? ApplicationId { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long Id { get; set; }
    }
}
