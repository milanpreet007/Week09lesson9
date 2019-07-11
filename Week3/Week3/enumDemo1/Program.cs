using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo1
{
    enum Days { Mon,Tue,Wed,Thu,Fri,Sat,Sun}
    [Flags]
    enum Genre { None=0,Comedy=1,Sci_Fi=2,Documetary=4,Action=8,Romance=16,Adult=32}
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Wed;
            Console.WriteLine(today);//print wed
            Console.WriteLine((int)today);
            Console.Write("Enter a Day:");
            string input = Console.ReadLine();
            Console.WriteLine(input);       //prints the string
            Days d = (Days)Enum.Parse(typeof(Days), input);
            Console.WriteLine(d);

            //exercising the Genre enum
            Genre genre = Genre.Comedy;
            Console.WriteLine(genre);

             genre = Genre.Comedy | Genre.Adult | Genre.Romance; //combining multiple values
            Console.WriteLine(genre);
            Console.WriteLine((Genre)22);   //prints Sci_Fi,documentry , romance
            if(genre.HasFlag(Genre.Comedy))
                Console.WriteLine("Comedy");
            else
                Console.WriteLine("Not Comedy ");

        }
    }
}
