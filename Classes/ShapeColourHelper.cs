
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper 
    {
         
        public static Shape AddColour(Shape s)
        {
            string shapeColor = Colors.GetRandomColor();
            s.Colour = shapeColor;
            
            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
           string newShapeColor = Colors.GetRandomColor();

            if (s.Colour == newShapeColor)
            {
                string color2 = Colors.GetRandomColor();
                s.Colour = color2;
                return s;
            }
            s.Colour = newShapeColor;
            return s;
        }
        
    }
}
