using System;

namespace EmployeeManagement
{
    public class Analyst : Employee
    {
        public int NumberOfClients { get; set; }

        public Analyst() : base()
        {
            // Default constructor
        }

        public Analyst(int id, string name, string surname, int age, string gender, decimal salary, int numberOfClients)
            : base(id, name, surname, age, gender, salary)
        {
            NumberOfClients = numberOfClients;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (NumberOfClients * 200));
        }

        public override string ToString()
        {
            return $"Analyst - {base.ToString()}, Clients: {NumberOfClients}";
        }
    }
} 