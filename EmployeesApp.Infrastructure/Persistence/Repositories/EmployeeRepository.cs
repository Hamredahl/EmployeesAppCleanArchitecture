using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesApp.Domain;
using EmployeesApp.Application.Employees;

namespace EmployeesApp.Infrastructure.Persistence.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    List<Employee> employees =
    [
        new Employee()
        {
            Id = 562,
            Name = "Anders Hejlsberg",
            Email = "Anders.Hejlsberg@outlook.com",
        },
        new Employee()
        {
            Id = 62,
            Name = "Kathleen Dollard",
            Email = "k.d@outlook.com",
        },
        new Employee()
        {
            Id = 15662,
            Name = "Mads Torgersen",
            Email = "Admin.Torgersen@outlook.com",
        },
        new Employee()
        {
            Id = 52,
            Name = "Scott Hanselman",
            Email = "s.h@outlook.com",
        },
        new Employee()
        {
            Id = 563,
            Name = "Jon Skeet",
            Email = "j.s@outlook.com",
        },
    ];
    public void Add(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Employee[] GetAll() => employees
        .ToArray();

    public Employee? GetById(int id) => employees
        .SingleOrDefault(e => e.Id == id);
}
