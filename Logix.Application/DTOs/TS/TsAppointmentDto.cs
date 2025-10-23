using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.TS
{
    public partial class TsAppointmentFilterDto
    {
        public string? AppDetails { get; set; }
        public string? AppDate { get; set; }
        public long? UserId { get; set; }
    }
    public partial class TsAppointmentByUserFilterDto
    {
        public string? AppDetails { get; set; }
        public string? AppDate { get; set; }
    }
    public partial class TsAppointmentDto
    {
        public long? AppId { get; set; }
        public string? AppDetails { get; set; }
        public string? AppStartDate { get; set; }
        public string? AppStartTime { get; set; }
        public string? AppEndDate { get; set; }
        public string? AppEndTime { get; set; }
        public long? UserId { get; set; }
        public long? CalenderType { get; set; }
        public string? AppDate { get; set; }
        public string? TicketType { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? AllDay { get; set; }
        public string? AppStartDateAh { get; set; }
        public string? AppEndDateAh { get; set; }
    }
    public partial class TsAppointmentEditDto
    {
        public long AppId { get; set; }
        public string? AppDetails { get; set; }
        public string? AppStartDate { get; set; }
        public string? AppStartTime { get; set; }
        public string? AppEndDate { get; set; }
        public string? AppEndTime { get; set; }
        public long? UserId { get; set; }
        public string? AppDate { get; set; }
        //public string? TicketType { get; set; }
        //public bool? IsDeleted { get; set; }
        //public bool? AllDay { get; set; }
        public string? AppStartDateAh { get; set; }
        public string? AppEndDateAh { get; set; }
    }
    // يستخدم مع جدول المواعيد
    public class SaveEventDto
    {
        public string? TaskName { get; set; }
        public string? StartDate { get; set; }  // Consider using DateTime if possible
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? TicketType { get; set; }
        public bool? AllDay { get; set; } = false;  // Consider using a bool if it's a true/false value
        public string? UserId { get; set; }
    }
    
    public class UpdateTitleDto
    {
        public long Id { get; set; } // Int16 in VB.NET is short in C#
        public string? Title { get; set; }
        public string? Color { get; set; }
        public bool? AllDay { get; set; }  // Consider changing to bool if it's true/false
        public string? StartTime { get; set; } // Consider TimeSpan if it's a time value
        public string? EndTime { get; set; }   // Consider TimeSpan if it's a time value
        public string? UserId { get; set; }
    }

    public class EventResizableDto
    {
        public long Id { get; set; }  // Changed to long
        public string? StartDate { get; set; } // Consider DateTime if it's a date
        public string? EndDate { get; set; }   // Consider DateTime if it's a date
        public string? StartTime { get; set; } // Consider TimeSpan if it's a time
        public string? EndTime { get; set; }   // Consider TimeSpan if it's a time
    }


}
