using ClassLibrary;
using DrawingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class ClassForMove
    {
        public Car Car;
        public Pedestrian Pedestrian;
        public PictureBox PictureBox;
        public TrafficLight TrafficLight;
        public PictureBox EmergencyCauseBox;
        public ClassForMove(Car car, PictureBox pictureBox, TrafficLight trafficLight, PictureBox emergency, Pedestrian pedestrian)
        {
            Car = car;
            PictureBox = pictureBox;
            TrafficLight = trafficLight;
            EmergencyCauseBox = emergency;
            Pedestrian = pedestrian;
        }
        public ClassForMove(Pedestrian pedestrian, PictureBox pictureBox, TrafficLight trafficLight, PictureBox emergency, Car car)
        {
            Pedestrian = pedestrian;
            PictureBox = pictureBox;
            TrafficLight = trafficLight;
            EmergencyCauseBox = emergency;
            Car = car;
        }
        public ClassForMove(PictureBox pictureBox, Pedestrian pedestrian, Car car)
        {
            PictureBox = pictureBox;
            Pedestrian = pedestrian;
            Car = car;
        }

    }
}
