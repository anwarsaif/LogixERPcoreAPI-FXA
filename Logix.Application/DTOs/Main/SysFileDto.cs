using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{
    public partial class SysFileDto
    {
        public long Id { get; set; }
        public int? TableId { get; set; }
        public long? PrimaryKey { get; set; }
        public string? FileName { get; set; }
        public string? FileDescription { get; set; }
        public string? FileDate { get; set; }
        public int? FileType { get; set; }
        public string? SourceFile { get; set; }
        public string? FileUrl { get; set; }
        public string? FileExt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int? FacilityId { get; set; }
        public int IncreasId { get; set; }
        public int IsFormScreen { get; set; } = 0;
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }


    public class SaveFileDto
    {
        public long Id { get; set; }= 0;
        [Required]
        public string FileURL { get; set; } = null!;
        [Required]
        public string FileName { get; set; } = null!;
        public bool? IsDeleted { get; set; }= false;
        public string? FileDate{ get; set; } 
    }

    public class DeleteFileDto
    {
        public long Id { get; set; }
        [Required]
        public long? PrimaryKey { get; set; }
        public bool? IsDeleted { get; set; }= false;
        [Required]
        public int? TableId { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }

    public class SaveFileEditDto
    {
        [Required]
        public int? tableId { get; set; }
        [Required]
        public long? primaryKey { get; set; }
        [Required]
        public string? FileURL { get; set; }
        [Required]
        public string? FileName { get; set; }
        public int? FacilityId { get; set; }


    }
}
