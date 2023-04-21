using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class Queue1
    {
        public static void Main(string[] args)
        {
            Queue nums= new Queue();
            nums.Enqueue(1);
            nums.Enqueue(2);
            nums.Enqueue(3);
            nums.Dequeue();
            nums.Enqueue(4);
            nums.Enqueue(5);
            nums.Dequeue();
            nums.Peek();
            Console.WriteLine(nums.Count);
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
