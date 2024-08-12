// See https://aka.ms/new-console-template for more information
using System;
using Week1ObjectOriented.Classes;

var square = new Square(2);
square.Name = "square";

ShapeColourHelper.AddColour(square);

Console.Write("The color of square is " + square.Colour + ",");

ShapeColourHelper.ChangeColour(square);

Console.Write("The new color of square is " + square.Colour + ",");

Console.WriteLine("The area of square is " + square.GetArea() + ".");




var circle = new Circle(2);
circle.Name = "circle";

ShapeColourHelper.AddColour(circle);

Console.Write("The color of circle is " + circle.Colour + ",");

ShapeColourHelper.ChangeColour(circle);

Console.Write("The new color of circle is " + circle.Colour + ",");

Console.WriteLine("The area of circle is " + circle.GetArea() + ".");


var triangle = new Triangle(4, 5);
triangle.Name = "triangle";
ShapeColourHelper.AddColour(triangle);
triangle.GetArea();

var arrayOfShapes = new List<Shape>() { square, circle, triangle};
Console.WriteLine();
Console.WriteLine("Array of Shapes");
Console.WriteLine();



ShapesGenerator.PrintDetails(arrayOfShapes);







Console.ReadLine();




