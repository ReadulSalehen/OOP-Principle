using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Student : University
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public void SetUvName(string uvName)
        {
            UvName = uvName;
        }

        public string GetUvName()
        {
            return UvName;
        }
        public void SetStudentName(string studentName)
        {
            Name = studentName;
        }

        public string GetStudentName()
        {
            return Name;
        }

    }
}
