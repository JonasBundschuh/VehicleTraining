using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraining
{
    public abstract class Vehicles
    {
        public abstract void Print();
        
        public abstract void beladen();

        public abstract void start();
        public abstract void speed();
        public abstract void stop();    
    }
}
