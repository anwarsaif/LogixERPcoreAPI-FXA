using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysNotificationsMangFilterDto
    {
        public string? Name { get; set; }
    }

    public class SysNotificationsMangDto
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string? Name { get; set; }

        [Column("User_ID")]
        [StringLength(250)]
        public string? UserId { get; set; }

        [Column("Table_ID")]
        public long? TableId { get; set; }

        [Column("Select_Field_ID")]
        public long? SelectFieldId { get; set; }

        public long? ConditionFieldId { get; set; }

        [StringLength(2000)]
        public string? ConditionOthers { get; set; }

        public long? AheadOf { get; set; }
        public int? AssigneeTypeId { get; set; }
        public string? GroupId { get; set; }

        public bool? IsDeleted { get; set; }
    }

    public class SysNotificationsMangEditDto
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string? Name { get; set; }

        [Column("User_ID")]
        [StringLength(250)]
        public string? UserId { get; set; }

        [Column("Table_ID")]
        public long? TableId { get; set; }

        [Column("Select_Field_ID")]
        public long? SelectFieldId { get; set; }

        public long? ConditionFieldId { get; set; }

        [StringLength(2000)]
        public string? ConditionOthers { get; set; }

        public long? AheadOf { get; set; }
        public int? AssigneeTypeId { get; set; }
        public string? GroupId { get; set; }
    }

    public class SysNotificationsMangResultDto
    {
        public string? Name { get; set; }
        public string? SelectFieldName { get; set; }
        public string? ConditionFieldName { get; set; }
    }

}
