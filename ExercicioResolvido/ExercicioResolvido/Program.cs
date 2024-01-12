using System.Collections.Generic;
using ExercicioResolvido.Entities;
using System.Globalization;

namespace ExercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int qtdEmployess = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdEmployess; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    elist.Add(new OutsourcedEmployee(name, hours, hourValue, addCharge));
                }
                else
                {
                    elist.Add(new Employee(name, hours, hourValue));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in elist)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }

        }
    }
}