using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraining
{
    public class Motorrad : Vehicles
    {
        public string MTRmake { get; set; }
        public double MTRweight { get; set; }

        public Motorrad(string mTRmake, double mTRweight)
        {
            MTRmake = mTRmake;
            MTRweight = mTRweight;
        }

        public override void Print()
        {
            Console.WriteLine($"Das Motorrad ist von der Marke {MTRmake} und wiegt {MTRweight}kg.");
        }

        public override void beladen()
        {
            Console.WriteLine("Das Motorrad wurde mit Essen und Trinken ausgerüstet!");
        }

        public override void start()
        {
            Console.WriteLine($"");
        }

        public override void speed()
        {
            Console.WriteLine($"Das motorrad fährt jetzt mit 200 kmh auf der Autobahn!");
        }

        public override void stop()
        {
            Console.WriteLine("Motorrad hat angehalten");
        }


    }
}
