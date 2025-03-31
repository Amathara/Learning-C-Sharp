using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens_og_Filhåndtering
{
    public class Employee
    {
        //Attributter fra DCD
        public int Id { get; set; } // Unikt ID for medarbejderen
        public string Name { get; set; } // Navn på medarbejderen
        public double Salary { get; set; } // Løn for medarbejderen
        public Department Department { get; set; } // Reference til afdelingen, medarbejderen tilhører (aggregation)

        // ToString-metode til at konvertere medarbejderen til en streng - ses også i DCD.
        public override string ToString()
        {
            string departmentName = Department != null ? Department.Name : "No Department";
            return $"{Id},{Name},{Salary},{departmentName}";
        }

        // Metode til at oprette en Employee fra en streng - ses også i DCD
        public static Employee FromString(string data)
        {
            string[] parts = data.Split(','); // Opdeler strengen baseret på komma
            return new Employee
            {
                Id = int.Parse(parts[0]), // Konverterer første del til ID
                Name = parts[1], // Anden del er navnet
                Salary = double.Parse(parts[2]), // Tredje del er lønnen
                Department = new Department { Name = parts[3] } // Fjerde del er afdelingens navn
            };
        }
    }
}
