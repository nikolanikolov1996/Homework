using System;
using System.Collections.Generic;
using System.Text;
using AMAEntities.Enums;

namespace AMAEntities.Models
{
    public class Admin : User
    {
        // Admin constructor inheriting from : base User constructor
        public Admin(int id, string fname, string lname, string email, string password)
            : base(id, fname, lname, email, password, Role.Admin)
        {

        }
    }
}
