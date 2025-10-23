using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class SysCustomerGroupAccountDto
    {
        public long Id { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public long GroupId { get; set; }
        [Range(1, int.MaxValue)]
        public int ReferenceTypeId { get; set; }
        [Required]
        public long? AccountId { get; set; }
        public bool? IsDeleted { get; set; } = false;

        //
        public string? AccAccountCode { get; set; }
        public string? AccAccountName { get; set; }

        // use in chk permission (1=>screenId 401, 2=>screenId 400, etc)
        public int? CusTypeId { get; set; }
    }
}
