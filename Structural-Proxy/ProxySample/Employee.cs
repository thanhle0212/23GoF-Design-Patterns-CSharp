using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxySample
{
    public class Employee
    {
        public string UserName {get;set;}
        public string Password {get;set;}
        public string Role {get;set;}

        public Employee(string userName, string password, string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}