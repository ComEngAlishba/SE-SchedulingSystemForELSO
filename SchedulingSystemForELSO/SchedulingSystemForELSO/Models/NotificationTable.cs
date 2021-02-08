using System;
using System.Collections.Generic;

namespace SchedulingSystemForELSO.Models
{
    public partial class NotificationTable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string NotiMessage { get; set; }
        public string CurrentDate { get; set; }
    }
}
