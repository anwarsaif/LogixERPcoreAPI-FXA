using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.HOT
{
    public class HotTypeRoomDto
    {
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
    }

    public class HotTypeRoomEditDto
    {
        public long Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

    }
}
