namespace Logix.Application.DTOs.RPT
{
    public class RptFieldFilterDto
    {
        public int? SystemId { get; set; }
        public long? TableId { get; set; }
        public long? FieldId { get; set; }
    }

    public class RptFieldDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public string? FiledName { get; set; }
        public long? TableId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
