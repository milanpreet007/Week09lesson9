using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodDemo
{
    class Mood
    {
        AColor red, green, blue;
        public Mood(double rStart,double rIncrement, double gStart, double gIncrement, double bStart, double bIncrement)
        {
            red = new AColor(rStart, rIncrement);
            green = new AColor(gStart, gIncrement);
            blue = new AColor(bStart, bIncrement);
        }
        public Color Color
        {
            get
            {
                return Color.FromArgb(red.Value, green.Value, blue.Value);
            }
        }
         class AColor
        {
            double value, increment;
            public AColor(double value,double increment)
            {
                this.value = value;
                this.increment = increment;
            }
            public byte Value
            {
                get
                {
                    if (value + increment > 1 || value + increment < 0)
                        increment *= -1;
                    value += increment;
                    return (byte)(value * 255);
                }
            }
        }
    }
}
