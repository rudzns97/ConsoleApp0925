using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class String2
    {
        static void Main()
        {
            string txt = "Hello World";

            //Contains 사용
            Console.WriteLine(txt + " Contains(\"Hello\"): " + txt.Contains("Hello"));
            Console.WriteLine(txt + " Contains(\"Halo\"): " + txt.Contains("Halo"));
            Console.WriteLine();
            //EndsWith 사용
            Console.WriteLine(txt + " EndWith(\"rld\"): " + txt.EndsWith("rld"));
            Console.WriteLine(txt + $" EndWith(\"ello\"): " + txt.EndsWith("ello"));
            Console.WriteLine();
            //GetHashCode
            Console.WriteLine(txt + " GetHashCode(): " + txt.GetHashCode());
            Console.WriteLine( "Hello GetHashCode(): " + "Hello".GetHashCode());
            Console.WriteLine();
            //IndexOf
            Console.WriteLine(txt + " IndexOf(\"World\"): " + txt.IndexOf("World"));
            Console.WriteLine(txt + " IndexOf(\"Halo\"): " + txt.IndexOf("Halo"));
            Console.WriteLine();
            //Replace
            Console.WriteLine(txt + " Replace(\"World\", \"\"): " + txt.Replace("World", ""));
            Console.WriteLine(txt + " Replace('o', 't'): " + txt.Replace('o', 't'));
            Console.WriteLine();
            //Split
            Console.WriteLine(txt + " Split('o'): ");
            //Console.WriteLine(txt.Split('o'));
            OutputArrayString(txt.Split('o'));
            //char o = 'o';
            string[] arr = txt.Split('o');
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"*");
            }
            Console.WriteLine();
            Console.WriteLine(txt + " Split(' '): ");
            OutputArrayString(txt.Split(' '));
            Console.WriteLine();
            //StartsWith
            Console.WriteLine(txt + " StartsWith(\"Hello\"): " + txt.StartsWith("Hello"));
            Console.WriteLine(txt + " StartsWith(\"ello\"): " + txt.StartsWith("ello")); 
            Console.WriteLine();

            //Substring
            Console.WriteLine(txt + " Substring(1): " + txt.Substring(1));//1번째부터 마지막까지의 문자열을 반환
            Console.WriteLine(txt + " Substring(2,4): " + txt.Substring(2,4));//2번째부터 3개의 문자까지 취한 문자열을 반환(2,3,4)
            Console.WriteLine();

            //ToLower, ToUpper
            Console.WriteLine(txt + " ToLower(): " + txt.ToLower());
            Console.WriteLine(txt + " ToUpper(): " + txt.ToUpper());
            Console.WriteLine();

            //Trim
            Console.WriteLine("\" Hello World \" Trim(): " + " Hello World ".Trim());
            Console.WriteLine(txt+ "Trim('H'): " + txt.Trim('H'));
            Console.WriteLine();
        }

        private static void OutputArrayString(string[] arr)
        {
            foreach(string txt in arr)
            {
                Console.Write(txt + ", ");
            }
            Console.WriteLine();
        }
    }
}
