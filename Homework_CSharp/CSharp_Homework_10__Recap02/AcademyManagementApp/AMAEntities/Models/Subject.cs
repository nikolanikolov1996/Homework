using System;
using System.Collections.Generic;
using System.Text;

namespace AMAEntities.Models
{
    public class Subject
    {
        public string Name { get; set; } // Subject 's name property
        public int NumberOfClasses { get; set; } // Number of classes property
        public bool IsOptional { get; set; } // IsOptional - boolean property
        public DateTime StartOn { get; set; } // DateTime StartsOn property
        public DateTime EndOn { get; set; } // DateTime EndOn property
        public List<string> StudentsAttending { get; set; } = new List<string>(); // How much students attending property
    }
}
