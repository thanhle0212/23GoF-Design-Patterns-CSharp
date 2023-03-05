using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSample
{
    public class Employee : ICloneable
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        private double Salary {get;set;}

        public Employee()
        {
            this.Salary = 50000;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDetails()
        {
            return $"First Name : {this.FirstName} - Last Name: {this.LastName} - Salary: {this.Salary}";
        }
    }
}