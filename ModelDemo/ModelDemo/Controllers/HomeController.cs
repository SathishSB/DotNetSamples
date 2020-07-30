using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelDemo.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Http.HttpGet]
        public List<Employee> GetEmpDetailsTest()
        {
            List<Employee> employees = GellAllEmployeeList();
            return employees;
        }

        public ActionResult Details()
        {
            Employee1 employe = new Employee1()
            {
                empId = 1111111,
                fName = "Sathish",
                lName = "Swarna",
                city = "Hyderabad",
                state = "Telangan"
            };
            return View(employe);
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