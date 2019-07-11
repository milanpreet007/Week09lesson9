using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Date
    {
        //fields
        int year;
        int month;
        int day;
        public Date(int year,int month,int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public void Add(int days)
        {
            day = day + days;
            Normalize();
        }
        public void Add(int months, int days)
        {
            month = month + months;
            day = day + days;
            Normalize();
        }
        public void Add(Date other)
        {
            day = other.day + day;
            month = other.month + month;
            year = other.year + year;
            Normalize();
        }
      	private void Normalize()
        {
            while(day>30)            
                {
                    day = day - 30;
                    month++;
                }
            while (month > 12)
                {
                    month = month - 12;
                    year++;
                }            
        }
        public override string ToString()
        {
            return $"{year}-{month:d2}-{day:d2}";
        }
       	
    }
}
