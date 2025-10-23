using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmExtractTransactionsStatusDto
    {

        public int Id { get; set; }

        public string? StatusName { get; set; }
    
        public string? StatusName2 { get; set; }
    } 
    public class PmExtractTransactionsStatusEditDto
    {

        public int Id { get; set; }

        public string? StatusName { get; set; }
    
        public string? StatusName2 { get; set; }
    }
}
