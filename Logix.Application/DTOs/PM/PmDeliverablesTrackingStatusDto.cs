namespace Logix.Application.DTOs.PM
{
    public class PmDeliverablesTrackingStatusDto
    {
        public long? Id { get; set; }
        public long? DeliverablesId { get; set; }
        public string? SDate { get; set; }
        public int? StatusId { get; set; }
        public string? Note { get; set; }

        public bool? IsDeleted { get; set; }
    }
    public class PmDeliverablesTrackingStatusEditDto
    {
        public long Id { get; set; }
        public long? DeliverablesId { get; set; }
        public string? SDate { get; set; }
        public int? StatusId { get; set; }
        public string? Note { get; set; }
    }
}
