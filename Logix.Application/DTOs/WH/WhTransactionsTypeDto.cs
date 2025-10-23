using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{

	public partial class WhTransactionsTypeDto
	{
		[Key]
		public long Id { get; set; }
		[StringLength(50)]
		public string? Description { get; set; }
		public int? TypeId { get; set; }
		public bool? IsDeleted { get; set; }
		public bool? GenreateTJounral { get; set; }
		public long? ScreenId { get; set; }
		public int? SortNo { get; set; }
	}
	public partial class WhTransactionsTypeEditDto
	{
		[Key]
		public long Id { get; set; }
		[StringLength(50)]
		public string? Description { get; set; }
		public int? TypeId { get; set; }
		public bool? GenreateTJounral { get; set; }
		public long? ScreenId { get; set; }
		public int? SortNo { get; set; }
	}
	public partial class WhTransactionsTypeFilterDto
	{
		public string? Description { get; set; }
		public int? TypeId { get; set; }
		public bool? IsDeleted { get; set; }
	}

}
