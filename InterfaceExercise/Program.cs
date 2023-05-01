using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car = new Car();
            var Truck = new Truck();
            var SUV = new SUV();
            var vehicles = new List<IVehicle>() { Car, Truck, SUV};    

            foreach(var vehicle in vehicles)
            {
                vehicle.SelfDrive();
                vehicle.Electric();
                vehicle.Model();
            }
        }
    }
}
