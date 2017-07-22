using System;

namespace vehicles
{
    public class Motorcycle : IGroundVehicle, IDrivableVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxSpeed { get; set; } = 160.4;
        
    

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Start()
        {
            Console.WriteLine("AC/DC starts playing but you're heart is playing Bon-Jovi");
        }

        public void Stop()
        {
            Console.WriteLine("Gee officer, I didn't know I was going so fast...");
        }
    }

}