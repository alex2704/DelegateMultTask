using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class Utils
    {
        public static void MoveObjectCar(object classForMove)
        {
            int check = 0;
            ((ClassForMove)classForMove).Car.MoveStatus = true;
            while (((ClassForMove)classForMove).PictureBox.Location.X + 400 > 10)
            {
                if (((ClassForMove)classForMove).TrafficLight.Light == TrafficLights.Green)
                {
                    ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left - 10));
                    Thread.Sleep(50);
                }
                if (((ClassForMove)classForMove).TrafficLight.Light == TrafficLights.Red)
                    Thread.Sleep(2000);
                if (((ClassForMove)classForMove).PictureBox.Left < 300 && ((ClassForMove)classForMove).PictureBox.Left > 270 && check == 0)
                {
                    GenerateEmergencyCaseCar(classForMove);
                    check++;
                    ((ClassForMove)classForMove).Car.MoveStatus = true;
                }
            }
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                   ((ClassForMove)classForMove).PictureBox.Left = 995));
            Thread.Sleep(100);
            MoveObjectCar(classForMove);
        }
        public static void MoveObjectFrontPedestrian(object classForMove)
        {

            ((ClassForMove)classForMove).Pedestrian.MoveStatus = true;
            while (((ClassForMove)classForMove).PictureBox.Location.X + 300 > 10)
            {
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left - 10));
                Thread.Sleep(50);
            }
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                   ((ClassForMove)classForMove).PictureBox.Left = 995));
            Thread.Sleep(100);
            MoveObjectFrontPedestrian(classForMove);
        }
        public static void MoveObjectAmbulancy(object classForMove)
        {
            while (((ClassForMove)classForMove).PictureBox.Location.X + 1300 > 10)
            {
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left + 10));
                Thread.Sleep(50);
                if (((ClassForMove)classForMove).PictureBox.Location.X + 400 > 10)
                {
                    Thread.Sleep(500);
                }
            }
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
             ((ClassForMove)classForMove).PictureBox.Left = 480));
            Thread.Sleep(100);
        }
        public static void MoveObjectPoliceAndFireGuys(object classForMove)
        {
            while (((ClassForMove)classForMove).PictureBox.Location.X + 400 > 10)
            {
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left - 10));
                Thread.Sleep(50);
                if(((ClassForMove)classForMove).PictureBox.Location.X + 400 > 10)
                {
                    Thread.Sleep(500);
                }
            }
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                   ((ClassForMove)classForMove).PictureBox.Left = 995));
            Thread.Sleep(100);
        }

        public static bool EmergencyCase(object classEmergency)
        {
            return true;
        }
        public static void GenerateEmergencyCaseCar(object classEmergency)
        {
            Random rnd = new Random();
            ((ClassForMove)classEmergency).Car.CrashStatus = ((CarStatus)rnd.Next(1, 3));
            if (((ClassForMove)classEmergency).Car.CrashStatus == ((CarStatus)rnd.Next(1, 4)))
            {
                EmergencyCase(classEmergency);
                ((ClassForMove)classEmergency).Car.MoveStatus = false;
                ((ClassForMove)classEmergency).Car.BumpStatus = true;
                Thread.Sleep(20000);
            }
        }
        public static void GenerateEmergencyCasePedestrian(object classEmergency)
        {
            Random rnd = new Random();
            ((ClassForMove)classEmergency).Pedestrian.LifeStatus = ((PedestrianStatus)rnd.Next(1, 3));
            if (((ClassForMove)classEmergency).Pedestrian.LifeStatus == ((PedestrianStatus)rnd.Next(1, 4)))
            {
                EmergencyCase(classEmergency);
                ((ClassForMove)classEmergency).Pedestrian.MoveStatus = false;
                Thread.Sleep(20000);
            }
        }
    }
}
