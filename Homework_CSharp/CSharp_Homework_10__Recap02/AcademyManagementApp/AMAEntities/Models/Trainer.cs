using System;
using System.Collections.Generic;
using System.Text;
using AMAEntities.Enums;

namespace AMAEntities.Models
{
    public class Trainer : User
    {
        public List<Subject> Subjects { get; set; } // subjects List of subjects property

        // Trainer constructor inheriting from : base User constructor
        public Trainer(int id, string fName, string lName, string email, string password) 
            : base(id, fName, lName, email, password, Role.Trainer)
        {

        }
    }
}
