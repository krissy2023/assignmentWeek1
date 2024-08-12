
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Square : Shape, IFaces, IShape
    {
         int side { get; set; }
        

        private int _length;

        public Square(int length)
        {
         
            _length = length;
        }

        public override string? Name { get; set; }
        public override double Area { get; set; }

        public void SetSide(int s)
        {
            side = s;
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }

       

        public double GetArea()
        {

            Area = _length * _length;

            return Area;
        }

        public readonly int Sides;

    }
}
