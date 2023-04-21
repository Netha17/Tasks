using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class Arraylist
    {
        static void Main(string[] args)
        {
            ArrayList nums = new ArrayList();
            nums.Add(1);
            nums.Add(2);
            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Contains(1));// return true because 1 is available in nums
            Console.WriteLine(nums.Contains(5));// return false because 5 isn't available in nums
            nums.RemoveAt(0);// element will be removed at indexed 0
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); 
            



        }
    }
}
