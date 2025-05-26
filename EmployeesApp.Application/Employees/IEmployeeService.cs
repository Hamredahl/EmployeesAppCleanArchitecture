using EmployeesApp.Domain;

namespace EmployeesApp.Application.Employees;

public interface IEmployeeService
{
    void Add(Employee employee);

    Employee[] GetAll();

    Employee GetById(int id);
}
