using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Samochodowy_WF
{
    internal class Car: Vehicle 
    {
        public int EnginePower;
        public string Color;
        public int NrOfAxies;
        public Car()
        {
            EngineeCapacity = 0;
            EnginePower = 0;
            Category = "osobowe";
            Color = "Biały";
            Weight = 0;
            NrOfAxies = 0;
        }
    }
}
