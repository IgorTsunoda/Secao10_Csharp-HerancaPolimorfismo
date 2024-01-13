using Desafio.Entities;
using System.Globalization;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> plist = new List<Product>();
            Console.Write("Enter the number of products: ");
            int qtdProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Comum, used or imported (c/u/i)? ");
                char PrdClassification = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(PrdClassification == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    plist.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (PrdClassification == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    plist.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (PrdClassification == 'c')
                {
                    plist.Add(new Product(name, price));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product p in plist)
            {
                Console.WriteLine(p.priceTag());
            }
        }
    }
}