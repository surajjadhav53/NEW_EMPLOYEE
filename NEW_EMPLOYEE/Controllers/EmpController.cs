using NEW_EMPLOYEE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NEW_EMPLOYEE.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee obj)
        {
            using (var ctx = new EMP_DBEntities())
            {
                tblEmployee Emp = new tblEmployee();
                Emp.Name = obj.Name;
                Emp.Address = obj.Address;
                Emp.MobileNo = obj.MobileNo;
                Emp.Email = obj.Email;
                Emp.JoiningDate = obj.JoiningDate;
                Emp.Password = obj.Password;
                ctx.tblEmployees.Add(Emp);
                ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult Index()
        {
            List<tblEmployee> Elist = new List<tblEmployee>();
            using (var ctx = new EMP_DBEntities())
            {
                Elist = ctx.tblEmployees.ToList();
                
            }
            return View(Elist);
        }
    }
}