
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

        public override string? Name { get; set; }
        public override double Area { get; set; }

        public double GetArea() 
        {

            Area = Math.PI * Math.Pow(_radius, 2);
            return Area;
                
         }
        
        
    }

}
