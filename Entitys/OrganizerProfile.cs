using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entitys
{
    public class OrganizerProfile
    {
        [Key]
        public int OrganizerId { get; set; }

        public string Bio { get; set; }
        public string Website { get; set; }
        public string LogoUrl { get; set; }

        public Organizer Organizer { get; set; }//1-1 relationship with Organizer
    }
}
