using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.TS
{
    public partial class TsAppointmentVwDto
    {
        public long AppId { get; set; }
        public string? AppDetails { get; set; }
        public string? AppStartDate { get; set; }
        public string? AppStartTime { get; set; }
        public string? AppEndDate { get; set; }
        public string? AppEndTime { get; set; }
        public long? UserId { get; set; }
        public string? AppDate { get; set; }
        public string? TicketType { get; set; }
        public bool? IsDeleted { get; set; }
        public string? UserFullname { get; set; }
        public long? ManagerId { get; set; }
        public bool? AllDay { get; set; }
        public string? AppStartDateAh { get; set; }
        public string? AppEndDateAh { get; set; }
        public long? FacilityId { get; set; }
    }
}
