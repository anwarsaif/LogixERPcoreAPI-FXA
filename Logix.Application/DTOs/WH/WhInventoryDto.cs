using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
    public class WhInventoryDto
    {
        public long? Id { get; set; }
        public string? InventoryName { get; set; }
        public string? Code { get; set; }
        public string? Phone { get; set; }
		public long? StorekeeperId { get; set; }
		public string? StorekeeperCode { get; set; }
        public string? StorekeeperName { get; set; }
        public int? BranchId { get; set; }
        public long? FacilityId { get; set; }
        public int? StatusId { get; set; }
        public string? Location { get; set; }
        public string? Note { get; set; }
        public bool IsDeleted { get; set; }
		public long? AccountId { get; set; }
		public string? AccountCode { get; set; }
        public string? BranchsId { get; set; }
        public string? UsersPermission { get; set; }
        public string? InventoryName2 { get; set; }
        public int? SortNo { get; set; }
    }
    public class WhInventoryEditDto
    {
        public long Id { get; set; }
        public string? InventoryName { get; set; }
        public string? Code { get; set; }
        public string? Phone { get; set; }
        public long? StorekeeperId { get; set; }
        public string? StorekeeperCode { get; set; }
        public string? StorekeeperName { get; set; }
        public int? BranchId { get; set; }
        public long? FacilityId { get; set; }
        public int? StatusId { get; set; }
        public string? Location { get; set; }
        public string? Note { get; set; }
        public long? AccountId { get; set; }
        public string? AccountCode { get; set; }
        public string? BranchsId { get; set; }
        public string? UsersPermission { get; set; }
        public string? InventoryName2 { get; set; }
        public int? SortNo { get; set; }
    }

    public class WhInventoryAddDto
    {
		public long? Id { get; set; }
		public string? InventoryName { get; set; }
		public string? Code { get; set; }
		public string? Phone { get; set; }
		public string? StorekeeperCode { get; set; }
		public string? StorekeeperName { get; set; }
		public int? BranchId { get; set; }
		public long? FacilityId { get; set; }
		public int? StatusId { get; set; }
		public string? Location { get; set; }
		public string? Note { get; set; }
		public bool IsDeleted { get; set; }
		public long? AccountId { get; set; }
		public string? BranchsId { get; set; }
		public string? UsersPermission { get; set; }
		public string? InventoryName2 { get; set; }
		public int? SortNo { get; set; }
	}


	public class WhInventorySearch
    {
		public long Id { get; set; }
		public string? InventoryName { get; set; }
		public string? Code { get; set; }
		public long? StorekeeperId { get; set; }
		public string? StorekeeperName { get; set; }
		public string? StorekeeperCode { get; set; }
		public int? BranchId { get; set; }
		public long FacilityId { get; set; }
		public string? Location { get; set; }
		public string? BranchsId { get; set; }
		public bool IsDeleted { get; set; }
	}
}
