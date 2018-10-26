using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FireEngine : IEmergencyService
    {
        public string Name { get; set; } = "FireEngine";
        public void Help(Pedestrian objectPedestrian, Car objectCar)
        {
            objectCar.CrashStatus = CarStatus.OnTheRun;
        }
        public FireEngine()
        {
        }
    }
}
