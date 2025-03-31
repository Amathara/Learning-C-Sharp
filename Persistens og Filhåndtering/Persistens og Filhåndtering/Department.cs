using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens_og_Filhåndtering
{
    public class Department
    {
        //Atrributter fra DCD
        public string Name { get; set; } // Navn på afdelingen
        public List<Employee> Employees { get; set; } = new List<Employee>(); // Liste af medarbejdere i afdelingen (aggregation)

        // ToString-metode til at repræsentere afdelingen og dens medarbejdere
        public override string ToString()
        {
            string result = $"Department: {Name}\n";
            foreach (var employee in Employees)
            {
                result += employee.ToString() + "\n"; // Tilføjer hver medarbejder som en streng
            }
            return result;
        }
    }
}
