using Homework01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01.Domain.AbstractClasses
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string userName, string password)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
        }

        public abstract void PrintUser();
    }
}
