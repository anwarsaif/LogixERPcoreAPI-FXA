using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Integra
{
    public partial class IntegraTableValueFilterDto
    {
        public long? TableId { get; set; }
        public string? FieldValue { get; set; }
        public string? FieldReference { get; set; }
        public long? IntegraSytstemId { get; set; }
    }
    public partial class IntegraTableValueDto
    {
        public long? Id { get; set; }
        public long? Code { get; set; }
        public long? TableId { get; set; }
        public long? FieldId { get; set; }
        public string? FieldValue { get; set; }
        public string? FieldReference { get; set; }
        public long? IntegraSytstemId { get; set; }
        public long? FacilityId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public partial class IntegraTableValueEditDto
    {
        public long Id { get; set; }
        public long? Code { get; set; }
        public long? TableId { get; set; }
        public long? FieldId { get; set; }
        public string? FieldValue { get; set; }
        public string? FieldReference { get; set; }
        public long? IntegraSytstemId { get; set; }
        public long? FacilityId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
