using System;

namespace InheritanceWithInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.SetId(1);
            c.SetName("Readul Salehen");
            Console.WriteLine($"ID = {c.GetId()} Name = {c.GetName()}");
        }
    }
}
