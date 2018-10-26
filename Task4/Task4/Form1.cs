using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            crosswalk_pictureBox.Controls.Add(car_pictureBox);
            crosswalk_pictureBox.Controls.Add(frontPedestrian_pb);
            crosswalk_pictureBox.Controls.Add(ambulance_pb);
            crosswalk_pictureBox.Controls.Add(police_pb);
            crosswalk_pictureBox.Controls.Add(fireman_pb);
            //fireman_pb.Visible = false;
            //police_pb.Visible = false;
            //ambulance_pb.Visible = false;
            trafficLight_pb.Visible = false;
        }
        private void StartFilm_btn_Click(object sender, EventArgs e)
        {
            TrafficLight trafficLight = new TrafficLight();
            Pedestrian pedestrian = new Pedestrian();
            Car car = new Car();
            //переключение светофора
            Thread SwitchTrafficThread = new Thread(new ParameterizedThreadStart(trafficLight.CheckTrafficLight));
            trafficLight_pb.Visible = true;
            SwitchTrafficThread.Start(trafficLight_pb);
            ////движение машины
            Thread moveCarThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectCar));
            ClassForMove myObject1Car = new ClassForMove(car, car_pictureBox, trafficLight);
            moveCarThread.Start(myObject1Car);
            ////движение пешехода переднего
            Thread frontPedestrianThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectFrontPedestrian));
            ClassForMove myObject2Pedestrian = new ClassForMove(pedestrian, frontPedestrian_pb);
            frontPedestrianThread.Start(myObject2Pedestrian);
            //аварийный случай
            //if (car.BumpStatus == true || pedestrian.BumpStatus == true)
            //{
            //    ambulance_pb.Visible = true;
            //    fireman_pb.Visible = true;
            //    police_pb.Visible = true;
            //    Thread ambulanceThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectAmbulancy));
            //    ClassForMove myObject3Ambulance = new ClassForMove(ambulance_pb);
            //    ambulanceThread.Start(myObject3Ambulance);
            //    Thread policeThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectPoliceAndFireGuys));
            //    ClassForMove myObject4Police = new ClassForMove(police_pb);
            //    policeThread.Start(myObject4Police);
            //    Thread FireThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectPoliceAndFireGuys));
            //    ClassForMove myObject5FireGuys = new ClassForMove(fireman_pb);
            //    FireThread.Start(myObject5FireGuys);
            //}
        }
    }
}
