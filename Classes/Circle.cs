
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        
        public double GetArea() => Math.PI * Math.Pow(_radius, 2);
        
    }

}
