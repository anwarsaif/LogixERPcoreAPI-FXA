using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{
    public class SysPropertyDto
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("Property_Code")]
        public long? PropertyCode { get; set; }
        [Column("Property_Name")]
        [StringLength(2500)]
        public string? PropertyName { get; set; }
        [Column("System_ID")]
        public int? SystemId { get; set; }
        [Column("Data_Type")]
        public int? DataType { get; set; }
        [Column("Lookup_Category_ID")]
        public int? LookupCategoryId { get; set; }
        public string? Description { get; set; }

        public long? ClassificationsId { get; set; }
        public bool? IsRequired { get; set; }
    }

    public class SysPropertyEditDto
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("Property_Code")]
        public long? PropertyCode { get; set; }
        [Column("Property_Name")]
        [StringLength(2500)]
        public string? PropertyName { get; set; }
        [Column("System_ID")]
        public int? SystemId { get; set; }
        [Column("Data_Type")]
        public int? DataType { get; set; }
        [Column("Lookup_Category_ID")]
        public int? LookupCategoryId { get; set; }
        public string? Description { get; set; }
    }
}
