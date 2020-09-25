using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp0925
{
    class DateTime2
    {
        static void Main()
        {
            //System.Timers.Timer timer1 = new System.Timers.Timer();
            //timer1.Interval = 1000; //밀리세컨드
            //timer1.Elapsed += Timer1_Elapsed;
            //timer1.Start();

            //Console.ReadLine();
            //이번달 1일 부터 말일 까지
            DateTime firstday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); //1일로 고정
            //월초 구하기
            Console.WriteLine(firstday.ToShortDateString());
            //월말 구하기
            DateTime lastday = firstday.AddMonths(1).AddDays(-1);
            Console.WriteLine(lastday.ToShortDateString());

            Console.WriteLine($"{firstday.ToShortDateString()} ~ {lastday.ToShortDateString()}");

            //1주 구하기(이번주 일 ~ 토)
            firstday = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            lastday = firstday.AddDays(6);
            Console.WriteLine($"{firstday.ToShortDateString()} ~ {lastday.ToShortDateString()}");
        }

        private static void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
