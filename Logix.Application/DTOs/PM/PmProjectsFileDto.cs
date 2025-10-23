
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsFileAddDto
    {
        public long? Id { get; set; } = 0;

        public long? ProjectId { get; set; }
        [Required]
        [StringLength(50)]
        public string? FileName { get; set; }

        [StringLength(4000)]
        public string? FileDescription { get; set; }
        [StringLength(10)]
        public string? FileDate { get; set; }
        [Required]
        public int? FileType { get; set; }

        [StringLength(500)]
        public string? SourceFile { get; set; }
        [Required]
        public string? FileUrl { get; set; }
        public long? ParentId { get; set; }

        [StringLength(50)]
        public string? FileExt { get; set; }
        public bool? IsDeleted { get; set; }=false;
        //view 
        public string? FileTypeName { get; set; }

    }
    public class PmProjectsFileDto
    {

        public long Id { get; set; }

        public long? ProjectId { get; set; }

        [Required]
        [StringLength(50)]
        public string? FileName { get; set; }

        [StringLength(4000)]
        public string? FileDescription { get; set; }
     
        [StringLength(10)]
        public string? FileDate { get; set; }

        public int? FileType { get; set; }
        
        [StringLength(500)]
        public string? SourceFile { get; set; }
        [Required]
        public string? FileUrl { get; set; }

        [StringLength(50)]
        public string? FileExt { get; set; }
        public long? CreatedBy { get; set; }
     
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
     
        public long? TaskId { get; set; }

        public long? ParentId { get; set; }

        public int? CopyNo { get; set; }
        public string? FileRef { get; set; }
    }
    
    
    public class PmProjectsFileEditDto
    {
        public long Id { get; set; }

        public long? ProjectId { get; set; }

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

        public long? TaskId { get; set; }

        public long? ParentId { get; set; }

        public int? CopyNo { get; set; }
        public string? FileRef { get; set; }
    }
}
