using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadRectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a badRectangle object
            BadRectangle badRectangle = new BadRectangle();
            // set the lenght and width
            badRectangle.length = 8;
            badRectangle.width = 5;
            // invoke the method DescribeBadRectangle
            DescribeBadRectangle(badRectangle);
            //invoke the method CreateBadRectangle
           BadRectangle milan= CreateBadRectangle(5, 3);
            DescribeBadRectangle(milan);
        }
        //write the method DescribeBadRectangle
        static void DescribeBadRectangle(BadRectangle badRectangle)
        {
            Console.WriteLine($"Width :{badRectangle.length},length:{badRectangle.width}");
        }
        //write the CreateBadRectangle() method
        static BadRectangle CreateBadRectangle(int width,int length)
        {
            BadRectangle badRectangle = new BadRectangle();
            badRectangle.width = width;
            badRectangle.length = length;
            return badRectangle;
        }
    }
    class BadRectangle
    {
       public int length, width;

    }
}
