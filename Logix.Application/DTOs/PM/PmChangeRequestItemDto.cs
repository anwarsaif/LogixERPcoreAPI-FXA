namespace Logix.Application.DTOs.PM
{
    public partial class PmChangeRequestItemDto
    {
        public long? Id { get; set; }
        public long? ChangeRequestId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public int? UnitId { get; set; }
        public long? PItId { get; set; }
        public decimal? PmQty { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public string? Note { get; set; }

        public bool? IsDeleted { get; set; }
        public decimal? Difference { get; set; }
    }

    public partial class PmChangeRequestItemEditDto
    {
        public long Id { get; set; }
        public long? ChangeRequestId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public int? UnitId { get; set; }
        public long? PItId { get; set; }
        public decimal? PmQty { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public string? Note { get; set; }

       // public bool? IsDeleted { get; set; }
        public decimal? Difference { get; set; }
    }
}
