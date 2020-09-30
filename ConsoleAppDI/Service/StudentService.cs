using ConsoleAppDI.Interface;
using ConsoleAppDI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDI.Service
{
    public class StudentService : IStudentService
    {
        private readonly Student _student;
        private List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>();
        }
        public StudentService(Student student)
        {
            _student = student;
            _students = new List<Student>();
        }


        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public int AgeOFStudent()
        {
            return (int)(DateTime.Now - _student.DOB).TotalMinutes / 1440;
        }

        public int NoOfSubjects()
        {
            return _student.Subjects.Count;
        }
    }
}
