

using System;

namespace vehicles
{
    public class Jetski : IWaterVehicle, IDrivableVehicle
    {
        public int Wheels { get ; set ; } = 0;
        public int Doors { get ; set ; } = 3;
        public int PassengerCapacity { get ; set ; } = 1;
        public string TransmissionType { get ; set ; } = "Variable";
        public double EngineVolume { get ; set ; } = 3.1;
        public double MaxSpeed { get ; set ; } = 42;
        public void Drive()
        {
           Console.WriteLine("The jetski zips through the waves as your mullet gracefully flows in the wind");
        }

        public void Start()
        {
            Console.WriteLine("Hey y'all watch this!");
        }

        public void Stop()
        {
            Console.WriteLine("Call 911!");
        }
    }
}