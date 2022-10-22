using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7_PostTightcoupledView.Models
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
    public class Departments
    {
        public string DepartName { get; set; }
        public string DepartHead { get; set; }
    }

    public class EmployeeInfo
    {
        public string Epmloyee { get; set; }
        public UserInfo User { get; set; }
        public Departments Depart { get; set; }
    }
}