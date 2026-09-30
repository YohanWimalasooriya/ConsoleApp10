using System;

namespace RoboticFactory
{
    public class EntertainmentRobot : Robot
    {
        public string entertainmentFeature;

        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.entertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            return new EntertainmentRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.entertainmentFeature);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"EntertainmentRobot: {modelName} {batteryCapacity}h {softwareVersion} {entertainmentFeature}");
        }
    }
}