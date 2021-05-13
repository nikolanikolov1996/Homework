using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01.Domain.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        void PrintUser()
        {
            Console.WriteLine($"User info: Id: {Id} Name: {Name} UserName: {UserName}");
        }
    }
}
