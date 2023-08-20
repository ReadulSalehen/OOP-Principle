using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetStudentName("Readul Salehen");
            student.SetUvName("UITS");
            Console.WriteLine($"Student Name:{student.GetStudentName()} University Name:{student.GetUvName()}");
        }
    }
}
