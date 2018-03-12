using Utilities;

namespace Exercises
{
    public static class E019_Counting_Sundays
    {
        public static int CountSundays()
        {
            var sundays = 0;

            for (var date = new XXCenturyDate(); date.Year < 2001; date.NextMonth())
            {
                if (date.Year > 1900 && date.DayOfWeek == XXCenturyDate.DaysOfWeek.Sunday)
                {
                    sundays += 1;
                }
            }

            return sundays;
        }
    }
}
