using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Program
{
   public class PerDayRental
    {
        public PerDayRental(int daysRented)
        {
            DaysRented = daysRented;
        }

        public double CalculateRentalCost()
        {
            return DaysRented * ChargingRate;
        }

        public int DaysRented { get; set; }
        public double ChargingRate { get; set; } = 100;
    }
}
