using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrintPDF_Rotativa.Models;
using Rotativa;

namespace PrintPDF_Rotativa.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeEntity _empContext;
        public EmployeeController()
        {
            _empContext = new Models.EmployeeEntity();
        }
        public ActionResult Index()
        {
            var emps = _empContext.T_Employee.ToList();
            return View(emps);
        }
        public ActionResult PrintAllReport()
        {
            var report = new ActionAsPdf("Index");
            return report;
        }
        public ActionResult IndexById(int id)
        {
            var emp = _empContext.T_Employee.Where(e => e.empId == id).First();
            return View(emp);
        }
        public ActionResult PrintSalarySlip(int id)
        {
            var report = new ActionAsPdf("IndexById", new { id = id });
            return report;
        }
    }
}