
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public abstract class Shape 
    {
        public abstract double Area { get; set; }

        public abstract string? Name { get; set;}
        
       
        public void SetArea(double area)
        {
            Area = area;
        }

        public string? Colour { get; set; }
    }
}
