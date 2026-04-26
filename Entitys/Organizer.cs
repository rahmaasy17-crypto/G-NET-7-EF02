using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entitys
{
    // Using Data Annotations
    public class Organizer
    {
        public int Id { get; set; }//PK

        [Required] 
        public string Name { get; set; }

        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public OrganizerProfile Profile { get; set; }//1-1 relationship with OrganizerProfile

    }
}
