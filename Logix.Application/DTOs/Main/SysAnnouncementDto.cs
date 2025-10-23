
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Logix.Application.DTOs.Main
{
    public class SysAnnouncementFilterDto
    {
        public bool? IsActive { get; set; }
        public string? Subject { get; set; }
        public int? Type { get; set; }
        public int? LocationId { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public long? BranchId { get; set; }
        public int? DeptLocationId { get; set; }
        public int? DeptId { get; set; }
    }

    public class SysAnnouncementDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        public int? Type { get; set; }
        [Required]
        public string? Subject { get; set; }
        public string? Detailes { get; set; }
        public string? AttachFile { get; set; }
        
        public bool IsDeleted { get; set; } = false;
        public bool? IsActive { get; set; }
        
        public int? LocationId { get; set; }
        public int? Language { get; set; }
        //[CustomDateRequired]
        [Required]
        [StringLength(10)]
        public string? StartDate { get; set; }
        
        [Required]
        [StringLength(10)]
        public string? EndDate { get; set; }
        
        public long? BranchId { get; set; }
        
        public int? DeptId { get; set; }
        
        public int? DeptLocationId { get; set; }
        //public long? FacilityId { get; set; }
     
        //[SkipDefaultDecimalValidation]
        //[RegularExpression(@"^[-+]?[0-9]*\.?[0-9]+$", ErrorMessage = "The value '{0}' is not valid for this credit.")]
        //[ModelBinder(typeof(CustomDecimalModelBinder))]
        //[ValidateNever]
        //[DataType(DataType.Text)]
        //private decimal _credit { get; set; }   

        /*public string Credit { get { return _credit.ToString(); } 
            set{
                _credit = decimal.Parse(value, CultureInfo.CurrentCulture );
                Credit = value;
            }
            }*/
        //[RegularExpression(@"^-?\d+(\.\d+)?$", ErrorMessage = "Invalid decimal value")]

        //[CustomDisplay("Amount", "Acc")]
        //[Required]
        //public decimal Credit { get; set; } //= string.Empty;

    }

    public class SysAnnouncementEditDto
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue)]
        public int? Type { get; set; }

        [Required]
        [StringLength(10)]
        public string? StartDate { get; set; }

        [Required]
        [StringLength(10)]
        public string? EndDate { get; set; }

        public long? BranchId { get; set; }
        [Required]
        public string? Subject { get; set; }

        public int? LocationId { get; set; }

        public int? DeptId { get; set; }

        public int? DeptLocationId { get; set; }

        public bool? IsActive { get; set; }

        public int? Language { get; set; }
        
        public string? Detailes { get; set; }

        public string? AttachFile { get; set; }
        //public bool IsDeleted { get; set; } = false;        
    }
}
