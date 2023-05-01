using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }
        public double Price { get; set; } = 25222;
        public string location { get; set; } = "Nashville";
        public string Color { get; set; } = "silver";
        public string Make { get; set; } = "Tundra";
        public int Year { get; set; } = 1999;
        public string SoundSystem { get; set; } = "Bose";
        public bool WillRechargeFast { get; set; } = false;

      
        
        public void Model()
        {
            Console.WriteLine($"{GetType().Name} ()");
        }

        public void Electric()
        {
            Console.WriteLine($"{GetType().Name} does not use electric...");
        }

        public void SelfDrive()
        {
           Console.WriteLine($"{GetType().Name} is not self-driving");
        }

        public void RechargesFast(bool isRechargedFast)
        {
            WillRechargeFast = false;
        }
    }

    
    


}

        
    









