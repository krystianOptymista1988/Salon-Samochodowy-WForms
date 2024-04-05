using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Samochodowy_WF
{
    interface IVehicle
    {
        string Model { get; set; }
        int CarMileage { get; set; }
        string Category { get; set; }
        double Weight { get; set; }
        double EngineeCapacity { get; set; }
    }
}
