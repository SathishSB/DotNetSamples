using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelDemo.Models
{
    public class Employee1
    {
        public int empId { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
        public String city { get; set; }
        public String state { get; set; }
    }

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

        public List<Employee> GellAllEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("mtsubas_e1", "Murtaza", "Mirza", "615-898-2323", 10, 90, true));
            employees.Add(new Employee("mtsubas_e2", "Ray", "Angie", "615-898-2323", 11, 80, true));
            employees.Add(new Employee("mtsubas_e3", "Burton", "James", "615-898-2323", 12, 70, false));
            employees.Add(new Employee("mtsubas_e4", "Bullard", "Dwight", "615-898-2323", 13, 60, true));
            employees.Add(new Employee("mtsubas_e5", "Apigian", "Charlie", "615-898-2323", 14, 50, true));
            employees.Add(new Employee("mtsubas_e6", "Lee", "Jung-Song", "615-898-2323", 15, 90, true));
            employees.Add(new Employee("mtsubas_e7", "Maier", "Lee", "615-898-2323", 16, 70, false));
            employees.Add(new Employee("mtsubas_e8", "Bamahnziari", "Tammy", "615-898-2323", 17, 60, true));
            employees.Add(new Employee("mtsubas_e9", "Greer", "Matt", "615-898-2323", 18, 50, true));
            employees.Add(new Employee("mtsubas_e10", "Coronnel", "Carlos", "615-898-2323", 19, 80, false));

            return employees;
        }
    }
}