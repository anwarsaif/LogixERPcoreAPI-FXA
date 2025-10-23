namespace Logix.Application.DTOs.HOT
{
    public class HotRoomAssetDto
    {
        public long Id { get; set; }

        public long? RoomId { get; set; }

        public long? AssetsId { get; set; }


        public decimal? Qty { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Note { get; set; }
    }
    public class HotRoomAssetEditDto
    {
        public long Id { get; set; }

        public long? RoomId { get; set; }

        public long? AssetsId { get; set; }


        public decimal? Qty { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Note { get; set; }
    }
}
