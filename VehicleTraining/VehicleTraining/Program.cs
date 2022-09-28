using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            vehicles.Add(new PKW("Rot", "BMW"));
            vehicles.Add(new LKW(10.5, "Blau"));
            vehicles.Add(new Motorrad("BMW", 100));

            foreach (Vehicles v in vehicles)
            {
                v.Print();
                v.beladen();
                v.start();
                v.speed();
                v.stop();
                
            }

            Console.ReadKey();
        }
    }
}
