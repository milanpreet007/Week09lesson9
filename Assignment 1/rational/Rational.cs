using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rational
{
    class Rational
    {
        public int Denominator { get; private set;}
        public int Numerator { get; private set; }

        public Rational(int numerator = 0, int denominator = 1)
        {
            Denominator = denominator;
            Numerator = numerator;

        }
        public override string ToString()
        {
            return $"({Numerator}/{Denominator})";

        }
        public void IncreaseBy(Rational other)
        {
            if (Denominator == other.Denominator)
            {
                Numerator += other.Numerator;
                Denominator = other.Denominator;
            }
            else
            {
              Numerator = ((Numerator*other.Denominator)+(Denominator*other.Numerator));
                Denominator = Denominator * other.Denominator;
            }
        }
        public void DecreaseBy(Rational other)
        { 

            if (Denominator == other.Denominator)
            {
                Numerator -= other.Numerator;
                Denominator = other.Denominator;
            }
            else
            {
                Numerator = ((Numerator * other.Denominator) - (Denominator * other.Numerator));
                Denominator = Denominator * other.Denominator;
            }
        }



    }
}
