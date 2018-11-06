using ClassLibrary;
using DrawingObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class Utils
    {
        //движение машины
        public static void MoveObjectCar(object classForMove)
        {
            int check = 0;
            ((ClassForMove)classForMove).Car.MoveStatus = true;
            while (((ClassForMove)classForMove).PictureBox.Location.X + 400 > 10)
            {
                if (((ClassForMove)classForMove).TrafficLight.Light == TrafficLights.Green)
                {
                    ((ClassForMove)classForMove).Car.MoveOnGreen();
                       ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left - 15));
                    Thread.Sleep(50);
                }
                if (((ClassForMove)classForMove).TrafficLight.Light == TrafficLights.Red)
                {
                    ((ClassForMove)classForMove).Car.StopOnRed();
                    Thread.Sleep(4000);
                }
                if (((ClassForMove)classForMove).PictureBox.Left + 70 > ((ClassForMove)classForMove).EmergencyCauseBox.Left && ((ClassForMove)classForMove).PictureBox.Left - 70 < ((ClassForMove)classForMove).EmergencyCauseBox.Left && check == 0 && ((ClassForMove)classForMove).PictureBox.Top + 70 > ((ClassForMove)classForMove).EmergencyCauseBox.Top && ((ClassForMove)classForMove).PictureBox.Top - 70 < ((ClassForMove)classForMove).EmergencyCauseBox.Top && ((ClassForMove)classForMove).Pedestrian.MoveStatus==true && ((ClassForMove)classForMove).Car.MoveStatus == true)
                {
                    GenerateEmergencyCaseCar(classForMove);
                    check++;
                }
            }
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                   ((ClassForMove)classForMove).PictureBox.Left = 475));
            Thread.Sleep(100);
            MoveObjectCar(classForMove);
        }
        //движение пешехода
        public static void MoveObjectFrontPedestrian(object classForMove)
        {
            int check = 0;
            if (((ClassForMove)classForMove).TrafficLight.Light == TrafficLights.Green)
            {
                ((ClassForMove)classForMove).Pedestrian.StopOnRed();
                RunOnRed(classForMove);
                Thread.Sleep(7000);
                MoveObjectFrontPedestrian(classForMove);
            }
            while (((ClassForMove)classForMove).PictureBox.Location.X + 330 > 250)
            {
                ((ClassForMove)classForMove).Pedestrian.MoveOnGreen();
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left - 10));
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Top = ((ClassForMove)classForMove).PictureBox.Top + 10));
                Thread.Sleep(50);
            }
            if (((ClassForMove)classForMove).Car.BumpStatus==true)
            {
                GenerateEmergencyCasePedestrian(classForMove);
                check++;
                ((ClassForMove)classForMove).Car.BumpStatus = false;
            }
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                   ((ClassForMove)classForMove).PictureBox.Left = 200));
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                  ((ClassForMove)classForMove).PictureBox.Top = 100));
            Thread.Sleep(100);
            MoveObjectFrontPedestrian(classForMove);
        }
        //движение скорой
        public static void MoveObjectAmbulancy(object classForMove)
        {
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
            ((ClassForMove)classForMove).PictureBox.Visible = true));
            while ((((ClassForMove)classForMove).PictureBox.Left < 20))
            {
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left + 10));
                Thread.Sleep(50);
            }
            Thread.Sleep(13000);
            while ((((ClassForMove)classForMove).PictureBox.Left < 1000))
            {
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left + 10));
                Thread.Sleep(50);
            }
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
             ((ClassForMove)classForMove).PictureBox.Left = 1000));
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
            ((ClassForMove)classForMove).PictureBox.Visible = false));
            ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
             ((ClassForMove)classForMove).PictureBox.Left = 0));
            ((ClassForMove)classForMove).Pedestrian.MoveStatus = true;
            ((ClassForMove)classForMove).Pedestrian.LifeStatus=PedestrianStatus.healthy;
            ((ClassForMove)classForMove).Pedestrian.BumpStatus = false;
            ((ClassForMove)classForMove).Car.MoveStatus = true;
            ((ClassForMove)classForMove).Car.CrashStatus = CarStatus.OnTheRun;
            ((ClassForMove)classForMove).Car.BumpStatus = false;
            Thread.Sleep(100);
        }
        //проверка аварийного случая
        public static void CheckEmergencyCase(object classForMove)
        {
            while (true)
            {
                if (((ClassForMove)classForMove).Pedestrian.BumpStatus == true || ((ClassForMove)classForMove).Car.BumpStatus == true)
                {
                    MoveObjectAmbulancy(classForMove);
                }
            }
        }
        //аварийный случай для машины
        public static void GenerateEmergencyCaseCar(object classEmergency)
        {
            ((ClassForMove)classEmergency).PictureBox.Image = Image.FromFile("SmallMersCarEmergency.png");
            ((ClassForMove)classEmergency).Car.MoveStatus = false;
            ((ClassForMove)classEmergency).Car.CarEmergencyCase(); ;
            Thread.Sleep(15000);
            ((ClassForMove)classEmergency).PictureBox.Image = Image.FromFile("SmallMersCar.png");
        }
        //аварийный случай для пешехода
        public static void GenerateEmergencyCasePedestrian(object classEmergency)
        {
            ((ClassForMove)classEmergency).Pedestrian.MoveStatus = false;
            ((ClassForMove)classEmergency).Pedestrian.PedestrianEmergencyCase();
            //Thread.Sleep(15000);
            Thread.Sleep(10000);
        }
        //пробежать на красный
        public static void RunOnRed(object classForMove)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 3) == 1)
            {
                ((ClassForMove)classForMove).Pedestrian.MoveOnGreen();
                ((ClassForMove)classForMove).Pedestrian.MoveStatus = true;
                while (((ClassForMove)classForMove).PictureBox.Location.X + 400 > 250)
                {
                    ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                        ((ClassForMove)classForMove).PictureBox.Left = ((ClassForMove)classForMove).PictureBox.Left - 10));
                    ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                        ((ClassForMove)classForMove).PictureBox.Top = ((ClassForMove)classForMove).PictureBox.Top + 10));
                    Thread.Sleep(50);
                }
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                   ((ClassForMove)classForMove).PictureBox.Left = 200));
                ((ClassForMove)classForMove).PictureBox.Invoke(new MethodInvoker(() =>
                      ((ClassForMove)classForMove).PictureBox.Top = 100));
                Thread.Sleep(50);
            }
        }
    }
}
