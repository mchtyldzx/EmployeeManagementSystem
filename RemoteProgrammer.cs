using System;

namespace EmployeeManagement
{
    public class RemoteProgrammer : Programmer
    {
        public int Distance { get; set; }

        public RemoteProgrammer() : base()
        {
            // Default constructor
        }

        public RemoteProgrammer(int id, string name, string surname, int age, string gender, decimal salary, 
            int numberOfTechnologies, int distance)
            : base(id, name, surname, age, gender, salary, numberOfTechnologies)
        {
            Distance = distance;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (Distance * 100));
        }

        public override string ToString()
        {
            return $"Remote {base.ToString()}, Distance: {Distance}km";
        }
    }
} 