using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entitys
{
    public class Badge
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public DateTime IssuedAt { get; set; }

        public string Tier { get; set; } 

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }//1-1 relationship with Attendee
    }
}
