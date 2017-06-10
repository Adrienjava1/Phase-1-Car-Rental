using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Program
{
    public class Service
    {
        public Service(double totalKmTravelled)
        {
            TotalKmTravelled = totalKmTravelled;
        }
        public double TotalKmTravelled { get; set; }
    }
}
