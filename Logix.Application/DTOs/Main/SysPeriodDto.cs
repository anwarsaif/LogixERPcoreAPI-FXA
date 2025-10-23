using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
	public partial class SysPeriodDto
	{
		public long Id { get; set; }
		[Required]
		[StringLength(50)]
		public string StartDate { get; set; } = "";
        [Required]
        [StringLength(50)]
		public string EndDate { get; set; } = "";

        public long SystemId { get; set; }

		public long FacilityId { get; set; }

		public bool? IsActive { get; set; }
		public bool IsDeleted { get; set; }
	}

	public partial class SysPeriodEditDto
	{
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string StartDate { get; set; } = "";
        [Required]
        [StringLength(50)]
        public string EndDate { get; set; } = "";

        public long SystemId { get; set; }

        public long FacilityId { get; set; }

        public bool? IsActive { get; set; }
    }
}
