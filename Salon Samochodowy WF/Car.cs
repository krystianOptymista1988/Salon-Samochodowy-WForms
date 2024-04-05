using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Samochodowy_WF
{
    internal class Car : Vehicle 
    {
        public int Id { get; set; }
        public int EnginePower { get; set; }
        public string Color { get; set; }
        public int NrOfAxies { get; set; }

    }
}
