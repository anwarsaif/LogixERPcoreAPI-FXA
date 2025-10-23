using System.ComponentModel.DataAnnotations;


namespace Logix.Application.DTOs.Main
{
    public class SysCurrencyDto
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Name2 { get; set; }
        [Required]
        public string SubunitName { get; set; }
        [Required]
        public string SubunitName2 { get; set; }
        public int? DecimalPoint { get; set; }
        public string? Symbol { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class SysCurrencyFilterDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
}

public class SysCurrencyEditDto
{
    public int Id { get; set; }
    [Required]
    public string Code { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Name2 { get; set; }
    [Required]
    public string SubunitName { get; set; }
    [Required]
    public string SubunitName2 { get; set; }
    public int? DecimalPoint { get; set; }
    public string? Symbol { get; set; }
}