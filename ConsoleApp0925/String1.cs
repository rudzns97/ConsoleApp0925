using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class String1
    {
        static void Main()
        {
            string str1 = "가나다라마바사";
            Console.WriteLine(str1.Contains('가'));




            //Console.Write("Email: ");
            //string strEmail = Console.ReadLine();
            //if (!strEmail.Contains('@'))
            //{
            //    Console.WriteLine("유효한 이메일이 아닙니다. 다시 입력해주세요.");
            //}
            //if (strEmail.IndexOf('@') < 1)
            //{
            //    Console.WriteLine("유효한 이메일이 아닙니다. 다시 입력해주세요.");
            //}

            //주민등록번호
            //Console.Write("주민등록번호(7자리) : ");
            //string strNum = Console.ReadLine();
            //string year, month, day, sex, gubun;
            //if (strNum.Length != 7)
            //{
            //    Console.WriteLine("주민등록번호 앞 7자리를 입력해주세요");
            //}

            //if (strNum.Substring(6) == "1" || strNum.Substring(6) == "2" ||
            //    strNum.Substring(6) == "5" || strNum.Substring(6) == "6")
            //    gubun = "19";
            //else
            //    gubun = "20";

            //year = string.Concat(gubun, strNum.Substring(0, 2));
            //month = strNum.Substring(2, 2).TrimStart('0');
            //day = strNum.Substring(4, 2);
            //sex = (strNum.Substring(6) == "1") ? "남" : "여";

            //Console.WriteLine($"출생년월: {year}년 {month}월 {day}일 \n {sex}성");


            //C:\Users\GDCS\Pictures\image\20191024114946.jpg
            string file = "C:\\Users\\GDC6\\Documents\\My Web Sites\\WebSite1\\bkg-blu.jpg";
            string filename = file.Substring(file.LastIndexOf('\\') + 1);
            Console.WriteLine(filename);

            string ext = filename.Substring(filename.IndexOf('.') + 1);
            if (ext.ToUpper().Equals("EXE"))
                Console.WriteLine("첨부할 수 없는 파일입니다");

            //오늘의 15번째 주문번호
            string num1 = "123 123 123 123";
            string today = DateTime.Now.ToString("yyyy-MM-HH-mm");
            today = DateTime.Now.ToShortDateString().Replace("-","");
            
            Console.WriteLine(today);

            int cnt = 15;
            string ordernum = today + cnt.ToString().PadLeft(5, '0');
            Console.WriteLine(ordernum);
        }
    }
}
