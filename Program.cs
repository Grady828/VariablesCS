using System;
using VariablesCS.Models;
using System.Linq;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 2;
            var fullName = "Mike Morris";
            var today = DateTime.Today;


            Console.WriteLine($"{fullName} {numberOfCupsOfCoffee} {today}");

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {userName}. Greetings.");

            Console.Write("Gimmie two numbers ");
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine("Added together gives you " + sum);
            Console.WriteLine("The difference of these are " + difference);
            Console.WriteLine("Multiplied together gives you " + product);
            Console.WriteLine("The first number divided by the second number is " + quotient);
            Console.WriteLine("Whats leftover when you divide the first number by the second number is " + remainder);
















        }
    }
}
