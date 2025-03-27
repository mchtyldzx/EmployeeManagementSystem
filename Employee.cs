using System;

namespace EmployeeManagement
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            // Default constructor
        }

        public Employee(int id, string name, string surname, int age, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Salary = salary;
        }

        public virtual void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, Age: {Age}, Gender: {Gender}, Salary: {Salary:C}";
        }
    }
} 