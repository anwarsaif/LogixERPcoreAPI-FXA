namespace Logix.Application.DTOs.HOT
{
    public class HotTransactionsCompanionDto
    {

        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public string? Name { get; set; }

        public long? IdType { get; set; }

        public string? IdNo { get; set; }

        public string? Mobile { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? RelationshipId { get; set; }

        public int? GenderId { get; set; }
    }
    public class HotTransactionsCompanionEditDto
    {

        public long Id { get; set; }

        public long? TransactionsId { get; set; }

        public string? Name { get; set; }

        public long? IdType { get; set; }

        public string? IdNo { get; set; }

        public string? Mobile { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? RelationshipId { get; set; }

        public int? GenderId { get; set; }
    }
}
