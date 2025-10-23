namespace Logix.Application.DTOs.HOT
{
    public class HotRoomServiceDto
    {

        public long Id { get; set; }

        public long? RoomId { get; set; }

        public long? ServicesId { get; set; }

        public decimal? Amount { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }
    }
    public class HotRoomServiceEditDto
    {
        public long Id { get; set; }

        public long? RoomId { get; set; }

        public long? ServicesId { get; set; }

        public decimal? Amount { get; set; }


        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
