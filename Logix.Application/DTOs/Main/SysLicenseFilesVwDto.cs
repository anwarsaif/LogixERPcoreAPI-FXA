using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{

    public class SysLicenseFilesVwDto
    {

        public long? Id { get; set; }

        public long? LicenseId { get; set; }

        [StringLength(50)]
        public string? FileName { get; set; }

        [StringLength(4000)]
        public string? FileDescription { get; set; }

        [StringLength(10)]
        public string? FileDate { get; set; }

        public int? FileType { get; set; }

        [StringLength(500)]
        public string? SourceFile { get; set; }

        public string? FileUrl { get; set; }

        [StringLength(50)]
        public string? FileExt { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
