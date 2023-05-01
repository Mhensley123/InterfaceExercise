using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public double Price { get; set; } = 14250;
        public string location { get; set; } = "Nashville";
        public string Color { get; set; } = "green";
        public string Make { get; set; } = "Civic";
        public int Year { get; set; } = 1999;
        public string SoundSystem { get; set; } = "Bose";
        public bool WillRechargeFast { get; set; } = true;

        public void Electric()
        {

            {
                Console.WriteLine($"{GetType().Name} now uses electric...");
            }
        }

        public void Model()
        {
            Console.WriteLine($"{GetType().Name} ()");
        }

        public void SelfDrive()
        {
            Console.WriteLine($"{GetType().Name} is self-driving");
        }
        public void RechargesFast(bool isRechargedFast)
        {
            WillRechargeFast = true;
        }
        
        
        
    }

}
