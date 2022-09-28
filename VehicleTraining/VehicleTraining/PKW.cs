using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraining
{
    public class PKW : Vehicles
    {
        public string PKWcolor { get; set; }
        public string PKWname { get; set; }

        public PKW(string pKWcolor, string pKWname)
        {
            PKWcolor = pKWcolor;
            PKWname = pKWname;
        }

        public override void Print()
        {
            Console.WriteLine($"Das Auto hat die Farbe {PKWcolor} und heißt {PKWname}");
        }

        public override void beladen()
        {
            Console.WriteLine($"Das auto wurde mit Einkäufen beladen!");
        }

        public override void start()
        {
            Console.WriteLine("PKW hat gestartet!");
        }

        public override void speed()
        {
            Console.WriteLine("Das Auto fährt jetzt 170 im Ort, Marcello hat seinen Führerschein (wieder) verloren.");
        }

        public override void stop()
        {
            Console.WriteLine("Das Auto hat angehalten!");
        }

    }


   
}
