using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rational
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r = new Rational();
            Rational r1 = new Rational(2);
            Rational r2 = new Rational(10,4);
            Rational r3 = new Rational(4,3);
            Console.WriteLine($"Rational number 1:{r}");
            Console.WriteLine($"Rational number 2:{r1}");
            Console.WriteLine($"Rational number 3:{r2}");
            Console.WriteLine($"Rational number 4:{r3}");


            // When we Increase r by r1
            Console.Write($"Numbers {r} + {r1}");
            
            r.IncreaseBy(r1) ;
            Console.Write($"={r}");
            Console.WriteLine("");

            // when we Increase r1 by r2
            Console.Write($"Numbers {r1} + {r2}");
            
            r2.IncreaseBy(r1);
            Console.Write($"={r2}");
            Console.WriteLine("");

            // When we Subtract r1 from r2
            Console.Write($"Numbers {r2} - {r1}");
            
            r2.DecreaseBy(r1);
            Console.Write($"={r2}");
            Console.WriteLine("");


            // When we Subtract r2 from r3
            Console.Write($"Numbers {r3} - {r2}");
            
            r3.DecreaseBy(r2);
            Console.Write($"={r3}");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
