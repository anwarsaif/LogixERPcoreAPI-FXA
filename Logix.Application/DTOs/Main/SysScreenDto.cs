using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logix.Application.DTOs.Main
{
    public class SysScreenFilterDto
    {
        public long? ScreenId { get; set; }
        public int? SystemId { get; set; }
        public string? ScreenName { get; set; }
        public string? ScreenName2 { get; set; }
        public string? SystemName { get; set; }
        public string? SystemName2 { get; set; }
    }

    public class SysScreenDto
    {
        public long? ScreenId { get; set; }

        [StringLength(50)]
        public string? ScreenName { get; set; }

        [StringLength(50)]
        public string? ScreenName2 { get; set; }

        public bool? Isdel { get; set; }

        public int? SystemId { get; set; }

        public int? ParentId { get; set; }

        public int? SortNo { get; set; }

        public string? ScreenUrl { get; set; }

        [StringLength(50)]
        public string? IconCss { get; set; }

        [StringLength(2500)]
        public string? ColorCss { get; set; }

        //================== added by najmaldeen, Url => to save the controller and action name of the screen
        public string? Url { get; set; }
    }
}
