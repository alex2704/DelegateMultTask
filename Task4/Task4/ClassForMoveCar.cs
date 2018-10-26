using ClassLibrary;
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
        public ClassForMove(Car car, PictureBox pictureBox, TrafficLight trafficLight)
        {
            Car = car;
            PictureBox = pictureBox;
            TrafficLight = trafficLight;
        }
        public ClassForMove(Pedestrian pedestrian, PictureBox pictureBox)
        {
            Pedestrian = pedestrian;
            PictureBox = pictureBox;
        }
        public ClassForMove(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }

    }
}
