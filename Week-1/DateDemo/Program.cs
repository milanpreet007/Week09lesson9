using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(2019, 12, 14);
            Console.WriteLine(date);

            //execising the Add method
            int days = 1,months=6,year=2;
            date.Add(days);
            Console.WriteLine($"Adding {days} day(s)");
            Console.WriteLine(date);

            days = 28;
            date.Add(months, days);
            Console.WriteLine($"Adding {months} month(s) and {days} day(s)");
            Console.WriteLine(date);

            Date date2 = new Date(year, months, days);
            Console.WriteLine($"Adding {year} year(s) {months} month(s) and {days} day(s)");
            date.Add(date2);
            Console.WriteLine(date);

            

        }
    }
}
