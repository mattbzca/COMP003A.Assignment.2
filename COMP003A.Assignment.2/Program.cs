/*
 * Author: Matthew Tan
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, Math, and Console properties
 * Reference: The C# Player's Guide (4e) by RB Whitaker
 */
using System.Transactions;

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("************************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("************************************************************");


            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age in 2023: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("************************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("************************************************************");
            Console.Write("Enter an integer for integer1: ");
            string number1 = Console.ReadLine();
            int integer1 = Convert.ToInt32(number1);
            Console.WriteLine("Enter an integer for integer2: ");
            string number2 = Console.ReadLine();
            int integer2 = Convert.ToInt32(number2);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            Console.WriteLine("************************************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("************************************************************");
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("The area is ");
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(area);
            Console.Write("The circumference is ");
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine(circumference);
        }
    }
}