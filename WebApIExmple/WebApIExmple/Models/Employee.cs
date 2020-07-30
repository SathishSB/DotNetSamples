using System;
using System.Collections.Generic;

namespace WebApIExmple.Models
{
    public class Employee
    {
        public string employeeID;
        public string employeeLastName;
        public string employeeFirstName;
        public string employeePhoneNumber;
        public double employeePayrate;
        public int employeeHours;
        public bool employeeFT;

        public Employee()
        {
        }

        public Employee(string eID, string eLastName, string eFirstName, string ePhone, double ePayrate, int eHours, bool eFT)
        {
            this.employeeID = eID;
            this.employeeLastName = eLastName;
            this.employeeFirstName = eFirstName;            
            this.employeePayrate = ePayrate;
            this.employeePhoneNumber = ePhone;
            this.employeeHours = eHours;
            this.employeeFT = eFT;
        }
    }
}