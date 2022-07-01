using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/03
* 이름 : 김진재
* 내용 : 문자열 실습 교재 p106
*/


namespace Chapter2
{
    internal class _6_String
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";/*문자열의 길이를 length*/

            Console.WriteLine("Greeting: "+greeting);
            Console.WriteLine();

            //문자열 길이
            Console.WriteLine("greeting 길이 : "+greeting.Length);
            Console.WriteLine();

            //문자열 추출
            Console.WriteLine("greeing[0] : "+greeting[0]);
            Console.WriteLine("greeing[3] : "+greeting[3]);
            Console.WriteLine("greeing[5] : "+greeting[5]);
            Console.WriteLine();

            //indexOf
            Console.WriteLine("IndexOf 'G': "+greeting.IndexOf('G'));
            Console.WriteLine("IndexOf \"G\": "+greeting.IndexOf("G"));
            Console.WriteLine("IndexOf 'o' :"+greeting.IndexOf('o'));
            Console.WriteLine("IndexOf \"Mor\": "+greeting.IndexOf("Mor"));
            Console.WriteLine("IndexOf \"ing\": "+greeting.IndexOf("ing"));
            Console.WriteLine();

            //LastIndexOf /문장에서 몇번째 
            Console.WriteLine("LastIndexOF 'G':"+greeting.LastIndexOf('G'));
            Console.WriteLine("LastIndexOF 'o':"+greeting.LastIndexOf('o'));
            Console.WriteLine("LastIndexOF \"Mor\':"+greeting.LastIndexOf("Mor"));
            Console.WriteLine("LastIndexOF \"ing\':"+greeting.LastIndexOf("ing"));
            Console.WriteLine();

            //Substring /구간 자르기
            Console.WriteLine("Substring(0, 4) : {0}", greeting.Substring(0, 4)); /*0에서 4까지 good */
            Console.WriteLine("Substring(5, 7) : {0}", greeting.Substring(5, 7)); /*5에서 7까지 good */
            Console.WriteLine("Substring(5) : {0}", greeting.Substring(5));
            Console.WriteLine();


            //Replace /교체
            string replaced = greeting.Replace("Morning", "Afternoon"); //모닝을 애프터눈으로 교체함
            Console.WriteLine("replaced : " + replaced);
            Console.WriteLine();

            //기본형 데이터를 문자열로 변환 // 정수int 실수double 논리bool 문자char -> 기본형
            int    var1 = 1;
            double var2 = 2.12;
            bool   var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = ""+var3;

            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2: " + str2);
            Console.WriteLine("str1 : " + str3);

            //문자열 데이터를 기본형으로 변환 // 
            string s1 = "3"; //int
            string s2 = "3.14"; //double
            string s3 = "false"; //true false

            int r1 = int.Parse(s1);
            double r2 = double.Parse(s2);
            bool r3 = bool.Parse(s3);

            Console.WriteLine($"r1 : {r1}");
            Console.WriteLine($"r2 : {r2}");
            Console.WriteLine($"r3 : {r3}");
            Console.WriteLine();


        }
    }
}
