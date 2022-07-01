using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/20
 * 이름 : 김진재
 * 내용 : 예외처리 try catch finally 실습하기 교재 p467
 */
namespace Chapter08
{
    class Apple
    {
        public void Show()
        {
            Console.WriteLine("Apple Show...");
        }
    }

    internal class _1_Try
    {
        static void Main2(string[] args)
        {
            ////////////////////////
            ////try-catch
            ////////////////////////
            // 상황1 : 어떤 수를 0으로 나눌 때
            // 0으로 나누려고 하면 원래 난리 남

            int num1 = 1;
            int num2 = 0;
            int rs1 = 0, rs2 = 0, rs3 = 0, rs4 = 0;



            try
            {
                //예외가 발생할 수 있는 코드
                rs1 = num1 + num2;
                rs2 = num1 - num2;
                rs3 = num1 * num2;
                rs4 = num1 / num2;
            }

            catch (Exception e)
            {
                //예외가 발생 했을 때 처리할 코드
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("rs1 : "+rs1);
            Console.WriteLine("rs2 : "+rs2);
            Console.WriteLine("rs3 : "+rs3);
            Console.WriteLine("rs4 : "+rs4);

            // 상황2 : 배열의 인덱스를 범위를 벗어났을 때
            // 정해진 범위에서 벗어났을 때

            int[] arr = { 1, 2, 3, 4, 5 };

            try {

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // 상황3 : NULL 포인트 에러
            Apple a1 = new Apple();
            Apple a2 = null;

            try
            {
                a1.Show();
                a2.Show();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            ////////////////////////
            ////try-catch-finally
            ////////////////////////

            try
            {
                // 예외가 발생할 가능성이 있는 코드
                Console.WriteLine("try...");
            }
            catch(Exception e)
            {
                // 예외가 발생 했을 때 처리 코드
                Console.WriteLine("catch...");
            }
            finally
            {
                // 예외 발생 여부와 상관 없이 무조건 처리되어야 하는 코드
                Console.WriteLine("finally...");
            }

            Console.WriteLine("프로그램 종료...");

        }
    }
}
