namespace Logix.Application.DTOs.WF
{
    public class WfStatusDto
    {
        public int Id { get; set; }
        public string? StatusName { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sort { get; set; }
        public string? StatusName2 { get; set; }
    }

    public class WfStatusEditDto
    {
        public int Id { get; set; }
        public string? StatusName { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? Sort { get; set; }
        public string? StatusName2 { get; set; }
    }
}
