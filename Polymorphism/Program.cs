using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.PrintName();
            Animal cat = new Cat();
            cat.PrintName();
            Dog d = new Dog();
            d.PrintName();
            Animal dog = new Dog();
            dog.PrintName(); 
        }


                //Methode-Overloding

        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //public static int Sum(int x, int y, int z)
        //{
        //    return x+y+z;
        //}
    }
}
