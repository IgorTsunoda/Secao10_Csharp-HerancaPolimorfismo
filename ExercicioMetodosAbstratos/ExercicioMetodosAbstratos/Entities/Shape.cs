using ExercicioMetodosAbstratos.Entities.Enum;

namespace ExercicioMetodosAbstratos.Entities
{
     abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
