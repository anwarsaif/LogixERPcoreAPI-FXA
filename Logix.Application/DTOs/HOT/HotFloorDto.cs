
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.HOT
{
    public class HotFloorDto
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string? Code { get; set; }

        [StringLength(250)]
        public string? Name { get; set; }

        public int? NumberRoom { get; set; }

        public long? BranchId { get; set; }

        public string? Note { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public long? FacilityId { get; set; }
    }

    public class HotFloorEditDto
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string? Code { get; set; }

        [StringLength(250)]
        public string? Name { get; set; }

        public int? NumberRoom { get; set; }

        public long? BranchId { get; set; }

        public string? Note { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

    }

}
