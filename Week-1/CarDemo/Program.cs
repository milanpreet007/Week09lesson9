using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car(2015, "honda", "civic", 18700, true);
            Console.WriteLine(c1);
            Car c2 = new Car(2012, "dodge", "charger", 35000, false);
            Console.WriteLine(c2);
            Console.WriteLine(new Car(2010,"dfsfd","sdad",1545,true));
        }
    }
}
