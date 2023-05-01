using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV ()
        {

        }
        public string Color { get; set; } = "Burgundy";
        public string Make { get; set; } = "CRV";
        public int Year { get; set; } = 2001;
        public string SoundSystem { get; set; } = "Sony";
        public bool WillRechargeFast { get; set; } = false;
        public double Price { get; set; } = 5995;
        public string location { get; set; } = "Nashville";

        public void Electric()
        {
            Console.WriteLine($"{GetType().Name} does not use electric...");
        }

        public void Model()
        {
            Console.WriteLine($"{GetType().Name} ()");
        }

        public void RechargesFast(bool isRechargedFast)
        {
            WillRechargeFast = false;
        }

        public void SelfDrive()
        {
            Console.WriteLine($"{GetType().Name} is not self-driving");
        }
    }
}
