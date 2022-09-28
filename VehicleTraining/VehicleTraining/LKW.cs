using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraining
{
    public class LKW : Vehicles
    {
        public double Length { get; set; }
        public string Color { get; set; }

        public LKW(double length, string color)
        {
            Length = length;
            Color = color;
        }

        public override void Print()
        {
            Console.WriteLine($"Der LKW hat eine länge von {Length} meter und die Farbe {Color}");
        }
       
        public  override void beladen()
        {
            Console.WriteLine("LKW wurde mit den benötigten Wahren beladen");
        }

        public override void start()
        {
            Console.WriteLine("LKW wird gestartet!");
        }

        public override void speed()
        {
            Console.WriteLine("LKW fährt jetzt mit 120 kmh!");
        }

        public override void stop()
        {
            Console.WriteLine($"Der LKW hat angehalten!");
        }


    }
}
