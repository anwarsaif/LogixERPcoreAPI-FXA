using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Logix.Application.DTOs.Main
{

    public class SysScreenPermissionPropertyDto
    {

        public long Id { get; set; }

        public long? PropertyId { get; set; }
        public bool? Allow { get; set; }
        public string? Value { get; set; }

        public long? UserId { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
