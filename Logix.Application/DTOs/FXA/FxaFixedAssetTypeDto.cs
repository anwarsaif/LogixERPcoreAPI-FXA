using System.ComponentModel.DataAnnotations;


namespace Logix.Application.DTOs.FXA
{
    public class FxaFixedAssetTypeFilterDto
    {
        public long Id { get; set; }
        [StringLength(250)]
        public string? TypeName { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        public decimal? DeprecYearlyRate { get; set; }
        public int? Age { get; set; }
        public long? ParentId { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountCode2 { get; set; }
        public string? AccountCode3 { get; set; }
    }

    public class FxaFixedAssetTypePopUpDto
    {
        public long? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? MainTypeName { get; set; }
    }

    public class FxaFixedAssetTypeDto
    {
        public long Id { get; set; }
        [Required]
        [StringLength(250)]
        public string? TypeName { get; set; }
        
        [Required]
        public decimal? DeprecYearlyRate { get; set; }
        public long? ParentId { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Note { get; set; }
        [Required]
        public int? Age { get; set; }
        [Required]
        [StringLength(50)]
        public string? Code { get; set; }

        //for accounts code
        [Required]
        public string? AccountCode { get; set; }
        [Required]
        public string? AccountCode2 { get; set; }
        [Required]
        public string? AccountCode3 { get; set; }
    }

    public class FxaFixedAssetTypeEditDto
    {
        public long Id { get; set; }
        [Required]
        [StringLength(250)]
        public string? TypeName { get; set; }

        [Required]
        public decimal? DeprecYearlyRate { get; set; }
       
        public long? ParentId { get; set; }
        public string? Note { get; set; }
        [Required]
        public int? Age { get; set; }
        [Required]
        [StringLength(50)]
        public string? Code { get; set; }

        //for accounts code and name
        [Required]
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        
        [Required]
        public string? AccountCode2 { get; set; }
        public string? AccountName2 { get; set; }

        [Required]
        public string? AccountCode3 { get; set; }
        public string? AccountName3 { get; set; }
    }
}