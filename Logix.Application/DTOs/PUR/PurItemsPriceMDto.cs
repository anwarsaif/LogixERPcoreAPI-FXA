using Logix.Application.DTOs.SAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurItemsPriceMDto
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public long? FacilityId { get; set; }
        public long? BranchId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name2 { get; set; }
        public List<PurItemsPriceDDto> Details { get; set; }
    }
    public class PurItemsPriceMEditDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long? FacilityId { get; set; }
        public long? BranchId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name2 { get; set; }
        public List<PurItemsPriceDDto> Details { get; set; }
    }
    public class PurItemsPriceMFilterDto
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public long? FacilityId { get; set; }
        public long? BranchId { get; set; }
        public long? CatId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }

    }
}
