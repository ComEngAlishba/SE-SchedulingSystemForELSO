using System;
using System.Collections.Generic;

namespace SchedulingSystemForELSO.Models
{
    public partial class RegisterTable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserChoice { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string DepName { get; set; }
        public string RegNo { get; set; }
        public string Country { get; set; }
    }
}
