using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateCal
{
    class Program
    {
        static void Main(string[] args)
        {
            HijriCalendar hc = new HijriCalendar();
            string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            DisplayValues(hc, DateTime.Now);
            Console.WriteLine(days[GetFirstDayOfMonth(7)-1]);
            Console.ReadKey();
        }

        public static void DisplayValues(Calendar myCal, DateTime myDT)
        {
            var firstDay = new DateTime(myDT.Year, myDT.Month, 1);
            Console.WriteLine("First Day : {0}", firstDay);
            Console.WriteLine("   Era:        {0}", myCal.GetEra(myDT));
            Console.WriteLine("   Year:       {0}", myCal.GetYear(myDT));
            Console.WriteLine("   Month:      {0}", myCal.GetMonth(myDT));
            Console.WriteLine("   DayOfYear:  {0}", myCal.GetDayOfYear(myDT));
            Console.WriteLine("   DayOfMonth: {0}", myCal.GetDayOfMonth(myDT));
            Console.WriteLine("   DayOfWeek:  {0}", myCal.GetDayOfWeek(myDT));
            Console.WriteLine();

        }

        public static int GetFirstDayOfMonth(int day)
        {
            int d = 23;
            while (d > 1)
            {
                if (day == 1)
                    day = 7;
                else
                    day--;
                d--;
            }

            return day;
        }
    }
}
