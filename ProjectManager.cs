using System;

namespace EmployeeManagement
{
    public class ProjectManager : Employee
    {
        public int NumberOfProjects { get; set; }

        public ProjectManager() : base()
        {
            // Default constructor
        }

        public ProjectManager(int id, string name, string surname, int age, string gender, decimal salary, int numberOfProjects)
            : base(id, name, surname, age, gender, salary)
        {
            NumberOfProjects = numberOfProjects;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (NumberOfProjects * 300));
        }

        public override string ToString()
        {
            return $"Project Manager - {base.ToString()}, Projects: {NumberOfProjects}";
        }
    }
} 