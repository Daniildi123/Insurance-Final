using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_VARIANT_2.Calculations
{
    public static class Calculation
    {
        public static decimal CalculationDamages(List<Damage> damages)
        {
            const decimal per = 0.78M;
            decimal totalDamageCost = 0M;

            if (damages.Any())
            {
                totalDamageCost = damages.Sum(damage => damage.Cost) * per;
            }

            return totalDamageCost;
        }
    }
}
