using AMAEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMABusiness.ServiceModels
{
    public class LoggedUser
    {
        public Admin Admin { get; set; }
        public Trainer Trainer { get; set; }
        public Student Student { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
