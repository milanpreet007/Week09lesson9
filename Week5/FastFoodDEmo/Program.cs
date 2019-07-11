using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDEmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Server("Milanpreet") );
            Console.WriteLine();
            Console.WriteLine(new Supervisor("andrez"));
            Console.WriteLine();
            Console.WriteLine(new Manager("nsnd"));
        }
    }
}
