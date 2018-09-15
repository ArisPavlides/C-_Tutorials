using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timespan = new TimeSpan(1, 2, 3); // input parameters are hours,minutes,seconds (i.e. 1 hour, 2 minutes & 3 seconds)
            int spanMins =  timespan.Minutes; // returns the minutes part of the object above (i.e. 2)
            double spanMinsTotal = timespan.TotalMinutes; // returns the total timespn above in minutes (i.e. 60+2+1/20)

            var time = TimeSpan.FromDays(3.5); // returns 3 days and 12 hours

            // deducting DateTimes returns TimeSpan (adding is not supported)
            DateTime date_1 = DateTime.Now;
            DateTime date_2 = DateTime.Now.AddDays(5);
            TimeSpan dateSubt = date_2 - date_1;

            // TimeSpan objects are immutable but can be changed used the add method by adding another timespan object
            TimeSpan timeSpanAdd = timespan.Add(TimeSpan.FromHours(3));

            // convert a TimeSpan object to string
            string timeSpanStr = new TimeSpan(1, 3, 5).ToString();

            // convert a string to TimeSpan
            TimeSpan spanFromStr = TimeSpan.Parse("03:05:07");
        }
    }
}
