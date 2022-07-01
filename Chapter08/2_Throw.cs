using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/20
 * 이름 : 김진재
 * 내용 : 예외처리 Throw 실습하기 교재 p469
 */
namespace Chapter08
{
    class Box
    {
        private int width;
        private int height;

        public int Width {
            get { return width; }
            set { width = value; } }
        public int Height {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    height = value;
                }
                else
                {
                    // 세로 길이가 0보다 작을 경우 예외가 강제 발생
                    throw new Exception("높이는 0보다 커야 합니다.");
                }
            }
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void Area()
        {
            Console.WriteLine("Box 넓이 : " + width * height);
        }
    }
    internal class _2_Throw
    {
        static void Main2(string[] args)
        {
            try
            {
                // 강제 발생된 예외를 처리
                Box box1 = new Box(10, 10);
                box1.Area();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
