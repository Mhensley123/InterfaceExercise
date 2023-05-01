using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string SoundSystem { get; set; }

        public bool WillRechargeFast { get; set; }

        public void Model();
        public void Electric();
        public void SelfDrive();

        public void RechargesFast(bool isRechargedFast);
    }
}
