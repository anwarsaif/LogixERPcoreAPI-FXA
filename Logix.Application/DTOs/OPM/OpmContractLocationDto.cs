
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class OpmContractLocationDto
    {
        public long Id { get; set; }
        public int IncreasId { get; set; }
        public long? ContractId { get; set; }
        [Range(1, long.MaxValue)]
        public int? LocationId { get; set; }
        [Range(1, long.MaxValue)]
        [Required]
        public int? Qty { get; set; }
        public long? CityId { get; set; }
        public long? CreatedBy { get; set; }
        
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(250)]
        public string? ContactPerson { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [StringLength(250)]
        public string? Latitude { get; set; }
        [StringLength(250)]
        public string? Longitude { get; set; }
        public string? CityName { get; set; }
        public string? LocationName { get; set; }
    }
    
    public class OpmContractLocationEditDto
    {
        public long Id { get; set; }
     
        public long? ContractId { get; set; }

        public int? LocationId { get; set; }
        [Range(1, long.MaxValue)]
        [Required]
        public int? Qty { get; set; }
        public long? CityId { get; set; }
        public long? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
        [StringLength(250)]
        public string? ContactPerson { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [StringLength(250)]
        public string? Latitude { get; set; }
        [StringLength(250)]
        public string? Longitude { get; set; }
        public string? CityName { get; set; }
        public string? LocationName { get; set; }
    }
}
