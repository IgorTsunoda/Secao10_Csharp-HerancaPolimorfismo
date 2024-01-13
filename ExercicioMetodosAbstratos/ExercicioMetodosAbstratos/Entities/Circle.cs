using ExercicioMetodosAbstratos.Entities.Enum;
using System;

namespace ExercicioMetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radious { get; set; }

        public Circle(double radious, Color color) : base (color)
        {
            Radious = radious;
        }

        public override double Area()
        {
            return Math.PI * (Radious * Radious);
        }
    }
}
