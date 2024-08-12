
namespace Week1ObjectOriented.Classes
{
    public class ShapesGenerator
    {
       
        public static void PrintDetails(List<Shape> Shapes)
        {

            foreach (Shape shape in Shapes)
            {
               Console.WriteLine(shape.Name);
               Console.WriteLine(shape.Colour);
               Console.WriteLine(shape.Area);
                Console.WriteLine();
            }
            

        }
    }
}
