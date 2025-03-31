namespace Persistens_og_Filhåndtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oprette Afdelinger og Medarbejdere
            Department itDepartment = new Department { Name = "IT" };
            itDepartment.Employees.Add(new Employee { Id = 1, Name = "John Doe", Salary = 50000, Department = itDepartment });
            itDepartment.Employees.Add(new Employee { Id = 2, Name = "Jane Doe", Salary = 60000, Department = itDepartment });

            Department hrDepartment = new Department { Name = "HR" };
            hrDepartment.Employees.Add(new Employee { Id = 3, Name = "Alice Smith", Salary = 45000, Department = hrDepartment });

            List<Department> departments = new List<Department> { itDepartment, hrDepartment };

            // Gemme Afdelinger i en Fil
            DataHandler dataHandler = new DataHandler("employees.txt");
            dataHandler.SaveDepartmentsToFile(departments);

            // Indlæse Medarbejdere fra en Fil
            List<Employee> loadedEmployees = dataHandler.LoadEmployeesFromFile();
            foreach (var employee in loadedEmployees)
            {
                Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}, Department: {employee.Department.Name}");
            }
            Console.ReadLine();
        }
    }
}
