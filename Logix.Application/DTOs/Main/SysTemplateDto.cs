using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysTemplateFilterDto
    {
        public string? Name { get; set; }
        public int? SystemId { get; set; }
        public long? ScreenId { get; set; }
    }

    public class SysTemplateDto
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        //Detailes is required only if the TypeId=1 (means text).
        [Column("DETAILES", TypeName = "ntext")]
        public string? Detailes { get; set; }

        public long? ScreenId { get; set; }

        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }

        [Range(1, long.MaxValue)]
        public int? SystemId { get; set; }

        //public IFormFile? FileUploaded { get; set; }
        public string? Url { get; set; }

        //public long? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class SysTemplateEditDto
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public string? Detailes { get; set; }

        public long? ScreenId { get; set; }

        [Range(1, long.MaxValue)]
        public int? TypeId { get; set; }

        [Range(1, long.MaxValue)]
        public int? SystemId { get; set; }

        public string? Url { get; set; }

        //public IFormFile? FileUploaded { get; set; }
        //public long? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
    }

    public class SysTemplatePrintFilterDto
    {
        public string? EmpName { get; set; }
        public string EmpCode { get; set; } = null!;
        public long? TemplateId { get; set; }
    }
    //  يستخدم في طباعة النماذج في الموارد البشرية
    public class PrintTemplateDto
    {
        public string? LocationName2 { get; set; }
        public string? LocationName { get; set; }
        public string? DepName { get; set; }
        public string? NationalityName2 { get; set; }
        public string? NationalityName { get; set; }
        public string? CatName2 { get; set; }
        public string? CatName { get; set; }
        public string? EmpName2 { get; set; }
        public string? EmpName { get; set; }
        public string? IdNo { get; set; }
        public string? EmpCode { get; set; }
        //  public string? IdExpireDateG { get; set; }
        public string? IdExpireDate { get; set; }
        public long? EmpId { get; set; }
        public string? ContractExpiryDate { get; set; }
        public string? ContractDate { get; set; }
        public string? HomePhone { get; set; }
        public string? Mobile { get; set; }
        public string? POBox { get; set; }
        public string? PostalCode { get; set; }
        public string? Email { get; set; }
        public decimal? Salary { get; set; }
        public string? DOAppointment { get; set; }
        public string? CurrDate { get; set; }
        public decimal? Net { get; set; }
        public decimal? Total { get; set; }
        public string? TotalWrite { get; set; }
        public decimal? HousingAllowance { get; set; }
        public decimal? TransportAllowance { get; set; }
        public decimal? NatureAllowance { get; set; }
        public decimal? FoodsAllowance { get; set; }
        public decimal? RiskAllowance { get; set; }
        public decimal? CostOfLivingAllowance { get; set; }
        public decimal? FuelsAllowance { get; set; }
        public decimal? EndOfServiceAllowance { get; set; }
        public decimal? VacationAllowance { get; set; }
        public decimal? OtherAllowance1 { get; set; }
        public decimal? OthersAllowance { get; set; }
        public string? ShiftName { get; set; }
        public decimal? EndOfService { get; set; }
    }

}
