using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class ZatcaVatcategoriesReasonDto
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string CategoryName { get; set; } = null!;
        [StringLength(1)]
        public string CategoryCode { get; set; } = null!;
        public int? SysVatGroupId { get; set; }
        [StringLength(255)]
        public string? ReasonArabic { get; set; }
        [StringLength(255)]
        public string? ReasonEnglish { get; set; }
        public bool IsDeleted { get; set; }
    }
}
