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


        }
    }
}
