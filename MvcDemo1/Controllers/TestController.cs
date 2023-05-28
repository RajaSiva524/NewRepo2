using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo1.Models;

namespace MvcDemo1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<EmployeeModel> emp = new List<EmployeeModel>();

            EmployeeModel emp1 = new EmployeeModel();

            emp1.EmpId = 1;
            emp1.EmpName = "Suresh";
            emp1.Salary = 30000;

            EmployeeModel emp2 = new EmployeeModel();

            emp2.EmpId = 2;
            emp2.EmpName = "Naresh";
            emp2.Salary = 40000;

            emp.Add(emp1);
            emp.Add(emp2);

            return View(emp);
        }
    }
}