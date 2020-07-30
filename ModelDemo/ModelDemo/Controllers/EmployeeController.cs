using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IList<Employee> empSummary = db.Employees.ToList();
            return View(empSummary);
        }

        public JsonResult detailasjson(string id)
        {
            Employee emp = new Employee();
            List<Employee> empLst = emp.GellAllEmployeeList();

            return Json(empLst.Where(e => e.employeeID == id).FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }
    }
}