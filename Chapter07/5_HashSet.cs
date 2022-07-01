using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/15
 * 이름 : 김진재
 * 내용 : 컬렉션 HashSet 실습
 *
 */
namespace Chapter07
{
    internal class _5_HashSet
    {
        static void Main5(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2);
            set.Add(3);

            Console.WriteLine("집합 원소 갯수 : " + set.Count);

            foreach (int n in set)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //집합 연산
            HashSet<int> set1 = new HashSet<int>(){ 1,2,3,4,5};
            HashSet<int> set2 = new HashSet<int>(){ 2,4,5,6,7};

            var rsesult1 = set1.Intersect(set2);// 교집합
            var rsesult2 = set1.Union(set2);    // 합집합
            var rsesult3 = set1.Except(set2);   // 차집합

            foreach (int n in rsesult1)
                Console.Write(n + "");
            Console.WriteLine();

            foreach (int n in rsesult2)
                Console.Write(n + " ");
            Console.WriteLine();

            foreach (int n in rsesult3)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
