using System;
using System.Collections;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //pattern
            printPattern();

            // swap two numbers without using the third number
            int firstNumber = 10, secondNumber = 5;
            firstNumber = firstNumber + secondNumber;// 15
            secondNumber = firstNumber - secondNumber; //15 - 5 = 10;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("First Number is " + firstNumber + " Second Number is" + secondNumber);

            // Palindrome Function
            int toCheckPalindrome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPalindrome(toCheckPalindrome));

            //Interface
            Car carObj = new Car();
            carObj.Brake();
            carObj.Move();

            //Abstract Class Implementation
            DerivedClass derivedObj = new DerivedClass();
            derivedObj.TestFunction();

            //Constructors Example
            ConstructorsExample constructorObj1 = new ConstructorsExample();
            ConstructorsExample constructorObj2 = new ConstructorsExample(10,5);
            ConstructorsExample constructorObj3 = new ConstructorsExample(constructorObj2);

            //static Constructor
            StaticClass staticObj = new StaticClass();

            Console.WriteLine("ConstructorObj3's firstnumber is " + constructorObj3.GetFirstNumber() + " and Second is " + constructorObj3.GetFirstNumber());

            //exception Handling
            ExceptionHandlingExample exceptionObj = new ExceptionHandlingExample();
            exceptionObj.DivideByZero();

            //will throw an exception if age is less then 18
            exceptionObj.ThrowException(20);

            //Get reverse String
            string str = "Himalya";
            Console.WriteLine("Reversed String is " + GetReverseString(str));


            //To check if 3 is present in a number
            if(ContainsInt(143) == true)
            {
                Console.WriteLine("Yes 3 is Present");
            }
            else
            {
                Console.WriteLine("No 3 is not present");
            }

            //Pointers
            createPointers();

            //
            int[] arr = { 15, 16, 17, 18 };

            arr = ReverseArray(arr);

            Console.WriteLine("Reversed Array");

            foreach(var element in arr)
            {
                Console.WriteLine(element);
            }

        }

        public static Boolean IsPalindrome(int number)
        {
            int temp = number;//54345

            int finalNumber = 0;


            while( temp > 0)
            {
                finalNumber = ((10 * finalNumber) + (temp % 10));
                temp = temp / 10;
            }
            
            if(finalNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetReverseString(string str)
        {
            // himalya
            char temp;
            StringBuilder sb = new StringBuilder(str);

            for(int index = 0; index < sb.Length/2; index++)
            {
                temp = sb[index];
                sb[index] = sb[sb.Length - index - 1];
                sb[sb.Length - index - 1] = temp;

            }

            return sb.ToString();
        }

        public static Boolean ContainsInt(int num)
        {
            int toCheck = 3;
            while(num > 0 )
            {
                if (num % 10 == toCheck)
                {
                    return true;
                }

                num = num / 10;

            }
            return false;
        }

        unsafe public static void createPointers()
        {
            int x = 10;
            int y = 20;
            int* ptr1 = &x;
            int* ptr2 = &y;
            Console.WriteLine((int)ptr1);
            Console.WriteLine((int)ptr2);
            Console.WriteLine("Intial value of x:- " + *ptr1);
            Console.WriteLine("Initial value of y:- " + *ptr2);
            *ptr2 = *ptr2 + 10;
            Console.WriteLine("Changed value of y:- "+*ptr2);
        }

        public static int[] ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        public static void printPattern()
        {
            Console.WriteLine("Enter number of rows");
            int number = Convert.ToInt32(Console.ReadLine());

            int  k = 0;
            for (int i = 1; i <= (number * 2) - 1; i++)
            {
                if (i <= number)
                {
                    k++;
                }
                else
                {
                    k--;
                }

                for (int j = 1; j <= (number * 2) - 1; j++)
                {
                    if (j >= (number + 1) - k && j <= (number - 1) + k)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();


            }


        }

    }
}
