using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbersBy3()
        {
            for (int i = 3; i <= 999; i +=3)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void AreTheyEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is NOT equal to {num2}");
            }

        }


        //Write a method to check whether a given number is even or oddCons

        public static void EvenOrOdd(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is even");

            }
            else
            {
                Console.WriteLine($"{num1} is Odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        //ConsoleModifiers, Return Type, Method Name, Parameter List, and Scope

        public static void PositiveNegative(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("> than 0, this number is positive");
            }
            else
            {
                Console.WriteLine("< than 0, this number is negative");
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CheckAge()
        {
            Console.WriteLine("What is your age? I can tell you if your can vote:");
            bool validnumber = int.TryParse(Console.ReadLine(), out int age);

            if (age >= 18)
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You can't vote yet.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {
            Console.WriteLine("Enter in a number. We will check to see if it's in range.");
            int number = int.Parse(Console.ReadLine());

            if (number >= -10 && number <= 10)
            {
                Console.WriteLine("The number you chose is in range");
            }
            else
            {
                Console.WriteLine("Sorry, the number you chose is outside of the range.");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        //public static void MultiplicationTable(int num)
        //{

        //}

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //call methods in main method
            PrintNumbers1000(); //no arguments because no parameters
            PositiveNegative(5); // 1 argument because 1 parameter
            PrintNumbersBy3();
            AreTheyEqual(5, 10);
            EvenOrOdd(5);
            CheckAge();
            InRange();

        }

    
    }
}
