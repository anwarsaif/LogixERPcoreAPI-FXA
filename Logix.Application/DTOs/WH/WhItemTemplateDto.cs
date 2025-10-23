using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
	public partial class WhItemTemplateDto
	{
		public long Id { get; set; }
		public long? TId { get; set; }
		[StringLength(50)]
		public string? ItemCode { get; set; }
		[StringLength(50)]
		public string? ItemName { get; set; }
		[Column(TypeName = "decimal(18, 2)")]
		public decimal? Qty { get; set; }
		public int? UnitId { get; set; }
		[Column("Price_Rate", TypeName = "decimal(18, 2)")]
		public decimal? PriceRate { get; set; }
		[Column("Cost_Rate", TypeName = "decimal(18, 2)")]
		public decimal? CostRate { get; set; }
		public string? Note { get; set; }
		public bool? IsDeleted { get; set; }
		public int? CntPices { get; set; }
		[StringLength(50)]
		public string? NamePices { get; set; }
		public int? UnitPicesId { get; set; }
	}

	public partial class WhItemTemplateEditDto
	{
		public long Id { get; set; }
		public long? TId { get; set; }
		[StringLength(50)]
		public string? ItemCode { get; set; }
		[StringLength(50)]
		public string? ItemName { get; set; }
		[Column(TypeName = "decimal(18, 2)")]
		public decimal? Qty { get; set; }
		public int? UnitId { get; set; }
		[Column("Price_Rate", TypeName = "decimal(18, 2)")]
		public decimal? PriceRate { get; set; }
		[Column("Cost_Rate", TypeName = "decimal(18, 2)")]
		public decimal? CostRate { get; set; }
		public string? Note { get; set; }
		public int? CntPices { get; set; }
		[StringLength(50)]
		public string? NamePices { get; set; }
		public int? UnitPicesId { get; set; }
	}

	public partial class WhItemTemplateFilterDto
	{
		public long Id { get; set; }
		public long? TId { get; set; }
		[StringLength(50)]
		public string? ItemCode { get; set; }
		[StringLength(50)]
		public string? ItemName { get; set; }
		[Column(TypeName = "decimal(18, 2)")]
		public decimal? Qty { get; set; }
		public int? UnitId { get; set; }
		[Column("Price_Rate", TypeName = "decimal(18, 2)")]
		public decimal? PriceRate { get; set; }
		[Column("Cost_Rate", TypeName = "decimal(18, 2)")]
		public decimal? CostRate { get; set; }
		public string? Note { get; set; }
		public int? CntPices { get; set; }
		[StringLength(50)]
		public string? NamePices { get; set; }
		public int? UnitPicesId { get; set; }
	}

}
