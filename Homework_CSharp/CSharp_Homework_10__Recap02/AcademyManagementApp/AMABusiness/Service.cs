using AMABusiness.ServiceModels;
using AMABusiness.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AMABusiness
{
    public class Service
    {
        // Start App
        public static void StartApp()
        {
            LoggedUser loggedUser = UserService.Login();
            UserService.MenuOption(loggedUser);
        }
    }
}
