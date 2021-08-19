using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustLeave.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDateLeave { get; set; }
        public DateTime EndDateLeave { get; set; }
        public int Day { get; set; }
        public string Reason { get; set; }


    }
}
