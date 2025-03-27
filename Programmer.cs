using System;

namespace EmployeeManagement
{
    public class Programmer : Employee
    {
        public int NumberOfTechnologies { get; set; }

        public Programmer() : base()
        {
            // Default constructor
        }

        public Programmer(int id, string name, string surname, int age, string gender, decimal salary, int numberOfTechnologies)
            : base(id, name, surname, age, gender, salary)
        {
            NumberOfTechnologies = numberOfTechnologies;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (NumberOfTechnologies * 250));
        }

        public override string ToString()
        {
            return $"Programmer - {base.ToString()}, Technologies: {NumberOfTechnologies}";
        }
    }
} 