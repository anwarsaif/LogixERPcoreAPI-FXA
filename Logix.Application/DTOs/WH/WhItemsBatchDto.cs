using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
	public partial class WhItemsBatchDto
	{
		public long Id { get; set; }
		[StringLength(2500)]
		public string? BatchNo { get; set; }
		[StringLength(10)]
		public string? ExpiryDate { get; set; }
		public string? BatchDescription { get; set; }
		//public long? ItemId { get; set; }
		public string? ItemCode { get; set; }
		public string? ItemName { get; set; }
		public bool? IsDeleted { get; set; }
	}

	public partial class WhItemsBatchEditDto
	{
		public long Id { get; set; }
		[StringLength(2500)]
		public string? BatchNo { get; set; }
		[StringLength(10)]
		public string? ExpiryDate { get; set; }
		public string? BatchDescription { get; set; }
		public long? ItemId { get; set; }
		public string? ItemCode { get; set; }
		public string? ItemName { get; set; }
	}
	public partial class WhItemsBatchFilterDto
	{
		[StringLength(2500)]
		public string? BatchNo { get; set; }
		[StringLength(10)]
		public string? ExpiryDate { get; set; }
		public string? StartDate { get; set; }
		public string? EndDate { get; set; }
		[StringLength(2500)]
		public string? ItemName { get; set; }
		[StringLength(250)]
		public string? ItemCode { get; set; }
	}

}
