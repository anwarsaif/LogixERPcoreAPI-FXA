using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.OPM
{
    public class OpmTransactionsLocationDto
    {
        public long Id { get; set; }
        public int IncreasId { get; set; }
        public long? TransactionId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]
        public int? LocationId { get; set; }
        //[Range(1, long.MaxValue)]
        public long? CityId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "*")]
        [Required(ErrorMessage = "*")]

        public int? Qty { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(250)]
        public string? ContactPerson { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [StringLength(250)]
        public string? Latitude { get; set; }
        [StringLength(250)]
        public string? Longitude { get; set; }
        public string? CityName { get; set; }
        public string? LocationName { get; set; }
    }

    public class OpmTransactionsLocationEditDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public long? LocationId { get; set; }
        public int? Qty { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
