using Chapter06.Sub3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/15
 * 이름 : 김진재
 * 내용 : 컬렉션 HashTable/Dictionary 실습
 *
 */
namespace Chapter07
{
    internal class _4_HashTable
    {
        static void Main4(string[] args)
        {
            // 테이블 생성
            Hashtable table = new Hashtable();

            // k-v 쌍 데이터 저장
            table['A'] = "Apple";
            table['B'] = "Banana";
            table['C'] = "Cherry";

            // 데이터 출력
            Console.WriteLine("table['A'] : " + table['A']);
            Console.WriteLine("table['B'] : " + table['B']);
            Console.WriteLine("table['C'] : " + table['C']);

            // 반복문 데이터 출력
            foreach(char k in table.Keys)
            {
                Console.WriteLine(table[k]);
            }

            //////////////////////////
            ////Dictionary
            //////////////////////////
            
            Dictionary<char, string> dic = new Dictionary<char, string>();

            dic['A'] = "Apple";
            dic.Add('B', "Banana");
            dic.Add('C', "Cherry");
            // dic['B'] = "Banana";
            // dic['C'] = "Cherry";

            // 데이터 출력

            Console.WriteLine("dic['A'] : " + dic['A']);
            Console.WriteLine("dic['B'] : " + dic['B']);
            Console.WriteLine("dic['C'] : " + dic['C']);

            //반복문 데이터 출력
            foreach (char k in table.Keys)
            {
                Console.WriteLine(table[k]);
            }

            //딕셔너리 생성2
            Dictionary<int, string> people = new Dictionary<int, string>();

            //데이터 입력2
            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            /*
            people.['101'] = "김유신";
            people.Add('102', "김춘추");
            people.Add('103', "장보고");
            people.Add('104', "강감찬");
            people.Add('105', "이순신");
            */

            foreach (int k in people.Keys)
            {
                Console.WriteLine(people[k]);
            }


            //////////////////////////
            ////Dictionary/List 응용
            //////////////////////////
            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();

            d1.Add(101, new Apple("한국", 3000));
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));

            d2.Add(201, new Apple("중국", 3000));
            d2.Add(202, new Apple("대만", 2000));
            d2.Add(203, new Apple("홍콩", 1000));


            d3.Add(301, new Apple("호주", 3000));
            d3.Add(302, new Apple("영국", 2000));
            d3.Add(303, new Apple("인도", 1000));

            List<Dictionary<int, Apple>> apples = new List<Dictionary<int,Apple>>();
            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);

            //한국 사과 출력
            Dictionary<int, Apple> d = apples[0];
            Apple a = d[101];
            a.show();

            //미국 사과 출력 -> 한 줄 출력 방법
            apples[0][102].show();


            //대만 사과 출력
            apples[0][202].show();


            //인도 사과 출력
            apples[0][303].show();



        }
    }
}
