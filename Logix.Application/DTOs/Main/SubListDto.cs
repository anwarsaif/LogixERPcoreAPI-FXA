﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    [Keyless]
    public class SubListDto
    {
        public string? Icon_Css { get; set; }
        public long SCREEN_ID { get; set; }
        public string SCREEN_NAME { get; set; }
        public string SCREEN_NAME2 { get; set; }
        public bool? ISDEL { get; set; }
        public int? System_Id { get; set; }
        public int? Parent_Id { get; set; }
        public int ?Sort_no { get; set; }
        public string? SCREEN_URL { get; set; }
        public long PRIVE_ID { get; set; }
        public long? USER_ID { get; set; }
        public long  Expr1 { get; set; }
        public bool? SCREEN_SHOW { get; set; }
        public bool? SCREEN_ADD { get; set; }
        public bool? SCREEN_EDIT { get; set; }
        public bool? SCREEN_DELETE { get; set; }
        public bool? SCREEN_PRINT { get; set; }
        public int? GroupID { get; set; }
        public int Cnt { get; set; }
        public string? Folder { get; set; }

        //================== added by najmaldeen, Url => to save the controller and action name of the screen
        public string? URL { get; set; }
        public bool? IsCore { get; set; }
        public bool? IsAngular { get; set; }

    }
}
