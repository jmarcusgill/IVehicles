using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{


    public class Program
    {

        public static void Main() 
        {
            // Build a collection of all vehicles that fly
            
            var airVehicles = new List<IAirVehicle> 
            {
                new Cessna(), new Helicopter()
            };
        
            // With a single `foreach`, have each vehicle Fly()
            foreach (var vehicle in airVehicles)
            {
                vehicle.Fly();
                vehicle.Land();
                Console.WriteLine();
            }
            




            // Build a collection of all vehicles that operate on roads
            var roadVehicles = new List<IDrivableVehicle>
            {
                new Delorean(), new Motorcycle()
            };

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var vehicle in roadVehicles)
            {
                vehicle.Drive();
                vehicle.Stop();
                Console.WriteLine();
            }


            // Build a collection of all vehicles that operate on water
            var waterVehicles = new List<IWaterVehicle>
            {
                new Jetski(), new RowBoat()
            };
            // With a single `foreach`, have each water vehicle Drive()
            foreach (var vehicle in waterVehicles)
            {
                var drivableVehicle = vehicle as IDrivableVehicle; //cast operations
                if (drivableVehicle != null)
                {
                    drivableVehicle.Drive();
                    drivableVehicle.Stop();
                }

                vehicle.Start();
                Console.WriteLine();
            }
        }

    }

}