using System;

namespace RoboticFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            ServiceRobot hospitalRobot = new ServiceRobot("SR-Alpha", 12, "v1.0", "PatientCare");
            hospitalRobot.DisplayDetails();

            ServiceRobot hospitalRobotUpdated = (ServiceRobot)hospitalRobot.Clone();
            hospitalRobotUpdated.batteryCapacity = 20;
            hospitalRobotUpdated.softwareVersion = "v1.5";
            hospitalRobotUpdated.DisplayDetails();

           
            IndustrialRobot weldingRobot = new IndustrialRobot("IR-Titan", 24, "v2.0", "Welding");
            weldingRobot.DisplayDetails();

            IndustrialRobot assemblyRobot = (IndustrialRobot)weldingRobot.Clone();
            assemblyRobot.industrialTask = "Assembly";
            assemblyRobot.DisplayDetails();

            Console.ReadLine();
        }
    }
}