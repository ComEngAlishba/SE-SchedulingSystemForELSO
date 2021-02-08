using System;
using System.Collections.Generic;

namespace SchedulingSystemForELSO.Models
{
    public partial class BookMeetingTable
    {
        public int Id { get; set; }
        public int? MeetingId { get; set; }
        public string StudentUsername { get; set; }
        public bool? Request { get; set; }
        public string StudentEmail { get; set; }
        public string StudentRegisteration { get; set; }
    }
}
