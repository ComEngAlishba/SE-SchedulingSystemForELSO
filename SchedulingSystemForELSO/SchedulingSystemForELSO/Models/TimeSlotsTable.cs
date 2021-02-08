using System;
using System.Collections.Generic;

namespace SchedulingSystemForELSO.Models
{
    public partial class TimeSlotsTable
    {
        public int Id { get; set; }
        public string TeacherUsername { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string MeetingTopic { get; set; }
        public bool? Request { get; set; }
    }
}
