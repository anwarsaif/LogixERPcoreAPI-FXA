using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WH
{
	public partial class WhTemplateDto
	{
		public long Id { get; set; }
		public long? Code { get; set; }
		[StringLength(50)]
		public string? Name { get; set; }
		public long? CatId { get; set; }
		public long? FacilityId { get; set; }
		public bool? IsDeleted { get; set; }
	}

	public partial class WhTemplateEditDto
	{
		public long Id { get; set; }
		public long? Code { get; set; }
		[StringLength(50)]
		public string? Name { get; set; }
		public long? CatId { get; set; }
		public long? FacilityId { get; set; }
		public bool? IsDeleted { get; set; }
	}

	public partial class WhTemplateFilterDto
	{
		public long? Code { get; set; }
		[StringLength(50)]
		public string? Name { get; set; }
		public long? CatId { get; set; }
	}

}
