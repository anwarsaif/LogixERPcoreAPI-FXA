using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{
    public partial class SysFavMenuDto
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public long? UserId { get; set; }
        public int? SortNo { get; set; }
    }
}