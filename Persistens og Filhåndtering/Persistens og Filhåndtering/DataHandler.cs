using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.IO;
using Persistens_og_Filhåndtering;

public class DataHandler
{
    //Attributes fra DCD
    public string FilePath { get; set; } // Sti til filen, der gemmer data

    public DataHandler(string filePath)
    {
        FilePath = filePath; // Sætter filstien ved oprettelse af DataHandler
    }

    // Metode til at gemme en liste af afdelinger i en fil
    public void SaveDepartmentsToFile(List<Department> departments)
    {
        using (StreamWriter sw = new StreamWriter(FilePath)) // Åbner filen til skrivning
        {
            foreach (var department in departments)
            {
                foreach (var employee in department.Employees)
                {
                    sw.WriteLine(employee.ToString()); // Gemmer hver medarbejder som en linje i filen
                }
            }
        }
    }

    // Metode til at indlæse en liste af medarbejdere fra en fil
    public List<Employee> LoadEmployeesFromFile()
    {
        List<Employee> employees = new List<Employee>();

        using (StreamReader sr = new StreamReader(FilePath)) // Åbner filen til læsning
        {
            string line;
            while ((line = sr.ReadLine()) != null) // Læser hver linje i filen
            {
                if (!string.IsNullOrEmpty(line))
                {
                    employees.Add(Employee.FromString(line)); // Opretter en Employee fra linjen og tilføjer til listen
                }
            }
        }

        return employees; // Returnerer listen af medarbejdere
    }
}