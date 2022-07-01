using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/21
 * 이름 : 김진재
 * 내용 : Linq 실습하기 교재 p525
 *
 *Linq
 * - Linq*(Language Ingergrat Query)는 컬렉션 형태의 데이터를 가공처리 하기 위한 C# 질의언어
 * - Linq를 사용해서 DB와 함께 데이터를 쉽게 관리
 */

namespace Chapter09
{
    class member
    {
        private string uid;
        private string name;
        private int age;

        public member(string uid, string name, int age)
        {
            this.uid = uid;
            this.name = name;
            this.age = age;
        }

        private string uid
        private string name;
        private int age;
    }
    internal class _3_Linq
    {
        static void Main(string[] args)
        {
            //컬렉션 생성
            List<int> dataset = new List<int>() {1,2,3,4,5,6,7,8,9 };

            //짝수 데이터 리스트 추출하기
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();

            foreach(int i in dataset)
            {
                if ( new % 2 == 0 )
                {
                    result1.Add(n);
                }
            }

            dataset.ForEach(n) =>
            {
                if (new % 2 == 0)
                {
                    result2.Add(n);
                }
            });


            var result3 = from n in dataset
                          where n % 2 == 0
                          select n;

            Console.WriteLine("result1 : " +string.Join(",", result1));
            Console.WriteLine("result2 : " +string.Join(",", result2));
            Console.WriteLine("result3 : " +string.Join(",", result3));

            // dataset에서 데이터가 5 이상 큰 순서대로 출력
            var result4 = from n in dataset
                          where n >= 5
                          orderby n descending
                          select n;

            Console.WriteLine("result4 : " + string.Join(",", result4));

            //객체 리스트 Linq 이용
            List<Member> members = new List<Member>();
            member.Add(new Member("a101", "김유신", 25));
            member.Add(new Member("a102", "김춘추", 23));
            member.Add(new Member("a103", "장보고", 35));
            member.Add(new Member("a104", "강감찬", 45));
            member.Add(new Member("a105", "이순신", 55));

            //30세 이상
            var result5 = from member in members
                          where member.age >= 30
                          orderby member.Name ascending
                          select member;
            foreach(member m in result5)
            {
                Console.WriteLine("{ 0},{ 1},{ 2}", m.uid, m.name, m.age);
            }
        }
    }
}
