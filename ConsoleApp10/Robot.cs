using System;

namespace RoboticFactory
{
    public abstract class Robot
    {
        public string modelName;
        public int batteryCapacity;
        public string softwareVersion;

        public Robot(string modelName, int batteryCapacity, string softwareVersion)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
        }

        public abstract Robot Clone();
        public abstract void DisplayDetails();
    }
}