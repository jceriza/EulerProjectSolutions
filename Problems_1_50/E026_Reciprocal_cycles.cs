﻿using Utilities;

namespace Exercises
{
    public class E026_Reciprocal_cycles
    {
        public static int DecimalReciprocalCyclesUnder1000()
        {
            int maxCycle = 0;
            int index = 0;

            for (int i = 2; i < 1000; i++)
            {
                var cycleLength = Fraction.UnitFractionCycleLength(i);
                if (cycleLength > maxCycle)
                {
                    maxCycle = cycleLength;
                    index = i;
                }
            }

            return index;
        }
    }
}
