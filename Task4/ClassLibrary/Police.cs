using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Police : IEmergencyService
    {
        public string Name { get; set; } = "Police";
        public void Help(Pedestrian objectPedestrian, Car objectCar)
        {
        }
        public Police()
        {
        }
    }
}
