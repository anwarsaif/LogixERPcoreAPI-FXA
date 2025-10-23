namespace Logix.Application.DTOs.HOT
{
    public class HotRoomDto
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public long? BranchId { get; set; }


        public long? FloorId { get; set; }

      public long? TypeRoom { get; set; }

        public int? BedNumber { get; set; }

        public decimal? Amount { get; set; }

        public string? Note { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public long? StatusId { get; set; }
        public long? GroupId { get; set; }

        public long? Code { get; set; }

        public bool? VatEnable { get; set; }

        public long? VatId { get; set; }

        public long? FacilityId { get; set; }
    }
    public class HotRoomEditDto
    {

        public long Id { get; set; }

        public string? Name { get; set; }



        public long? FloorId { get; set; }
        public long? TypeRoom { get; set; }

        public int? BedNumber { get; set; }

        public decimal? Amount { get; set; }

        public string? Note { get; set; }


        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public long? StatusId { get; set; }
        public long? GroupId { get; set; }

        public long? Code { get; set; }

        public bool? VatEnable { get; set; }

        public long? VatId { get; set; }

    }
}
