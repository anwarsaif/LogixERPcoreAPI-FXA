using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM
{
    public class PmExtractTransactionsChangeStatusDto
    {
        public long Id { get; set; }

        public long? TransactionId { get; set; }

        [StringLength(10)]
        public string? DateChange { get; set; }

        public long? StatusId { get; set; }

        public string? Description { get; set; }

        [StringLength(10)]
        public string? DateRemind { get; set; }

        //when add comments (change status for rows of gridView) if row chkbx is selected we add for it
        public string? SelectedIds { get; set; }
    }
}