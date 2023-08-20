using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{

                      //Methode-Overriding
    public class Animal
    {
                        //Constructor-Overloading
        //public Animal()
        //{
                
        //}

        //public Animal(string name)
        //{
            
        //}

        //public Animal(string name, int id)
        //{
            
        //}
        public void PrintName()
        {
            Console.WriteLine("This is an animal");
        }
    }

    public class Cat : Animal
    {
        public void PrintName()
        {
            Console.WriteLine("This is a cat");
        }
    }

    public class Dog : Animal
    {
        public void PrintName()
        {
            Console.WriteLine("This is a dog");
        }
    }
}
