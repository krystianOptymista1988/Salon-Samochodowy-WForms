using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Samochodowy_WF
{
    public class Car : TransactionData, IVehicle
    {
        public int? Id { get; set; }
        public string Model {  get; set; }
        public string Category { get; set; }
        public double EngineeCapacity { get; set; }    
        public int EnginePower { get; set; }
        public double Weight { get; set; } 
        public string Color { get; set; }
        public int NrOfAxies { get; set; }

        public int CarMileage { get; set; }
        public string VinNumber { get; set; }
        public string NoRegistration { get; set; }
        public DateTime DateOfBuy { get; set; }
        public double PriceOfSell { get;set; }
        public DateTime? DateOfSell { get; set;}
        public string Picturelocalization { get; set; }


    }
}
