using Logix.Application.Common;

namespace Logix.Application.DTOs.Main
{
    public partial class SysLibraryFileDto
    {
        public long? Id { get; set; }
        public string? RefranceCode { get; set; }
        public string? FileName { get; set; }
        public string? FileDescription { get; set; }
        public string? FileDate { get; set; }
        public int? FileType { get; set; }
        public string? SourceFile { get; set; }
        public string? FileUrl { get; set; }
        public string? FileExt { get; set; }
        public bool? IsDeleted { get; set; }
        public string? EndDateFile { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
    }
    public partial class SysLibraryFileEditDto
    {
        public long Id { get; set; }
        public string? RefranceCode { get; set; }
        public string? FileName { get; set; }
        public string? FileDescription { get; set; }
        public string? FileDate { get; set; }
        public int? FileType { get; set; }
        public string? SourceFile { get; set; }
        public string? FileUrl { get; set; }
        public string? FileExt { get; set; }
        public string? EndDateFile { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }

    }

    public class SysLibraryFileFilterDto
    {
        public int? Type { get; set; }
        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? SourceFile { get; set; }
        public string? FileDescription { get; set; }
        public string? FileName { get; set; }


    }
}
