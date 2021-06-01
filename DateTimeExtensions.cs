using System;
using System.Collections.Generic;

namespace ETTCCalendar2
{
    public static class DateTimeExtensions
    {
        public static List<DateTime> To(this DateTime startDate, DateTime endDate)
        {
            List<DateTime> times = new List<DateTime>();

            for (int i = 0; i <= (endDate.Date-startDate.Date).Days; i++)
            {
                times.Add(startDate.Date.AddDays(i));
            }

            return times;
        }
    }
}
