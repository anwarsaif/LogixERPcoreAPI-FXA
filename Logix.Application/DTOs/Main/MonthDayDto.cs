using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.Main
{
    public class MonthDayDto
    {
        [StringLength(2)]
        public string? DayCode { get; set; }
    }
}
