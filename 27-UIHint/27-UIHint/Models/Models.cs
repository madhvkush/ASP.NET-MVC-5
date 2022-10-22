using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _27_UIHint.Models
{
    //@Html.DisplayForModel() --> will map to the display template of name Employee.cshtml
    public class Employee
    {
        // @Html.DisplayFor(model => model.EmployeeID) --> will map to display template Int32.cshtml
        public int EmployeeID { get; set; }

        [UIHint("StrongString")] //@Html.DisplayFor(model => model.Name)--> will map to display template StrongString.cshtml
        public string Name { get; set; }
        public string Mobile { get; set; } 

        // @Html.DisplayFor(model => model.BirthDate) --> will map to display template DateTimeIndiaFormat.cshtml
        [UIHint("DateTimeIndiaFormat")] // This template should be defined in 'Views/Shared/DisplayTemplates'
        public DateTime BirthDate { get; set; }
        public DateTime JoiningDate { get; set; }// By default it map to the template with name DateTime.cshtml

        public UserRole Role { get; set; }
    }

    public class UserRole
    {
        [UIHint("RadioButtonList")]
        public int? EmpRole { get; set; }
    }
}