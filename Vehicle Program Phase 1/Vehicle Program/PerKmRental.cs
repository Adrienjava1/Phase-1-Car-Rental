using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Program
{
    public class PerKmRental
    {
        public PerKmRental(double kmTravelled)
        {
            KmTravelled = kmTravelled;
        }

        public double CalculateRentalCost()
        {
            // Calculate Rental Cost
            return KmTravelled * ChargingRate;
        }

        public double KmTravelled { get; set; }
        public double ChargingRate { get; set; } = 1;
    }
}
