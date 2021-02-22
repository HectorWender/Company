using System;
using System.Collections.Generic;
using System.Globalization;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registred? ");
            var qtdEmployee = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 0; i < qtdEmployee; i++) {
                Console.WriteLine("Employee #" + i);

                Console.Write("ID: ");
                var id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Salary: ");
                var salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            var searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if(emp != null) {
                Console.WriteLine("Enter the percentage:");
                var percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Increase(percentage);
            } else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
