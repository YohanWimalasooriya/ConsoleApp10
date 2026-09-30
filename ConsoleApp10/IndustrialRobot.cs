using System;

namespace RoboticFactory
{
    public class IndustrialRobot : Robot
    {
        public string industrialTask;

        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.industrialTask = industrialTask;
        }

        public override Robot Clone()
        {
            return new IndustrialRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.industrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"IndustrialRobot: {modelName} {batteryCapacity}h {softwareVersion} {industrialTask}");
        }
    }
}