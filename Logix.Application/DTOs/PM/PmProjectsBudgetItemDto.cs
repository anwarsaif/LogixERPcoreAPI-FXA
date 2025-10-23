namespace Logix.Application.DTOs.PM
{
    public class PmProjectsBudgetItemDto
    {
        public long? Id { get; set; }
        public long? ProjectId { get; set; }
        public long? PItemId { get; set; }
        public long? ItemId { get; set; }
        public long? UnitId { get; set; }
        public long? BudgTypeId { get; set; }
        public long? ProjBudgTypeId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Total { get; set; }
        public bool? IsDeleted { get; set; }
        public long? TransactionId { get; set; }
        public decimal? QtyIn { get; set; }
        public decimal? QtyOut { get; set; }
    }

    public class PmProjectsBudgetItemEditDto
    {
        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public long? PItemId { get; set; }
        public long? ItemId { get; set; }
        public long? UnitId { get; set; }
        public long? BudgTypeId { get; set; }
        public long? ProjBudgTypeId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Total { get; set; }
        public bool? IsDeleted { get; set; }
        public long? TransactionId { get; set; }
        public decimal? QtyIn { get; set; }
        public decimal? QtyOut { get; set; }
    }
}
