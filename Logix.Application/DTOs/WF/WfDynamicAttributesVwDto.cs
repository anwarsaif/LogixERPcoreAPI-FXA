using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.WF
{
    public class WfDynamicAttributesVwDto
    {

        public long Id { get; set; }
        public Guid DynamicAttributeId { get; set; }
        [StringLength(50)]
        public string? DataTypeName { get; set; }
        public int? DataTypeId { get; set; }
        [StringLength(2000)]
        public string? AttributeName { get; set; }
        public int? SortOrder { get; set; }
        public bool? Required { get; set; }
        public int? LookUpCatagoriesId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public long? AppTypeId { get; set; }
      
        public long? StepId { get; set; }
        public int? MaxLength { get; set; }
       
        public string? DefaultValue { get; set; }
        [StringLength(2000)]
        public string? AttributeName2 { get; set; }
   
        public long? TableId { get; set; }
    
        public int? LookUpType { get; set; }
      
        public int? SysLookUpCatagoriesId { get; set; }
     
        public string? LookUpSql { get; set; }
        public bool? IsReadOnly { get; set; }
    }
}
