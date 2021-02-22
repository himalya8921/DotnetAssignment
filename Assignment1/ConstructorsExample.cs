using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ConstructorsExample
    {
        private int firstNumber , secondNumber;

        public void SetFirstNumber(int firstNumber)
        {
            this.firstNumber = firstNumber;
        }

        public void SetSecondNumber(int firstNumber)
        {
            this.firstNumber = firstNumber;
        }

        public int GetFirstNumber()
        {
            return this.firstNumber;
        }

        public int GetSecondNumber()
        {
            return this.secondNumber;
        }


        public ConstructorsExample()
        {
            Console.WriteLine("Default Constructor Called");
        }

        public ConstructorsExample(int firstNumber,int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            Console.WriteLine("Parameterized Constructor Called");
        }

        public ConstructorsExample(ConstructorsExample constructorObject)
        {
            this.firstNumber = constructorObject.firstNumber;
            this.secondNumber = constructorObject.secondNumber;
        }
    }

    class StaticClass
    {
        static int value;
        static StaticClass()
        {
            Console.WriteLine("This is static constructor");
        }
    }
}
