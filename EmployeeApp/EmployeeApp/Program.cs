using EmployeeApp.Services.Implementations;
using EmployeeApp.Services.Interfaces;

IEmployeeService employeeService = new EmployeeServices();

Console.WriteLine("0. Close App");
Console.WriteLine("1. Create Employee");
Console.WriteLine("2. Update Employee");
Console.WriteLine("3. Delete Employee");
Console.WriteLine("4. Get All Employees");
Console.WriteLine("5. GetbyId Employee");
Console.WriteLine();
string Request = Console.ReadLine().Trim();

while (Request != "0")
{
    Console.Clear();
    switch (Request)
    {
        case "1":
            employeeService.Create();
            break;

        case "2":
            employeeService.Update();
            break;

        case "3":
            employeeService.Delete();
            break;

        case "4":
            employeeService.GetAll();
            break;

        case "5":
            employeeService.Get();
            break;

        default:
            Console.WriteLine("Choose a valid option");
            break;
    }
    Console.WriteLine("0. Close App");
    Console.WriteLine("1. Create Employee");
    Console.WriteLine("2. Update Employee");
    Console.WriteLine("3. Delete Employee");
    Console.WriteLine("4. Get All Employees");
    Console.WriteLine("5. GetbyId Employee");
    Console.WriteLine();
     Request = Console.ReadLine().Trim();

}