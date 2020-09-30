using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDI.Models
{
    public class Student
    {
        public string  Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public List<string> Subjects { get; set; }

      
    }
}
