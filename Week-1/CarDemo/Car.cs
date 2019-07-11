﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Car
    {
        //fields(all private)
        int year;
        string manufacturer;
        string model;
        bool isDrivable;
        double price;
        //constructor
        public Car(int year, string manufacturer, string model, double price, bool isDrivable = true)
        {
            this.year = year;//this refers to the obejct member
            this.manufacturer = manufacturer;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = price;
        }
            public override string ToString()
        {
            return $"{year} {manufacturer} {model} {price:C} {(isDrivable ? "Drivable" : "Not Drivable")}";
        }


    }
 
}

