
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IFaces, IShape

    {
        private double _base;
        private double _height;

        public Triangle(double @base, double height)
        {
            _base = @base;
            _height = height;
        }

        public override string? Name { get; set; }
        public override double Area { get; set; }

        public double GetArea()
        {
            Area =  (_base * _height) / 2;
            return Area;
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }
    }
}
