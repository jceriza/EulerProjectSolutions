using System;

namespace Utilities
{
    public class XXCenturyDate
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public int Day { get; private set; } = 1;
        public int Month { get; private set; } = 1;
        public int Year { get; private set; } = 1900;
        public DaysOfWeek DayOfWeek { get; private set; } = DaysOfWeek.Monday;

        private int DaysInThisMonth()
        {
            switch (Month)
            {
                case 2:
                    if (Year % 4 == 0 && (!(Year % 100 == 0) || Year % 400 == 0))
                    {
                        return 29;
                    }

                    return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
                
            }
        }

        public XXCenturyDate NextMonth()
        {
            DayOfWeek = (DaysOfWeek)(((int)DayOfWeek + DaysInThisMonth()) % 7);

            Month = (Month + 1) % 12;

            if (Month == 1)
            {
                Year += 1;
            }

            return this;
        }
    }
}
