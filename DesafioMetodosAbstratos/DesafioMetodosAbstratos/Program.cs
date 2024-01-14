using System.Globalization;
using DesafioMetodosAbstratos.Entities;

namespace DesafioMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> lperson = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int qtdPayers = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char personType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(personType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lperson.Add(new Physical(name, anualIncome, healthExpenditures));
                }
                else if(personType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int qtdEmployees = int.Parse(Console.ReadLine());
                    lperson.Add(new Juridic(name, anualIncome, qtdEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Person p in lperson)
            {
                //Console.WriteLine(p.Name + " : $ " + p.AnualIncome.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(p.TaxesPaid());
            }
            double sum = 0.0;
            foreach (Person p in lperson)
            {
                sum += p.TaxToPay();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}