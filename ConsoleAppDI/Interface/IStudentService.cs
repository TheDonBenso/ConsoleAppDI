using ConsoleAppDI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDI.Interface
{
    public interface IStudentService
    {
        public List<Student> Students { get; set; }
        public int AgeOFStudent();
        public int NoOfSubjects();
    }
}
