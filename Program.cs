using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    class Program
    {
        private const decimal ANNUAL_BUDGET = 1000000m;
        private static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            InitializeEmployees();

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== Employee Management System ===");
                Console.WriteLine("1. Show all employees");
                Console.WriteLine("2. Show employees sorted by salary");
                Console.WriteLine("3. Find employee by ID");
                Console.WriteLine("4. Increase salary for employee");
                Console.WriteLine("5. Increase salary for all employees");
                Console.WriteLine("6. Show annual summary");
                Console.WriteLine("7. Exit");
                Console.ResetColor();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAllEmployees();
                        break;
                    case "2":
                        ShowEmployeesSortedBySalary();
                        break;
                    case "3":
                        FindEmployeeById();
                        break;
                    case "4":
                        IncreaseEmployeeSalary();
                        break;
                    case "5":
                        IncreaseAllSalaries();
                        break;
                    case "6":
                        ShowAnnualSummary();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private static void InitializeEmployees()
        {
            employees.Add(new ProjectManager(1, "John", "Doe", 35, "Male", 8000, 5));
            employees.Add(new Programmer(2, "Mucahit", "Yildiz", 22, "Male", 7000, 4));
            employees.Add(new Programmer(3, "Jane", "Margolis", 27, "Female", 6500, 3));
            employees.Add(new RemoteProgrammer(4, "Alex", "Anderson", 32, "Male", 7500, 5, 100));
            employees.Add(new RemoteProgrammer(5, "Lisa", "Anderson", 29, "Female", 7000, 4, 150));
        }

        private static void ShowAllEmployees()
        {
            Console.WriteLine("\nAll Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void ShowEmployeesSortedBySalary()
        {
            Console.WriteLine("\nEmployees sorted by salary (descending):");
            var sortedEmployees = employees.OrderByDescending(e => e.Salary);
            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void FindEmployeeById()
        {
            Console.Write("Enter employee ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    Console.WriteLine(employee);
                }
                else
                {
                    Console.WriteLine("Employee not found!");
                }
            }
        }

        private static void IncreaseEmployeeSalary()
        {
            Console.Write("Enter employee ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    Console.Write("Enter raise amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        employee.IncreaseSalary(amount);
                        Console.WriteLine("Salary increased successfully!");
                    }
                }
                else
                {
                    Console.WriteLine("Employee not found!");
                }
            }
        }

        private static void IncreaseAllSalaries()
        {
            Console.Write("Enter raise amount for all employees: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                foreach (var employee in employees)
                {
                    employee.IncreaseSalary(amount);
                }
                Console.WriteLine("All salaries increased successfully!");
            }
        }

        private static void ShowAnnualSummary()
        {
            decimal totalAnnualSalaries = employees.Sum(e => e.Salary * 12);
            decimal difference = ANNUAL_BUDGET - totalAnnualSalaries;

            Console.WriteLine($"\nAnnual Budget: {ANNUAL_BUDGET:C}");
            Console.WriteLine($"Total Annual Salaries: {totalAnnualSalaries:C}");
            Console.Write("Difference: ");
            
            if (difference >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"{difference:C}");
            Console.ResetColor();
        }
    }
} 