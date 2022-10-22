using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _4_Models_Entityframework.Models
{
   
    [Table("tblStudent")]
    public class Student
    {
       public int Id { get; set; }
      public  string name { get; set; }
       public string course { get; set; }
      public  int age { get; set; }
    }
}