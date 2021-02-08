using System;
using System.Collections.Generic;

namespace SchedulingSystemForELSO.Models
{
    public partial class LoginTable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserChoice { get; set; }
    }
}
