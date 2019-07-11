using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Rectangle
    {
        //data members or fields
        int length, width;

        //constructor
        //similar to a method
        //name is the same as name of the class 
        // there is no return type
        //is called automatically when an object is created
       public Rectangle(int len,int wid)
        {
            width = wid;
            length = len;
        }
        //tostring method is used by Console.WriteLine method
        public override string ToString()
        {
            return $"length:{length} width:{width}";
        }
        //another action member
        public int GetArea()
        {
            return length * width;
        }
    }
}
