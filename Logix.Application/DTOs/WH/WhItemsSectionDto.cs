using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
	public partial class WhItemsSectionDto
	{
		public long Id { get; set; }
		public long? InventoryId { get; set; }
		public long? SectionId { get; set; }
		public long? ItemId { get; set; }
		public string? ItemCode { get; set; }
		public bool? IsDeleted { get; set; }
	}

	public partial class WhItemsSectionEditDto
	{
		public long Id { get; set; }
		public long? InventoryId { get; set; }
		public long? SectionId { get; set; }
		public long? ItemId { get; set; }
		public string? ItemCode { get; set; }
	}

	public partial class WhItemsSectionFilterDto
	{
		public long? Id { get; set; }
		public long? InventoryId { get; set; }
		public long? SectionId { get; set; }
		public long? ItemId { get; set; }
		public bool? IsDeleted { get; set; }
	}
}
