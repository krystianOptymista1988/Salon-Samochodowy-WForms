using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Samochodowy_WF
{
    interface TransactionData
    {
      DateTime DateOfBuy { get; set; }
      DateTime? DateOfSell { get; set; }   
      String VinNumber { get; set; }
      String NoRegistration { get; set; }
      int PriceOfSell { get; set; }
    }
}
