using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PUR
{
    public class PurTransactionsTypeDto
    {
        public long? Id { get; set; }
        public string? TransactionType { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public long? ScreenId { get; set; }
        public int? ParentId { get; set; }
    }
    public class PurTransactionsTypeEditDto
    {
        public long Id { get; set; }
        public string? TransactionType { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public long? ScreenId { get; set; }
        public int? ParentId { get; set; }
    }
}
