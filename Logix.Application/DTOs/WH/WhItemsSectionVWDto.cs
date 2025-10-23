using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
	public partial class WhItemsSectionVWDto
	{
		public long? InventoryId { get; set; }
		public string? ItemCode { get; set; }
		[StringLength(2500)]
		public string? ItemName { get; set; }
		[StringLength(250)]
		public string? SectionName { get; set; }
	}

}
