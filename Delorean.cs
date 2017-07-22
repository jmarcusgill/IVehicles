using System;

namespace vehicles
{
    public class Delorean : IGroundVehicle, IDrivableVehicle
    {
        
        public double MaxSpeed { get ; set ; } = 88;
        public int Wheels { get ; set ; } = 4;
        public int Doors { get ; set ; } = 2;
        public int PassengerCapacity { get ; set ; } = 2;
        public string TransmissionType { get ; set ; } = "Flux Capacitor";
        public double EngineVolume { get ; set ; } = 1.21;

        public void Drive()
        {
            Console.WriteLine("When this baby hits...");
        }

        public void Start()
        {
           Console.WriteLine("Where we're going, we don't need roads..");
        }

        public void Stop()
        {
            Console.WriteLine("When the hell are we?");
        }
    }

}