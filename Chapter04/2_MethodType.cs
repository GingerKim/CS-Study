using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 매서드 타입 실습 교재 265p
매서드는 매개변수, 리턴값, 유무에 따라 총 4가지 타입으로 분류
1타입이 애가 일반적임



namespace Chapter4
{
    internal class _2_MethodType
    {
        static void Main(string[] args)
        {
            //매서드 호출
            double y1 = type1(0.1); //인자값 0.1
            double y2 = type1(1.2);

            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);

            type2(true);  //반환값이 필요 없으므로 대입연산자 필요없음
            type2(false);

            string result = Type3();
            Console.WriteLine("Type result :" + result);

            type4();

        }
        //type1 매개변수 0 리턴값 0

        public static double type1(double x)
        {
            double y = x + 3.14;
            return y;

        }

        //type2 매개변수0 리턴값 x
        public static void type2(bool status)
            if (status)
            {
            Console
            }
        //type3 : 매개변수 x, 리턴값 o
    public static string Type3()
    {
        int n1 = 1, n2 = 2;

        if (n1 > n2)
            return "n1은 n2보다 크다.";
        else
            return "n1은 n2보다 작다.";
    }

      //type4 매개변수x 리턴값x
    public static vod Type4()
    {
        double result = type(1.121);
        Console.WriteLine( "type "

    }


    }
}
*/