using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Rational
    {
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }
        public Rational(int numerator = 0, int denominator = 1)
        {
            Denominator = denominator;
            Numerator = numerator;
        }
        public override string ToString()
        {
            return $"{}";
        }
        public void IncreaseBy(Rational other)
        {
            
        }
        public void DecreaseBy(Rational other)
        {

        }
    }
}
