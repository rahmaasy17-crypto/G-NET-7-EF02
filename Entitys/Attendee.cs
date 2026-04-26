using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entitys
{
    public class Attendee
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }

        public Address Address { get; set; }//1-1 relationship with Address

        public Badge Badge { get; set; }//1-1 relationship with Badge   

    }
}
