using System;
using System.Collections.Generic;

namespace SchedulingSystemForELSO.Models
{
    public partial class RescheduleDeleteTable
    {
        public int Id { get; set; }
        public int? MeetingId { get; set; }
        public string TeacherUsername { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string MeetingTopic { get; set; }
        public string Reason { get; set; }
        public string RescheduleDeleteChoice { get; set; }
    }
}
