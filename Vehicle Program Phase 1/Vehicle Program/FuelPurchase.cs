using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Program
{
   public class FuelPurchase
    {
        public FuelPurchase(double fuelQuantityPurchased, double fuelCostPerL)
        {
            FuelQuantityPurchased = fuelQuantityPurchased;
            FuelCostPerL = fuelCostPerL;
        }

        public double CalculateFuelCost()
        {
            // Calculate Fuel Cost
            return FuelCostPerL * FuelQuantityPurchased;
        }

        public double FuelQuantityPurchased { get; set; }
        public double FuelCostPerL { get; set; }

    }
}
