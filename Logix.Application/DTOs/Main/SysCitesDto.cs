using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public class SysCitesDto
    {
        public long CityID { get; set; }
        public string? CityName { get; set; }
        public string? Code { get; set; }
        public int? CountryID { get; set; }
        public long? ParentID { get; set; }
        public long? TypeID { get; set; }
        public string? CityName2 { get; set; }
        //public long? CreatedBy { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime? CreatedOn { get; set; }
        //public long? ModifiedBy { get; set; }
        //[Column(TypeName = "datetime")]
        //public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class SysCitesEditDto
    {
        public long CityID { get; set; }
        public string? CityName { get; set; }
        public string? Code { get; set; }
        public int? CountryID { get; set; }
        public int? ParentID { get; set; }
        public long? TypeID { get; set; }
        public string? CityName2 { get; set; }
    }
}
