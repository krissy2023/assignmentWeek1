using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public double GetArea()
        {
            return _base * _height / 2;
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }
    }
}
