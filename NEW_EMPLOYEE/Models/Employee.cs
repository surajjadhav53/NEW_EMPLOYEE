using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NEW_EMPLOYEE.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Password { get; set; }
    }
}