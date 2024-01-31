using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of Numbers");
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of numbers");
            int average = (int)numbers.Average();
            Console.WriteLine(average);
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order");
            numbers.OrderBy(num => num).ToList().ForEach(num  => Console.WriteLine(num));
            Console.WriteLine();
            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Numbers in descending order");
            numbers.OrderByDescending(num => num).ToList().ForEach((num => Console.WriteLine(num)));
            Console.WriteLine();
            Console.WriteLine("bigger then 6");
            //TODO: Print to the console only the numbers greater than 6
            numbers.Where(num => num > 6).ToList().ForEach(num => Console.WriteLine(num));
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("print four");


            var onlyFour = numbers.OrderBy(num => num).Take(4).ToList();   
            foreach (var x in onlyFour) 
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            var age = 17;
            //assuming i know how many elements are in the list//**
            numbers[4] = age;
            var num1 = numbers.OrderBy(num => num).ToList();
                foreach(var x in num1)
            {
                Console.WriteLine(x);
            }


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FullName).ToList().ForEach(emp => Console.WriteLine($"{ emp.FullName} {emp.Age}"));
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine();
            var total = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35).Sum(emp => emp.YearsOfExperience);
            Console.WriteLine(total);
            Console.WriteLine();
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var ave = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35).Average(emp => emp.YearsOfExperience);
            Console.WriteLine(ave);
            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine();

            Employee newGuy = new Employee() { FirstName = "jim", LastName = "bob", Age = 2, YearsOfExperience = 99,};
            employees = employees.Concat(new List<Employee> { newGuy }).ToList();
            
                
            employees.OrderBy(x => x.FullName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
