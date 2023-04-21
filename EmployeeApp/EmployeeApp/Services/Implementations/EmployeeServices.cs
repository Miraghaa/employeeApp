
using EmployeeApp.Core.Models;
using EmployeeApp.Data.Repositories;
using EmployeeApp.Services.Interfaces;

namespace EmployeeApp.Services.Implementations
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly EmployeeRepository _employeerepository=new EmployeeRepository();
        public void Create()
        {
           Employee employee = new Employee();
            Console.WriteLine( "Add Name" );
            employee.Name = Console.ReadLine().Trim();
            Console.WriteLine("Add Surname");
            employee.Surname = Console.ReadLine().Trim();
            Console.WriteLine("Add salary");
            employee.Salary=double.Parse( Console.ReadLine().Trim());
            Console.WriteLine("Add Position");
            employee.Position = Console.ReadLine().Trim();
            _employeerepository.Create( employee );

            employee.UpdatedDate = DateTime.UtcNow.AddHours(4);
            employee.CreatedDate = DateTime.UtcNow.AddHours(4);
        }

        public void Delete()
        {
            Console.WriteLine("Enter id");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeerepository.Get(id);

            if ( employee == null )
            {
                Console.WriteLine("bele sey yoxdu atam");
            }
            else
            {
                _employeerepository.Delete( employee );
                Console.WriteLine(" sildim rahatdas ");
            }
        }

        public void Get()
        {
            Console.WriteLine("Enter id");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeerepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("bele sey yoxdu atam");
            }
            else
            {
                
                Console.WriteLine(employee);
            }
        }

        public void GetAll()
        {
            List<Employee> employees = _employeerepository.GetAll();

            foreach ( Employee employee in employees )
            {
                Console.WriteLine( employee );
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter id");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeerepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("bele sey yoxdu atam");
            }
            else
            {
                Console.WriteLine("Add Name");
                employee.Name = Console.ReadLine();               
            }
            employee.UpdatedDate = DateTime.UtcNow.AddHours(4);
        }
    }
}
