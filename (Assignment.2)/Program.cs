﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Assignment._2_
{
    class Vehicle
    {
        public string brand;
    }
    class Motorvehicle : Vehicle
    {
        public string modelName;
    }
    class Car : Motorvehicle
    {

    }
    class Truck : Motorvehicle
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.brand = "Mercedes";
            c.modelName = "E300";
            Console.WriteLine("The brand of Car: " + c.brand);
            Console.WriteLine("The model Name of Car: " + c.modelName);
            Truck t = new Truck();
            c.brand = "Scania";
            c.modelName = "770s";
            Console.WriteLine("The brand of Truck: " + c.brand);
            Console.WriteLine("The model Name of Truck: " + c.modelName);
            Console.ReadLine();
        }
    }
}
