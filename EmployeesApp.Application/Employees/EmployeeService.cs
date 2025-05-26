using EmployeesApp.Domain;

namespace EmployeesApp.Application.Employees;

public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    public void Add(Employee employee)
    {
        if (employee == null) throw new ArgumentException($@"{nameof(employee)} must not be null", nameof(employee));
        employeeRepository.Add(employee);
    }

    public Employee[] GetAll()
    {
        return employeeRepository
            .GetAll()
            .OrderBy(e => e.Name)
            .ToArray();
    }


    public Employee? GetById(int id)
    {
        if (id <= 0) throw new ArgumentException($@"Id must be a positive value", nameof(id));
        var ret = employeeRepository.GetById(id);
        if (ret == null) throw new Exception($@"Unable to find company with {nameof(Employee.Id)} {id}");
        return ret;
    }
}