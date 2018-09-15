using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main()
        {
            DateTime dateTime = new DateTime(2017, 9, 15); // create a new DateTime object with the 3 property values
            DateTime now = DateTime.Now; // now is a static method within the DateTime class 
            int minute = DateTime.Now.Minute;

            // DateTime objects are immutable so the only way to change them after they are  being created is to either recreate
            // them or use the .Add method
            DateTime future = now.AddDays(1);
            DateTime halfHourAgo = now.AddMinutes(-30);

            // DateTime to string
            string longDateString = now.ToLongDateString(); // 15 September 2018
            string shortDateString = now.ToShortDateString(); // 15/09/2018
            string longTimeString = now.ToLongTimeString(); // 12:28:33 
            string shortTimeString = now.ToShortTimeString(); // 12:28 
            string dateTimeStr = now.ToString(); // 15/09/2018 12:28:33 
            string yearStr = now.ToString("MM/dd/yyyy");
        }
    }
}
