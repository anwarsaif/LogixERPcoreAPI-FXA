using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{
    public class SysPropertyValueFilterDto
    {
        public long? Id { get; set; }
        public long? PropertyCode { get; set; }
        public string? PropertyName { get; set; }
        public string? PropertyValue { get; set; }
        public int? SystemId { get; set; }
        public string? SystemName { get; set; }
        public string? SystemName2 { get; set; }
        public string? Description { get; set; }

        public long? ClassificationsId { get; set; }
        public long? PropertyId { get; set; }
        public bool IsRequired { get; set; }
        public bool IsEmptyValue { get; set; }
    }

    public class SysPropertyValueDto
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("Facility_ID")]
        public long? FacilityId { get; set; }
        [Column("Property_ID")]
        public long? PropertyId { get; set; }
        [Column("Property_Value")]
        public string? PropertyValue { get; set; }
    }
}
