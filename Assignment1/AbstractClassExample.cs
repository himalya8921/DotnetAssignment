using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    interface IBrakeable
    {
        void Brake();
    }
    
    interface IMoveable
    {
        void Move();
    }

    abstract class AbstractClassExample
    {
        abstract public void  TestFunction();

        public void PrintInfo()
        {
            Console.WriteLine("This is parent Abstract Class");
        }

    }

    class DerivedClass : AbstractClassExample
    {
        override public void  TestFunction()
        {
            Console.WriteLine("This is a abstract method ");
        }
    }

    class Car: IMoveable, IBrakeable
    {
        public void Brake()
        {
            Console.WriteLine("Apply Brakes");
        }

        public void Move()
        {
            Console.WriteLine("Movee");
        }

    }
}
