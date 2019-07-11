using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismDemo
{
    abstract class Shape
    {
        public string Name { get; protected set; }
        public abstract double Area {get;}
       public Shape(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Name is {Name} Area is {Area}";
        }
    }
    class Square : Shape 
    {
        public double Length { get; protected set; }
        public override double Area
        {
            get
            {
                return Length * Length;
            }
        }
        public Square(double length) :base ("square")
        {
            Length = length;
        }
        public Square(string name, double length) :base(name)
        {
            Length = length;
        }
    }
    class Circle : Square
    {
        public override double Area
        {
            get
            {
                return Math.PI*Length*Length;
            }
        }
        public Circle(double length) : base("circle",length)
        {

        }
    }
    class Rectangle : Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
        public Rectangle(double length, double width) :base ("rectangle")
        {
            Width = width;
            Height = length;
        }
        public Rectangle(string name, double length, double width) :base(name)
        {
            Height = length;
            Width = width;
        }

    }
    class Ellipse : Rectangle
    {
        public override double Area => Math.PI * Width * Height;
        public Ellipse(double height, double width) :base("ellipse",height,width)
        {

        }

    }
    class Triangle : Rectangle
    {
        public override double Area => Width * Height * 0.5;
        public Triangle(double length, double height) :base("triangle",length,height)
        {

        }
    }
    class Diamond : Rectangle
    {
        public override double Area => Width * Height;
        public Diamond(double height, double width) :base("diamond",height,width)
        {

        }
    }
        

}
