using System;
using System.Collections.Generic;
using System.Text;

namespace Task02.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User(int id, string userName, string passWord)
        {
            Id = id;
            Username = userName;
            Password = passWord;
            Messages = new string[] { "Message1", "Message2", "Message3", "Message4", };    
        }
    }


}
