using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/15
 * 이름 : 김진재
 * 내용 : 컬렉션 큐 실습
 */
namespace Chapter07
{
    internal class _2_Queue
    {
        static void Main2(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");
            queue.Enqueue("5");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
