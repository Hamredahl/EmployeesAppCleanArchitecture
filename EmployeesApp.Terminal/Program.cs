using EmployeesApp.Application.Employees;
using EmployeesApp.Domain;
using EmployeesApp.Infrastructure.Persistence.Repositories;

namespace EmployeesApp.Terminal;

internal class Program
{
    static void Main(string[] args)
    {
        EmployeeRepository repository = new EmployeeRepository();
        EmployeeService employeeService = new EmployeeService(repository);

        foreach (Employee e in employeeService.GetAll())
        {
            Console.WriteLine("Name: " + e.Name + ", id: " + e.Id);
        }

        bool run = true;
        do
        {
            Console.Write("Id to find: ");
            string id = Console.ReadLine();
            try
            {
                Employee e = employeeService.GetById(int.Parse(id));
                Console.WriteLine("Name: " + e.Name + ", id: " + e.Id);
            }
            catch (Exception e) { Console.WriteLine(e); }            
            
        } while (run);
    }
}
