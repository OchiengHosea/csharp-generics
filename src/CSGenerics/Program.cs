using System;
using CSGenerics.Repositories;
using CSGenerics.Entities;
using CSGenerics.Data;
using CSGenerics.Interfaces;

namespace CSGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employeeRepository);

            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization{Name="Pluralsight"});
            organizationRepository.Add(new Organization{Name="Globomantics"});
            organizationRepository.Save();
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack();
            stack.Push(1.2);
            stack.Push(5.2);
            stack.Push(2.2);

            double sum = 0.0;

            while(stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;

                Console.WriteLine($"Sum: {sum}");
                Console.ReadLine();
            }
        }

        private static void StackStrings(){
            var stack = new SimpleStackGeneric<string>();
            stack.Push("Simple string");
            stack.Push("Authority");
            stack.Push("Manager");
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee{FirstName="Julia"});
            employeeRepository.Add(new Employee{FirstName="Anna"});
            employeeRepository.Add(new Employee{FirstName="thomas"});
            employeeRepository.Save();
        }
    }
}
