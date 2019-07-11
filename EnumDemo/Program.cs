using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Days { Mon = 10, Tue, Wed, Thu, Fri, Sat, Sun}

    [Flags]
    enum Genre { None = 0, Comedy = 1, Sci_Fi = 2,
        Documentary = 4, Action = 8, Romance = 16, Adult = 32 }

    class Program
    {
        static void Main(string[] args)
        {
            //Days today = Days.Wed;
            //Console.WriteLine(today); //prints Wed
            //Console.WriteLine((int)today); //prints 2
            //Console.Write("Enter a day: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(input);       //prints the string
            //Days d = (Days)Enum.Parse(typeof(Days), input);
            //Console.WriteLine(d);           //prints the enum

            //exercising the Genre enum
            Genre genre = Genre.Comedy;
            Console.WriteLine(genre);

            genre = Genre.Comedy | Genre.Adult | Genre.Romance; //combining multiple values
            Console.WriteLine(genre);
            genre = (Genre)22;
            Console.WriteLine(genre);       //prints Sci_Fi, Documentary and Romance
            if(genre.HasFlag(Genre.Comedy))
                Console.WriteLine("is comedy");
            else
                Console.WriteLine("is not comedy");
        }
    }
}
