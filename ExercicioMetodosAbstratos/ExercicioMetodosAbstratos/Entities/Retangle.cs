using ExercicioMetodosAbstratos.Entities.Enum;
using System;

namespace ExercicioMetodosAbstratos.Entities
{
    class Retangle : Shape

    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, Color color) : base (color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
