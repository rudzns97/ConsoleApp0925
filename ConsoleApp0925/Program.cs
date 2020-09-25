using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            DateTime to = DateTime.Now;
            DateTime from = new DateTime(1995, 7, 11);
            TimeSpan interval = to - from;
            
            Console.WriteLine(interval.Days);

            string str = DateTime.Now.AddDays(3).ToString("yyyy.MM.dd");
            
            Console.WriteLine(str);
            Console.WriteLine((new DateTime(2019, 4, 16)).AddDays(600).AddDays(-7).ToShortDateString());

            DateTime dDay = new DateTime(2020, 9, 26, 13, 0, 0);
            double rHour = (dDay - DateTime.Now).TotalHours;
            Console.WriteLine(rHour);


        }
    }
}
