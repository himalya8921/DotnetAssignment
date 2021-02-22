using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ExceptionHandlingExample
    {
        public void DivideByZero()
        {
            try 
            {
                int zero = 0;
                int temp = 5 / zero;
            }
            catch( Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // this block gets executed no matter if exception is caught or not 
                Console.WriteLine("In the finally block");
            }
        }

        public void ThrowException( int age)
        {
            if(age > 18)
            {
                Console.WriteLine("You are Allowed");
            }
            else
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
        }
    }
}
