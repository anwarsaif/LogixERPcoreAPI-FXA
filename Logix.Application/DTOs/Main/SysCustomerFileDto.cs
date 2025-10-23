using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Logix.Domain.Base;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{
    public class SysCustomerFileDto
    {
        public long Id { get; set; }


        public long? CustomerId { get; set; }
 
        [StringLength(50)]
        public string? ProjectCode { get; set; }
  
        [StringLength(50)]
        public string? FileName { get; set; }

        [StringLength(4000)]
        public string? FileDescription { get; set; }
    
        [StringLength(10)]
        public string? FileDate { get; set; }

        public int? FileType { get; set; }
   
        [StringLength(500)]
        public string? SourceFile { get; set; }

        public string? FileUrl { get; set; }

        [StringLength(50)]
        public string? FileExt { get; set; }
        public bool? IsDeleted { get; set; }


        public int IncreasId { get; set; } // temp id to manage tempFile before save to database
    }
    public class GetAllSysCustomerFileTypesDto
    {
        //public long Id { get; set; }
        public long? FileType { get; set; }
        public string? FileTypeName { get; set; }
        public string? FileTypeName2 { get; set; }
        public string? FileName { get; set; }
        public DateTime? Date { get; set; }
    }
}
