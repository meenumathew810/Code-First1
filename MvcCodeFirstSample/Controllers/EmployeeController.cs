using MvcCodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCodeFirstSample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            EmployeeDbContext DbContext = new EmployeeDbContext();
            DbContext.employee.Add(employee);
            DbContext.SaveChanges();
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Details(int Id)
        {
            EmployeeDbContext DbContext = new EmployeeDbContext();

            return View(DbContext.employee.ToList());
            
        }
        public ActionResult Edit(int Id)
        {
            EmployeeDbContext DbContext = new EmployeeDbContext();
            //Employee employee = DbContext.Employees.Where(c => c.EmpId == Id).FirstOrDefault();
            Employee employee = new Employee();
            employee = DbContext.employee.Find(Id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            EmployeeDbContext DbContext = new EmployeeDbContext();
            var emp = (from c in DbContext.employee where c.Id == employee.Id select c).FirstOrDefault();
            emp.Name = employee.Name;
            DbContext.SaveChanges();
            return RedirectToAction("Details", "Employee");
        }
    }
}