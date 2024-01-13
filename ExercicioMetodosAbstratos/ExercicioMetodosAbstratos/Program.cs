using ExercicioMetodosAbstratos.Entities;
using ExercicioMetodosAbstratos.Entities.Enum;
using System.Globalization;

namespace ExercicioMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> slist = new List<Shape>();
            Console.Write("Enter the number of shapes: " );
            int qtdShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shapeType == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    slist.Add(new Retangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radious = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    slist.Add(new Circle(radious, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape s in slist)
            {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture)); 
            }

        }
    }
}