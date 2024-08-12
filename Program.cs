// See https://aka.ms/new-console-template for more information
using System;
using Week1ObjectOriented.Classes;

var square = new Square(10);


try
{

    
    square.SetArea(2);
   

   Console.WriteLine("The area is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);




var circle = new Circle(2);

ShapeColourHelper.AddColour(circle);

Console.WriteLine(circle.Colour);

ShapeColourHelper.ChangeColour(circle);

Console.WriteLine(circle.Colour);

Console.WriteLine("The area is " + circle.GetArea());









Console.ReadLine();




