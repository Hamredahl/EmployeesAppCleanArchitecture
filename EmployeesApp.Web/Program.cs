using EmployeesApp.Application.Employees;
using EmployeesApp.Infrastructure.Persistence.Repositories;

namespace EmployeesApp.Web;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddTransient<IEmployeeService, EmployeeService>();
        builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
        var app = builder.Build();
        app.UseStaticFiles();
        app.MapControllers();
        app.Run();
    }
}