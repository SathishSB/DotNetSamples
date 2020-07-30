using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApIExmple.Models;

namespace WebApIExmple.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        [Route("GetEmpDetails")]
        public List<Employee> GetEmpDetailsTest()
        {
            List<Employee> employees = GellAllEmployeeList();

            return employees;
        }

        [Route("GetEmployeByID/{empID}")]
        public Employee GetEmployeByIDTest(string empID)
        {
            List<Employee> employees = GellAllEmployeeList();
            var emp = employees.FirstOrDefault(n => n.employeeID == empID);
            return emp;
        }

        [HttpPost]
        [Route("AddEmployee")]
        public List<Employee> AddEmployeeTest([FromUri] Employee emp)
        {
            List<Employee> employees = GellAllEmployeeList();
            employees.Add(emp);

            return employees;
        }

        private List<Employee> GellAllEmployeeList()
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
