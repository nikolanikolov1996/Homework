using System;
using System.Collections.Generic;
using System.Text;
using AMAEntities.Enums;

namespace AMAEntities.Models
{
    public class User
    {
        public int Id { get; set; } // user id property
        public string FirstName { get; set; } // user firstname property
        public string LastName { get; set; }// user lastname property
        public string Email { get; set; }// user email property
        public string Password { get; set; }// user password property
        public Role Role { get; set; }

        // User constructor
        public User(int id, string fName, string lName, string email, string password, Role role)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Password = password;
            Role = role;
        }

        // Validate password
        public bool ValidatePassword(string password)
        {
            if (password != Password)
            {
                return false;
                throw new Exception("Not valid password");
            }

            return true;
        }
    }
}
