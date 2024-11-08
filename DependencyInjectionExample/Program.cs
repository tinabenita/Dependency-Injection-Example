﻿namespace DependencyInjectionExample
{
    //Injector class
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL();

            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());

            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }
            Console.ReadKey();
        }
    }
}
