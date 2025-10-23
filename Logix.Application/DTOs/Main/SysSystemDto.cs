using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysSystemDto
    {
        public int SystemId { get; set; }

        [StringLength(50)]
        public string? SystemName { get; set; }

        [StringLength(50)]
        public string? SystemName2 { get; set; }
        [StringLength(50)]
        public string? Folder { get; set; }

        public bool? Isdel { get; set; }

        public int? SysSort { get; set; }

        [StringLength(2500)]
        public string? Desc1 { get; set; }

        [StringLength(2500)]
        public string? Desc2 { get; set; }

        [StringLength(50)]
        public string? IconCss { get; set; }

        public bool? ShowInHome { get; set; }

        [StringLength(2500)]
        public string? ColorCss { get; set; }

        [StringLength(2500)]
        public string? DefaultPage { get; set; }

        [StringLength(50)]
        public string? ShortName { get; set; }

        [StringLength(50)]
        public string? ShortName2 { get; set; }

        //============== added by najmadeen for area, controller and view name 
        [StringLength(50)]
        public string? Controller { get; set; }


        [StringLength(50)]
        public string? Action { get; set; }

        [StringLength(50)]
        public string? Area { get; set; }
        public bool IsCore { get; set; }
        public bool? IsAngular { get; set; }


    }
}
